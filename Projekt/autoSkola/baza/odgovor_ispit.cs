using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class odgovor_ispit
    {
        public int ID_korisnik_ispit;
        public int ID_odgovor;
        public int ID_pitanja;
        public bool promjena;
        public odgovor_ispit(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnik_ispit = int.Parse(dr["ID_korisnik_ispit"].ToString());
                ID_odgovor = int.Parse(dr["ID_odgovor"].ToString()); ;
                ID_pitanja = int.Parse(dr["ID_pitanja"].ToString());
                promjena = false;
            }
        }

        public odgovor_ispit() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (promjena==false)
            {
                sqlUpit = "INSERT INTO odgovor_ispit (ID_odgovor_ispit, ID_odgovor,ID_pitanja) VALUES ("+ ID_korisnik_ispit +", " + ID_odgovor + "ID_pitanja"+")";
            }
            else
            {
                sqlUpit = "UPDATE odgovor_ispit SET ID_odgovor=" + ID_odgovor + ", ID_pitanja=" + ID_pitanja + " WHERE ID_odgovor_ispit=" + ID_korisnik_ispit;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
