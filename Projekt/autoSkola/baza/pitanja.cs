using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class pitanja
    {
        public int ID_pitanja;
        public int ID_cjelina;
        public string tekst;
        public string srcPitanja;
        public bool promjena;
        public pitanja(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_pitanja = int.Parse(dr["ID_pitanja"].ToString());
                ID_cjelina = int.Parse(dr["ID_cjelina"].ToString());
                tekst = dr["tekst"].ToString();
                srcPitanja = dr["srcPitanja"].ToString();
                promjena = false;
            }
        }
        public pitanja() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_pitanja == 0 || ID_pitanja==null)
            {
                sqlUpit = "INSERT INTO pitanja (ID_pitanja, ID_cjelina,tekst,srcPitanja) VALUES (dbo.default_pitanja(), " + ID_cjelina + ",'" + tekst + "','" + srcPitanja + "')";
            }
            else
            {
                sqlUpit = "UPDATE pitanja SET ID_cjelina = " + ID_cjelina
                + ", tekst = '" + tekst
                + "', srcPitanja = '" + srcPitanja
                + " WHERE ID_pitanja = " + ID_pitanja;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
