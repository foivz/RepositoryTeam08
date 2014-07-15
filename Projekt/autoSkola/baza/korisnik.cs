using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace autoSkola
{
    /// <summary>
    /// klasa Korisnik
    /// </summary>
    public class korisnik
    {
        public int ID_korisnik;
        public string ime;
        public string prezime;
        public string korisnicko_ime;
        public string lozinka;
        public string oib;
        public string mail;
        public string telefon;
        public int ID_korisnikTip;
        public bool promjena;
        public korisnik() { }
        public korisnik(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
                ime = dr["ime"].ToString();
                prezime = dr["prezime"].ToString();
                korisnicko_ime = dr["korisnicko_ime"].ToString();
                lozinka = dr["lozinka"].ToString();
                oib = dr["oib"].ToString();
                mail = dr["mail"].ToString();
                telefon = dr["telefon"].ToString();
                ID_korisnikTip = int.Parse(dr["ID_korisnikTip"].ToString());
                promjena = false;
            }

        }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_korisnik == 0 || ID_korisnik==null)
            {
                sqlUpit = "INSERT INTO korisnik (ID_korisnik,ime,prezime,korisnicko_ime,lozinka,oib,mail,telefon,ID_korisnikTip) VALUES (dbo.default_korisnik(), '" + ime + "','" + prezime + "','" + korisnicko_ime + "','" + lozinka + "','" + oib + "','" + mail + "','" + telefon + "'," + ID_korisnikTip + ")";
            }
            else
            {
                sqlUpit = "UPDATE korisnik SET ime = '" + ime
                + "', prezime='" + prezime
                + "', korsinicko_ime='" + korisnicko_ime
                + "', lozinka='" + lozinka
                + "', oib='" + oib
                + "', mail='" + mail
                + "', telefon='" + telefon
                + "', ID_korisnikTip=" + ID_korisnikTip
                + " WHERE ID_korisnik=" + ID_korisnik;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
        /// <summary>
        /// provjera prijave korisnika
        /// </summary>
        /// <param name="korIme">korisničko ime</param>
        /// <param name="lozinka">lozinka</param>
        /// <returns>tip korisnika (string) ili null ako korisnik ne postoji</returns>
        public string Provjera(string korIme, string lozinka)
        {
            string sqlUpit = "SELECT ID_korisnikTip FROM korisnik WHERE korisnicko_ime='" + korIme + "' AND lozinka='" + lozinka + "';";
            int korisnikTipID ;
            try
            {
                korisnikTipID = (int)baza.Instanca.DohvatiVrijednost(sqlUpit);
            }
            catch (NullReferenceException)
            {
                //provjeriti jel postoje podatci u xmlu i dodati ih ili vrati null
                return null;
            }


            return korisnikTipID.ToString();
            
        }
    }
}
