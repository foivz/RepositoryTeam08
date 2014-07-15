using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class grupa
    {
        public int ID_grupa { get; set; }
        public int ID_cjelina { get; set; }
        public int predavac { get; set; }
        public bool promjena { get; set; }
        public grupa(DbDataReader dr)
        {
            if (dr != null)
            {
                //Orig:

                ID_grupa =  int.Parse(dr["ID_grupa"].ToString());
                ID_cjelina = int.Parse(dr["ID_cjelina"].ToString());
                predavac = int.Parse(dr["predavac"].ToString()); 

                //int tempGrupa= 0, tempCjelina=0, tempPredavac=0;

                //int.TryParse(dr["ID_grupa"].ToString(), out tempGrupa);
                //int.TryParse(dr["ID_cjelina"].ToString(), out tempCjelina);
                //int.TryParse(dr["predavac"].ToString(), out tempPredavac);

                //ID_grupa = tempGrupa;
                //ID_cjelina = tempCjelina;
                //predavac = tempPredavac;



                promjena = false;
            }

        }
        public grupa() { }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_grupa == 0 || ID_grupa==null)
            {
                sqlUpit = "INSERT INTO grupa (ID_grupa,ID_cjelina,predavac) VALUES (dbo.default_grupa(), " + ID_cjelina + "," + predavac + ")";
            }
            else
            {
                sqlUpit = "UPDATE grupa SET ID_cjelina = " + ID_cjelina
                + ", predavac = " + predavac
                + " WHERE ID_grupa=" + ID_grupa;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
