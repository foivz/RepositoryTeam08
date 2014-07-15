using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class ispit
    {
        public int ID_ispit;
        public int ID_grupa;
        public string datum;
        public string napomena;
        public string trajanje;
        public bool promjena;
        public ispit(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_ispit = int.Parse(dr["ID_ispit"].ToString());
                ID_grupa = int.Parse(dr["ID_grupa"].ToString());
                datum = dr["datum"].ToString();
                napomena = dr["napomena"].ToString();
                trajanje = dr["trajanje"].ToString();
                promjena = false;
            }

        }
        public ispit() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_ispit == 0 || ID_ispit==null)
            {
                sqlUpit = "INSERT INTO ispit (ID_ispit,ID_grupa,datum,napomena,trajanje) VALUES (dbo.default_ispit(), " + ID_grupa + ",'" + datum + "','" + napomena + "','" + trajanje + "')";
            }
            else
            {
                sqlUpit = "UPDATE ispit SET ID_grupa = " + ID_grupa
                + ", datum = '" + datum
                + "', napomena='" + napomena
                + "', trajanje='" + trajanje
                + "' WHERE ID_ispit=" + ID_ispit;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
