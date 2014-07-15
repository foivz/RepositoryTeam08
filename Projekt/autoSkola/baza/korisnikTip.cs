using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class korisnikTip
    {
        public int ID_korisnikTip;
        public string naziv;
        public bool promjena;
        public korisnikTip(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnikTip = int.Parse(dr["ID_korisnikTip"].ToString());
                naziv = dr["naziv"].ToString();
                promjena = false;
            }
        }
        public korisnikTip() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_korisnikTip == 0 || ID_korisnikTip==null)
            {
                sqlUpit = "INSERT INTO korisnikTip (ID_korisnikTip,naziv) VALUES (dbo.default_korisnikTip(), '" + naziv + "')";
            }
            else
            {
                sqlUpit = "UPDATE korisnikTip SET "
                + ", naziv='" + naziv
                + "' WHERE ID_korisnikTip=" + ID_korisnikTip;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
