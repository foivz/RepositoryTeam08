using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class materijal
    {
        public int ID_materijal;
        public int ID_cjelina;
        public string opis;
        public string srcMaterijal;
        public bool promjena;
        public materijal(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_materijal = int.Parse(dr["ID_materijal"].ToString());
                ID_cjelina = int.Parse(dr["ID_cjelina"].ToString());
                opis = dr["opis"].ToString();
                srcMaterijal = dr["srcMaterijal"].ToString();
                promjena = false;
            }

        }
        public materijal() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_materijal == 0 || ID_materijal==null)
            {
                sqlUpit = "INSERT INTO materijal (ID_materijal,ID_cjelina,opis,srcMaterijal) VALUES (dbo.default_materijal(), " + ID_cjelina + ",'" + opis + "','" + srcMaterijal + "')";
            }
            else
            {
                sqlUpit = "UPDATE materijal SET ID_cjelina = " + ID_cjelina
                + ", opis = '" + opis
                + "', scrMaterijal='" + srcMaterijal
                + "' WHERE ID_materijal=" + ID_materijal;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
