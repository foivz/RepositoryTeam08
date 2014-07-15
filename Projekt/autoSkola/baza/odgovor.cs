using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class odgovor
    {
        public int ID_odgovor;
        public int ID_pitanja;
        public string tekst;
        public string srcOdgovor;
        public float bodovi;
        public bool promjena;
        public odgovor(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_odgovor = int.Parse(dr["ID_odgovor"].ToString());
                ID_pitanja = int.Parse(dr["ID_pitanja"].ToString());
                tekst = dr["tekst"].ToString();
                srcOdgovor = dr["srcOdgovor"].ToString();
                bodovi = float.Parse(dr["bodovi"].ToString());
                promjena = false;
            }
        }
        public odgovor() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_odgovor == 0 || ID_odgovor==null)
            {
                sqlUpit = "INSERT INTO odgovor (ID_odgovor,ID_pitanja,tekst,bodovi,srcOdgovor) VALUES (dbo.default_odgovor(), " + ID_pitanja + ",'" + tekst + "'," + bodovi + ",'" + srcOdgovor + "')";
            }
            else
            {
                sqlUpit = "UPDATE odgovor SET ID_pitanja = " + ID_pitanja
                + ", tekst = '" + tekst
                + "', bodovi = " + bodovi
                + ", scrOdgovor='" + srcOdgovor
                + "' WHERE ID_odgovor=" + ID_odgovor;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }

    }
}
