using autoSkola.forme;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace autoSkola
{
    public static class KorisnikPrijava
    {
        public static bool verificirajKorisnika(string korisnickoIme, string lozinka, ref data podaci)
        {
            korisnik Korisnik = new korisnik();
            bool imaNeta = true;
            string sqlUpit = "SELECT ID_korisnik FROM korisnik WHERE korisnicko_ime='" + korisnickoIme + "' and lozinka='" + lozinka + "';";
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
                korisnikTip = Korisnik.Provjera(korisnickoIme, lozinka);
            else
            {
                string docPath = "xml/korisnik.xml";
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("korisnik"))
                    {
                        string korIme = el.Element("korisnicko_ime").Value.ToString().Trim();
                        string pass = el.Element("lozinka").Value.ToString().Trim();
                        if (korIme == korisnickoIme && pass == lozinka)
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

                podaci = new data(korisnickoIme, lozinka, korisnikTip);

                if (int.Parse(korisnikTip) == 100)
                {
                    forme.frmUcenik forma = new frmUcenik(ID.ToString());
                    forma.ShowDialog();
                }
                else if (int.Parse(korisnikTip) == 101 || int.Parse(korisnikTip) == 102)
                {
                    formUciteljGlavni frmUciteljGlavni = new formUciteljGlavni(podaci, ID);
                    frmUciteljGlavni.Show();
                }
                else
                {
                    forme.frmGlavna glavna = new forme.frmGlavna();
                    glavna.ShowDialog();
                }

                return true;
            }

            return false;
        }
    }
}
