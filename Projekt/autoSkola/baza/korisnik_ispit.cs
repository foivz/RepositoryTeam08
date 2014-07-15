using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class korisnik_ispit
    {
        public int ID_korisnik_ispit;
        public int ID_korisnik;
        public int ID_ispit;
        public bool promjena;
        public korisnik_ispit(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnik_ispit = int.Parse(dr["ID_korisnik_ispit"].ToString());
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
                ID_ispit = int.Parse(dr["ID_ispit"].ToString());
                promjena = false;
            }
        }

        public korisnik_ispit() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_korisnik_ispit == 0 || ID_korisnik_ispit==null)
            {
                sqlUpit = "INSERT INTO korisnik_ispit (ID_korisnik_ispit,ID_korisnik,ID_ispit) VALUES (dbo.default_korisnik_ispit(), " + ID_korisnik + "," + ID_ispit + ")";
            }
            else
            {
                sqlUpit = "UPDATE korisnik_ispit SET ID_korisnik = " + ID_korisnik
                + ", ID_ispit=" + ID_ispit
                + " WHERE ID_korisnik_ispit=" + ID_korisnik_ispit;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
