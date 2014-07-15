using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using autoSkola.forme;

namespace autoSkola
{
    public partial class formPrijava : Form

    {////

        public data podaci;
        public formPrijava()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            
            korisnik Korisnik = new korisnik(); 
            bool imaNeta = true;
            string sqlUpit = "SELECT ID_korisnik FROM korisnik WHERE korisnicko_ime='" + txtKorIme.Text + "' and lozinka='" + txtLozinka.Text + "';";
            int ID = 0;
            try
            {
                ID = (int)baza.Instanca.DohvatiVrijednost(sqlUpit);
            }
            catch (Exception)
            {
                imaNeta = false;
            }
            string korisnikTip = null;
            if (imaNeta)
                korisnikTip = Korisnik.Provjera(txtKorIme.Text, txtLozinka.Text);
            else 
            { 
                string docPath = "xml/korisnik.xml";
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("korisnik"))
                    {
                        string korIme = el.Element("korisnicko_ime").Value.ToString().Trim();
                        string lozinka = el.Element("lozinka").Value.ToString().Trim();
                        if (korIme == txtKorIme.Text && lozinka == txtLozinka.Text)
                        {
                            korisnikTip = el.Element("ID_korisnikTip").Value.ToString();
                            break;
                        }
                    }
                    MessageBox.Show("Niste spojeni na bazu podataka!");
                }
                else
                    MessageBox.Show("Provjerite svoju internet vezu!");
            }
                
            if (korisnikTip == null)
            {
                MessageBox.Show("Korisnik ne postoji!");
            }
            else
            {

                podaci = new data(txtKorIme.Text, txtLozinka.Text, korisnikTip);

                if (int.Parse(korisnikTip)==100)
                {
                    forme.frmUcenik forma = new frmUcenik(ID.ToString());
                    forma.ShowDialog();
                }
                else if (int.Parse(korisnikTip) == 101 || int.Parse(korisnikTip) == 102)
                {
                    formUciteljGlavni frmUciteljGlavni = new formUciteljGlavni(podaci,ID);
                    this.Hide();
                    frmUciteljGlavni.Show();
                }
                else
                {
                    forme.frmGlavna glavna = new forme.frmGlavna();
                    glavna.ShowDialog();
                }
                #region obrisano
                ///<summary>
                /// back je dretva koja periodično provjerava postoje li promjene u klasama i ažurira ih
                ///</summary>
                //System.Threading.Thread back;
                //updateDB ba = new updateDB();
                //ba.DT = podaci;
                //back = new System.Threading.Thread(ba.startUpdateDB);
                //back.IsBackground = true;
                //back.Start();
                
                //System.Threading.Thread back2;
                //updateFTP fp = new updateFTP(podaci);
                #endregion
            }

        }
        #region obrisano 2
        /// <summary>
        /// override Close (x) btn!
        /// </summary>
        /// <param name="e"> form closing event</param>
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);
        //    if (e.CloseReason == CloseReason.WindowsShutDown) 
        //        return;
        //    else
        //        baza.Instanca.Zatvori(podaci, false);
        //}
        #endregion
        private void formPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
