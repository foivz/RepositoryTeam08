using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace autoSkola
{
    public class updateDB
    {
        public data DT;
        public bool radi = true;
        public void startUpdateDB() {
            while (radi)
            {
                saveDB();
                System.Threading.Thread.Sleep(30000);
            }
        }
        public bool saveDB() {
            for (int i = 0; i < DT.Cjelina.Count; i++)
            {
                if (DT.Cjelina[i].promjena == true)
                {
                    DT.Cjelina[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Dogadjaj.Count; i++)
            {
                if (DT.Dogadjaj[i].promjena == true)
                {
                    DT.Dogadjaj[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Grupa.Count; i++)
            {
                if (DT.Grupa[i].promjena == true)
                {
                    DT.Grupa[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Ispit.Count; i++)
            {
                if (DT.Ispit[i].promjena == true)
                {
                    DT.Ispit[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Korisnik.Count; i++)
            {
                if (DT.Korisnik[i].promjena == true)
                {
                    DT.Korisnik[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Korisnik_dogadjaj.Count; i++)
            {
                if (DT.Korisnik_dogadjaj[i].promjena == true)
                {
                    DT.Korisnik_dogadjaj[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Korisnik_grupa.Count; i++)
            {
                if (DT.Korisnik_grupa[i].promjena == true)
                {
                    DT.Korisnik_grupa[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Korisnik_ispit.Count; i++)
            {
                if (DT.Korisnik_ispit[i].promjena == true)
                {
                    DT.Korisnik_ispit[i].Spremi();
                }
            }
            for (int i = 0; i < DT.KorisnikTip.Count; i++)
            {
                if (DT.KorisnikTip[i].promjena == true)
                {
                    DT.KorisnikTip[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Materijal.Count; i++)
            {
                if (DT.Materijal[i].promjena == true)
                {
                    DT.Materijal[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Odgovor.Count; i++)
            {
                if (DT.Odgovor[i].promjena == true)
                {
                    DT.Odgovor[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Odgovor_ispit.Count; i++)
            {
                if (DT.Odgovor_ispit[i].promjena == true)
                {
                    DT.Odgovor_ispit[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Pitanja.Count; i++)
            {
                if (DT.Pitanja[i].promjena == true)
                {
                    DT.Pitanja[i].Spremi();
                }
            }
            for (int i = 0; i < DT.Predmet.Count; i++)
            {
                if (DT.Predmet[i].promjena == true)
                {
                    DT.Predmet[i].Spremi();
                }
            }
            
            return true;
        }
    }
}
