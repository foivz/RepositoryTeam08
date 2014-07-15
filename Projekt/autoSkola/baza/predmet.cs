using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class predmet
    {
        public int ID_predmet;
        public string naziv;
        public string opis;
        public bool promjena;
        public predmet(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_predmet = int.Parse(dr["ID_predmet"].ToString());
                naziv = dr["naziv"].ToString();
                opis = dr["opis"].ToString();
                promjena = false;
            }
        }
        public predmet() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_predmet == 0 || ID_predmet==null)
            {
                sqlUpit = "INSERT INTO predmet (ID_predmet, naziv,opis) VALUES (dbo.default_predmet(), " + ID_predmet + "," + naziv + "','" + opis + "')";
            }
            else
            {
                sqlUpit = "UPDATE predmet SET naziv = '" + naziv
                + "', opis = '" + opis
                + "' WHERE Id = " + ID_predmet;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
