using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola
{
    class updateFTP
    {
        public data DT;
        public string projectDir()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        }
        public updateFTP(data data) { DT = data; }
        class ftp
        {
            private string host;
            /// <summary>
            /// host je potpuna adresa hosta (user@host), ako želimo pohraniti u neki određeni folder na serveru dodajemo putanju u naziv hosta (user@host/folder)
            /// </summary>
            private string user;
            private string pass;
            /// <summary>
            /// user je korisničko ime, a pass šifra korisnika na poslužitelju
            /// </summary>

            public ftp(string host, string uName, string pass)
            {
                this.host = host;
                this.user = uName;
                this.pass = pass;
            }

            /// <summary>
            /// metoda za dohvačanje podataka s ftp servera, potrebno je zadati naziv podatka na serveru, drugi argument je putanja za pohranu na lokalnom računalu 
            /// </summary>
            /// <param name="src"></param>
            public void getFrom(string src, string loc)
            {
                //postavljanje veze
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + host + "/" + src);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(user, pass);
                //preuzimanje podataka
                FtpWebResponse response;
                try
                {
                    response = (FtpWebResponse)request.GetResponse();
                }
                finally { }
                //obrada i pohrana
                Stream responseStream = response.GetResponseStream();
                System.IO.FileInfo file = new System.IO.FileInfo(loc + "/" + src);
                file.Directory.Create();
                using (Stream s = File.Create(loc + "/" + src))
                {
                    responseStream.CopyTo(s);
                }
                response.Close();
            }
            /// <summary>
            /// preuzima podatak definiran prvim arhumentom s lokalnog računala zadanu drugim argumentom, i pohranjuje na server
            /// </summary>
            /// <param name="name"></param>
            public void setTo(string name, string path)
            {

                // postavljanje veze
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + host + "/" + name);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, pass);

                // priprema podatka
                StreamReader sourceStream = new StreamReader(path);
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;
                //slanje
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
            }
        }








        //update ftp materijala
        public void update()
        {
            if (!Directory.Exists(projectDir() + "/materijal"))
                System.IO.Directory.CreateDirectory(projectDir() + "/materijal");
            if (!Directory.Exists(projectDir() + "/pitanja"))
                System.IO.Directory.CreateDirectory(projectDir() + "/pitanja");
            if (!Directory.Exists(projectDir() + "/odgovor"))
                System.IO.Directory.CreateDirectory(projectDir() + "/odgovor");
            ftp data = new ftp("bgrgicak@arka.foi.hr/pi", "bgrgicak", "u5zFhkYk");
            for (int i = 0; i < DT.Materijal.Count; i++)
            {
                if (DT.Materijal[i].srcMaterijal != "" && !File.Exists(projectDir() + "/materijal/" + DT.Materijal[i].srcMaterijal))
                {
                    data.getFrom("materijal/" + DT.Materijal[i].srcMaterijal, projectDir());
                }
            }
            for (int i = 0; i < DT.Odgovor.Count; i++)
            {
                if (DT.Odgovor[i].srcOdgovor != "" && !File.Exists(projectDir() + "/odgovor/" + DT.Odgovor[i].srcOdgovor))
                {
                    data.getFrom("odgovor/" + DT.Odgovor[i].srcOdgovor, projectDir());
                }
            }
            for (int i = 0; i < DT.Pitanja.Count; i++)
            {
                if (DT.Pitanja[i].srcPitanja != "" && !File.Exists(projectDir() + "/pitanja/" + DT.Pitanja[i].srcPitanja))
                {
                    data.getFrom("pitanja/" + DT.Pitanja[i].srcPitanja, projectDir());
                }
            }

        }
        public void startUpdate()
        {
            while (true)
            {
                update();
                System.Threading.Thread.Sleep(300000);
            }
        }
        //preuzima s file forme ili kako se vec zove i pohranjuje u lokalni folder
        public void preuzmiLokalno(string tip, DialogResult result, formUciteljNMaterijal mat)
        {
            if (result == DialogResult.OK)
            {
                string sourceFile = mat.openFileDialog123.FileName;
                string[] polje = sourceFile.Split('\\');
                string p2 = polje[polje.Length - 1].Substring(0, polje[polje.Length - 1].Length);
                string destFile = tip + "\\" + p2;
                if (tip == "materijal")
                {
                    materijal aab = new materijal();
                    aab.ID_materijal = 0;
                    aab.ID_cjelina = int.Parse(mat.comboBox1.SelectedValue.ToString());
                    aab.opis = mat.textBox1.Text.ToString();
                    aab.srcMaterijal = p2;
                    aab.promjena = false;
                    DT.Materijal.Add(aab);
                    aab.Spremi();
                }
                else if (tip == "odgovor")
                {
                    odgovor aab = new odgovor();
                    aab.ID_odgovor = 0;
                    aab.ID_pitanja = int.Parse(mat.comboBox1.SelectedValue.ToString());
                    aab.srcOdgovor = p2;
                    aab.promjena = false;
                    DT.Odgovor.Add(aab);
                    aab.Spremi();
                }
                else if (tip == "pitanja")
                {
                    pitanja aab = new pitanja();
                    aab.ID_pitanja = 0;
                    aab.ID_cjelina = int.Parse(mat.comboBox1.SelectedValue.ToString());
                    aab.tekst = mat.textBox1.Text.ToString();
                    aab.srcPitanja = p2;
                    aab.promjena = false;
                    DT.Pitanja.Add(aab);
                    aab.Spremi();
                }
                ftp aa = new ftp("bgrgicak@arka.foi.hr/pi", "bgrgicak", "u5zFhkYk");
                aa.setTo("/" + tip + "/" + p2, sourceFile);
            }
        }
    }

}