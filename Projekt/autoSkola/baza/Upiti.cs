using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace autoSkola
{
    class Upiti
    {
        string sql;

        #region Korisnik
        /// <summary>
        /// Dohvaca popis svih korisnika u datareader
        /// </summary>
        /// <returns></returns>
        public DbDataReader DohvatiSveKorisnike()
        {
            sql = "SELECT * FROM korisnik";
            return baza.Instanca.DohvatiDataReader(sql);
        }

        /// <summary>
        /// Upit koji obrise korisnika prema zadanom ID-u, prvo treba obrisati kaskadne tablice
        /// </summary>
        /// <param name="id">ID korisnika koji je odabran za brisanje</param>
        public void ObrisiKorisnika(string id)
        {
            sql=string.Format("DELETE FROM Korisnik_grupa WHERE ID_korisnik={0}",id);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("DELETE FROM korisnik WHERE ID_korisnik={0}", id);
            baza.Instanca.IzvrsiUpit(sql);
        }

        /// <summary>
        /// Upit koji doda novog korisnika u bazu
        /// </summary>
        public void DodajKorisnika(string ime,string prezime, string username, string lozinka, string oib, string mail, string telefon, string id_korisnik_tip)
        {
            sql = string.Format("INSERT INTO korisnik"+
                "(ime,prezime,korisnicko_ime,lozinka,oib,mail,telefon,ID_korisnikTip)"+
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                ime, prezime, username, lozinka, oib, mail, telefon, id_korisnik_tip);
            baza.Instanca.IzvrsiUpit(sql);
        }

        /// <summary>
        /// Upit koji uredi postojećeg korisnika
        /// </summary>
        public void UrediKorisnika(string id,string ime, string prezime, string username, string lozinka, string oib, string mail, string telefon, string id_korisnik_tip)
        {
            sql = string.Format("SELECT korisnicko_ime,oib FROM korisnik WHERE ID_korisnik<>{0}", id);
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            bool jednaki_oib = false;
            bool jednaki_user = false;
            
           
            oib += " ";
            while (citac.Read())
            {
                string user = citac[0].ToString();
                user += " ";
                if (user == username)
                {
                    jednaki_user = true;
                }
                else if (citac[1].ToString() == oib)
                {
                    jednaki_oib = true;
                }
            }
            citac.Close();
            citac.Dispose();
            if (jednaki_oib == true)
            {
                MessageBox.Show("Duplikat OIB-a");
            }
            else if (jednaki_user == true)
            {
                MessageBox.Show("Duplikat korisničkog imena ili razmak u korisničkom imenu");
            }
            else
            {
                sql = string.Format("UPDATE korisnik" +
               " SET ime='{0}',prezime='{1}',korisnicko_ime='{2}',lozinka='{3}',oib='{4}',mail='{5}',telefon='{6}',ID_korisnikTip='{7}' WHERE" +
               " ID_korisnik={8}",
               ime, prezime, username, lozinka, oib, mail, telefon, id_korisnik_tip, id);
                //MessageBox.Show(sql);
                MessageBox.Show("Uspješno ažuriran korisnik!");
                baza.Instanca.IzvrsiUpit(sql);
            }
        }

        public string DohvatiImePrezimeKorisnika(string id)
        {
            sql = string.Format("SELECT ime,prezime FROM korisnik WHERE ID_korisnik='{0}'", id);
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            string ime_prezime = "";
            while (citac.Read())
            {
                ime_prezime += citac[0].ToString() + " " + citac[1].ToString();
            }
            citac.Close();
            citac.Dispose();
            return ime_prezime;
        }

        public string DodajGrupu(string id, string kategorija,string odradeno)
        {
            sql=string.Format("SELECT ID_predmet FROM predmet WHERE naziv='{0}'",kategorija);
            DbDataReader citac=baza.Instanca.DohvatiDataReader(sql);
            string id_predmet="";
            while(citac.Read()){
                id_predmet=citac[0].ToString();
            }
            citac.Close();
            citac.Dispose();
            sql = string.Format("INSERT INTO grupa (id_predmet,ID_korisnik,odradeno) VALUES('{0}','{1}','{2}')", id_predmet, id, odradeno);
            baza.Instanca.IzvrsiUpit(sql);
            sql="SELECT MAX(ID_grupa) FROM grupa";
            citac = baza.Instanca.DohvatiDataReader(sql);
            string zadnji_id = "";
            while (citac.Read())
            {
                zadnji_id = citac[0].ToString();
            }
            citac.Close();
            citac.Dispose();
            return zadnji_id;
        }
        #endregion

        #region Grupa

        public string DohvatiBrojUcenikaUgrupama(string id, string naziv)
        {
            sql = string.Format("SELECT COUNT(*) FROM grupa,korisnik_grupa,predmet WHERE naziv='{0}' AND korisnik_grupa.ID_grupa="+
            "grupa.ID_grupa AND grupa.ID_korisnik='{1}' AND predmet.ID_predmet=grupa.id_predmet AND odradeno=0", naziv, id);
            DbDataReader citac= baza.Instanca.DohvatiDataReader(sql);
            string broj_korisnika_na_grupi = "";
            while (citac.Read())
            {
                broj_korisnika_na_grupi = citac[0].ToString();
            }
            citac.Close();
            citac.Dispose();
            return broj_korisnika_na_grupi;
        }

        public string DohvatiBrojGrupa(string id, string naziv)
        {
            sql = string.Format("SELECT COUNT(*) FROM grupa,predmet WHERE naziv='{0}' AND ID_korisnik='{1}' "+
                "AND predmet.ID_predmet=grupa.id_predmet AND odradeno=0", naziv, id);
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            string broj_grupa = "";
            while (citac.Read())
            {
                broj_grupa = citac[0].ToString();
            }
            citac.Close();
            citac.Dispose();
            return broj_grupa;
        }

        public DbDataReader DohvatiGrupeKorisnika(string id, string naziv)
        {
            /* original
            sql = string.Format("SELECT grupa.ID_grupa, grupa.odradeno FROM grupa,predmet WHERE naziv='{0}' AND ID_korisnik='{1}' " +
               "AND predmet.ID_predmet=grupa.id_predmet ORDER BY odradeno", naziv, id);
             */

            sql = string.Format("SELECT grupa.ID_grupa, grupa.odradeno FROM grupa, Kategorije, Kat_grupe WHERE " +
                "grupa.ID_grupa = Kat_grupe.ID_grupa AND Kat_grupe.ID_kategorija = Kategorije.ID AND Kategorije.Kategorija = '" + naziv + "' AND "+
                "grupa.predavac = " + id + " ORDER BY odradeno");
            return baza.Instanca.DohvatiDataReader(sql);

        }

        public DbDataReader DohvatiKorisnikeNaGrupi(string id, string naziv,string id_grupa)
        {
            /*
             Original
              sql = string.Format("SELECT korisnik.ID_korisnik,korisnik.ime,korisnik.prezime,korisnik.oib"
                    +" FROM grupa,korisnik_grupa,predmet,korisnik WHERE naziv='{0}' AND grupa.ID_grupa='{2}' AND korisnik_grupa.ID_grupa=" +
                    "grupa.ID_grupa AND grupa.ID_korisnik='{1}' AND predmet.ID_predmet=grupa.id_predmet AND korisnik.ID_korisnik=korisnik_grupa.ID_korisnik",
                    naziv, id,id_grupa);
             */

            sql = "SELECT korisnik.ID_korisnik, korisnik.ime, korisnik.prezime, korisnik.oib "+
                    "FROM grupa, korisnik_grupa, predmet, korisnik, Kategorije, Kat_grupe  "+
                            "WHERE Kat_grupe.ID_grupa = grupa.ID_grupa "+
	                        "AND Kat_grupe.ID_kategorija = Kategorije.ID "+
	                        "AND Kategorije.Kategorija = '"+naziv+"' "+
	                        "AND grupa.ID_grupa='"+id_grupa+ "' "+ 
	                        "AND korisnik_grupa.ID_grupa=grupa.ID_grupa "+
                            "AND grupa.predavac='" + id + "' " + 
	                        "AND predmet.ID_predmet=grupa.id_predmet "+
	                        "AND korisnik.ID_korisnik=korisnik_grupa.ID_korisnik ";

            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void ObrisiGrupu(string id_grupa)
        {
            sql = string.Format("DELETE FROM korisnik_grupa where ID_grupa='{0}'", id_grupa);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("DELETE FROM grupa WHERE ID_grupa='{0}'", id_grupa) ;
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void DodajKorisnikaUGrupu(string id_grupa, string id_korisnik)
        {
            sql=string.Format("INSERT INTO korisnik_grupa VALUES('{0}','{1}')",id_grupa,id_korisnik);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void BrisiKorisnikaIzGrupe(string id_korisnik,string id_grupa)
        {
            sql=string.Format("DELETE FROM korisnik_grupa WHERE ID_grupa='{0}' AND ID_korisnik='{1}'",id_grupa,id_korisnik);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public bool provjeriDuplikatUcenikaUgrupi(string id_korisnik, string id_grupa)
        {
            sql = string.Format("SELECT* FROM korisnik_grupa WHERE ID_grupa='{0}' AND ID_korisnik='{1}'", id_grupa, id_korisnik);
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            bool pronadjeno = false;
            if (citac.HasRows)
            {
                pronadjeno = true;
            }
            citac.Close();
            citac.Dispose();
            return pronadjeno;
        }

        #endregion

        #region Dogadaj

        public DbDataReader DohvatiDogadajeKorisnika(string id, string kategorija)
        {
            sql =
                string.Format(
                    "SELECT dogadjaj.datum,dogadjaj.napomena,korisnik_dogadjaj.dolazak FROM dogadjaj,korisnik_dogadjaj,grupa,predmet WHERE " +
                    "grupa.id_predmet=predmet.ID_predmet AND dogadjaj.ID_grupa=grupa.ID_grupa AND korisnik_dogadjaj.ID_dogadjaj=dogadjaj.ID_dogadjaj " +
                    "AND korisnik_dogadjaj.ID_korisnik='{0}' AND predmet.naziv='{1}' AND dogadjaj.datum>GETDATE()", id, kategorija);
            return baza.Instanca.DohvatiDataReader(sql);
        }
        public DbDataReader DohvatiSveDogadajeKorisnika(string id, string kategorija)
        {
            sql =
                string.Format(
                    "SELECT dogadjaj.datum,dogadjaj.napomena,korisnik_dogadjaj.dolazak FROM dogadjaj,korisnik_dogadjaj,grupa,predmet WHERE " +
                    "grupa.id_predmet=predmet.ID_predmet AND dogadjaj.ID_grupa=grupa.ID_grupa AND korisnik_dogadjaj.ID_dogadjaj=dogadjaj.ID_dogadjaj " +
                    "AND korisnik_dogadjaj.ID_korisnik='{0}' AND predmet.naziv='{1}' ", id, kategorija);
            return baza.Instanca.DohvatiDataReader(sql);
        }
        public DbDataReader DohvatiSveIspiteKorisnika(string id, string kategorija)
        {
            sql =
                string.Format(
                    "SELECT ispit.datum, ispit.napomena FROM ispit,korisnik_grupa, grupa,predmet,korisnik_ispit WHERE grupa.id_predmet=predmet.ID_predmet" +
                    " AND ispit.ID_grupa=grupa.ID_grupa AND korisnik_grupa.ID_grupa=grupa.ID_grupa AND korisnik_grupa.ID_korisnik={0}" +
                    " AND predmet.naziv='{1}'  AND korisnik_ispit.ID_ispit=ispit.ID_ispit", id, kategorija);
            return baza.Instanca.DohvatiDataReader(sql);
        }
        public DbDataReader DohvatiIspiteKorisnika(string id, string kategorija)
        {
            sql =
                string.Format(
                    "SELECT ispit.datum, ispit.napomena FROM ispit,korisnik_grupa, grupa,predmet,korisnik_ispit WHERE grupa.id_predmet=predmet.ID_predmet" +
                    " AND ispit.ID_grupa=grupa.ID_grupa AND korisnik_grupa.ID_grupa=grupa.ID_grupa AND korisnik_grupa.ID_korisnik={0}" +
                    " AND predmet.naziv='{1}' AND ispit.datum>GETDATE() AND korisnik_ispit.ID_ispit=ispit.ID_ispit", id, kategorija);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public DbDataReader DohvatiSveDogadaje(string grupa, string id_korisnik)
        {
            sql = string.Format("SELECT ID_dogadjaj, napomena, datum FROM dogadjaj WHERE ID_grupa='{0}' AND kreirao='{1}'",
                grupa,id_korisnik);
            return baza.Instanca.DohvatiDataReader(sql);        
        }

        public void ObrisiDogadaj(string id_dogadjaj)
        {
            sql=string.Format("DELETE FROM korisnik_dogadjaj WHERE ID_dogadjaj='{0}'",id_dogadjaj);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("DELETE FROM dogadjaj WHERE ID_dogadjaj='{0}'", id_dogadjaj);
        }

        public void DodajDogadaj(string id_grupe,string id_korisnik,string napomena, string datum)
        {
            DateTime dt = Convert.ToDateTime(datum);
            datum = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt);
            sql=string.Format("INSERT INTO dogadjaj(kreirao, napomena, datum, ID_grupa) VALUES('{0}','{1}','{2}','{3}')",
                id_korisnik,napomena,datum,id_grupe);
            baza.Instanca.IzvrsiUpit(sql);
            string id_dogadjaj="";
            sql = string.Format("SELECT ID_korisnik FROM korisnik_grupa WHERE ID_grupa='{0}'", id_grupe);
            List<string> id_jevi = new List<string>();
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            while (citac.Read())
            {
                id_jevi.Add(citac[0].ToString());
            }
            citac.Close();
            citac.Dispose();
            sql="SELECT MAX(ID_dogadjaj) FROM dogadjaj";
            citac=baza.Instanca.DohvatiDataReader(sql);
            while(citac.Read()){
                id_dogadjaj = citac[0].ToString();
            }
            citac.Close();
            citac.Dispose();
            foreach (string id in id_jevi)
            {
                sql = string.Format("INSERT INTO korisnik_dogadjaj VALUES('{0}','{1}','{2}')",id_dogadjaj,id,0);
                baza.Instanca.IzvrsiUpit(sql);
            }
        }

        public void DogadajUredi(string id_dogadaj,string napomena,string datum)
        {
            DateTime dt = Convert.ToDateTime(datum);
            datum = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt);
            sql=string.Format("UPDATE dogadjaj SET napomena='{0}',datum='{1}' WHERE ID_dogadjaj='{2}'",napomena,datum,id_dogadaj);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public DbDataReader DohvatiKorisnikeNaDogadaju(string id_dogadaj)
        {
            sql =string.Format("SELECT korisnik_dogadjaj.ID_korisnik,korisnik.ime, korisnik.prezime, korisnik.oib, korisnik_dogadjaj.dolazak FROM korisnik_dogadjaj, korisnik, dogadjaj"
                + " WHERE korisnik_dogadjaj.ID_korisnik=korisnik.ID_korisnik AND dogadjaj.ID_dogadjaj='{0}'",id_dogadaj);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void UrediKorisnikaNaDogadaju(string id_korisnik, string id_dogadaj,string dolazak)
        {
            sql = string.Format("UPDATE korisnik_dogadjaj SET dolazak='{0}' WHERE ID_dogadjaj='{1}' AND ID_korisnik='{2}'",dolazak,id_dogadaj,id_korisnik);
            baza.Instanca.IzvrsiUpit(sql);
        }

        #endregion

        #region Kalendar

        public DbDataReader DohvatiDogadjaje(string id)
        {
            sql = string.Format("SELECT ID_dogadjaj,napomena,datum, ID_grupa FROM dogadjaj WHERE kreirao='{0}' AND datum>GETDATE()", id);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public DbDataReader DohvatiRokove(string id)
        {
            sql = string.Format("SELECT ID_ispit,ispit.ID_grupa, ispit.datum, ispit.napomena FROM ispit,grupa WHERE ID_korisnik='{0}' " +
                                " AND ispit.ID_grupa=grupa.ID_grupa AND datum>GETDATE()", id);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public DbDataReader DohvatiDogadjajePremaDatumu(string datum,string id)
        {
            DateTime dt = Convert.ToDateTime(datum);
            datum = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt);
            sql = string.Format("SELECT * FROM dogadjaj WHERE kreirao='{0}' AND datum='{1}'", id, datum);
            return baza.Instanca.DohvatiDataReader(sql);    
        }

        public DbDataReader DohvatiRokovePremaDatumu(string datum, string id)
        {
            DateTime dt = Convert.ToDateTime(datum);
            datum = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt);
            sql = string.Format("SELECT*FROM ispit,grupa WHERE ID_korisnik='{0}' AND datum='{1}' AND ispit.ID_grupa=grupa.ID_grupa " +
                                "  ", id, datum);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        #endregion

        #region Cjelina

        public DbDataReader DohvatiCjelinePredmeta(string kategorija)
        {
            /*
             Original:
             * sql=string.Format("SELECT cjelina.ID_cjelina, cjelina.naziv, cjelina.opis FROM cjelina,predmet WHERE predmet.naziv='{0}' AND cjelina.ID_predmet=predmet.ID_predmet",kategorija);
            
            
             */

            sql = string.Format("SELECT DISTINCT cjelina.ID_cjelina, cjelina.naziv, cjelina.opis " +
                                           "FROM cjelina,predmet,grupa, Kat_grupe, Kategorije " +
                                           "WHERE Kategorije.Kategorija = '" + kategorija + "' " +
                                           "AND Kategorije.ID = Kat_grupe.ID_kategorija " +
                                           "AND Kat_grupe.ID_grupa = grupa.ID_grupa " +
                                           "AND grupa.ID_cjelina = cjelina.ID_cjelina ");

            
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void ObrisiCjelinu(string id)
        {
            sql = string.Format("DELETE FROM odgovor WHERE odgovor.ID_pitanja=(SELECT pitanja.ID_pitanja FROM pitanja WHERE pitanja.ID_cjelina={0})", id);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("DELETE FROM pitanja WHERE ID_cjelina={0}",id);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("DELETE FROM cjelina WHERE ID_cjelina={0}",id);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void AzurirajCjelinu(string id, string naziv, string opis)
        {
            sql = string.Format("UPDATE cjelina SET naziv='{0}', opis='{1}' WHERE ID_cjelina='{2}'", naziv, opis, id);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void DodajCjelinu(string naziv, string opis,string kategorija)
        {
            /*
             * Original
             
              sql = string.Format("INSERT INTO cjelina(naziv,opis,ID_predmet) VALUES('{0}','{1}',(SELECT ID_predmet FROM predmet WHERE " +
                                "predmet.naziv='{2}'))", naziv, opis,kategorija);
              baza.Instanca.IzvrsiUpit(sql);
             
             
             
             */

            sql = string.Format("SELECT grupa.ID_predmet " +
                                "FROM Predmet, Kategorije, Kat_grupe, grupa  " +
                                "WHERE Kategorije.Kategorija='" + kategorija + "' " +
                                "AND Kategorije.ID = Kat_grupe.ID_kategorija " +
                                " AND grupa.ID_grupa = Kat_grupe.ID_grupa " +
                                " AND grupa.id_predmet = Predmet.ID_predmet ");

            //Imamo data reader, on bude imao sve rezultate
            DbDataReader dr = baza.Instanca.DohvatiDataReader(sql);
            List<int> lista = new List<int>();

            //u kolko unosa treba dodati novu cjelinu
            while ( dr.Read() )
            {
                lista.Add((int)dr[0]);
            }

            dr.Close();
            dr.Dispose();

            //Dodaj u cjelinu novi unos, koji sadrži referencu na predmet
            //zapamtiti nove ID-eve da bi se mogle i Grupe updejtati
            List<int> zadnjiID = new List<int>();
            for ( int i = 0; i < lista.Count; i++ )
            {
                string sql2 = "INSERT INTO cjelina(naziv,opis,ID_predmet, bodovi) " +
                              "VALUES('"+naziv+"','"+opis+"', " + lista[i] + ", 0)";

                baza.Instanca.IzvrsiUpit(sql2);

                string sqlgetID = "SELECT ID_cjelina FROM cjelina";
                DbDataReader drTemp = baza.Instanca.DohvatiDataReader(sqlgetID);

                List<int> tempList = new List<int>();
                while ( drTemp.Read() )
                {
                    tempList.Add(drTemp.GetInt32(0));
                }

                zadnjiID.Add(tempList[tempList.Count-1]);

                drTemp.Close();
                drTemp.Dispose();
            }

            List<int> listaZadnjeGrupe = new List<int>();
            for ( int i = 0; i < zadnjiID.Count; i++ )
            {

                string SQL = "INSERT INTO grupa (ID_cjelina, predavac, id_predmet) " +
                             "VALUES ('" + zadnjiID[i] + "', 2, " + lista[i] + ")";

                baza.Instanca.IzvrsiUpit(SQL);

                DbDataReader dbReadGrupe = baza.Instanca.DohvatiDataReader("SELECT ID_grupa from grupa");
                List<int> tempListGrupe = new List<int>();

                while ( dbReadGrupe.Read() )
                {
                    tempListGrupe.Add((int)dbReadGrupe[0]);   
                }
                dbReadGrupe.Close();
                dbReadGrupe.Dispose();

                listaZadnjeGrupe.Add(tempListGrupe[tempListGrupe.Count - 1]);
            }

            //Kat_grupa ažurirat, da nove dodane grupe vrijede za trenutnu kategoriju)

            string dajKatID = "SELECT ID FROM Kategorije where Kategorije.Kategorija = '" + kategorija+"'";
            DbDataReader readerID = baza.Instanca.DohvatiDataReader(dajKatID);

            readerID.Read();
            int ID = (int)readerID[0];

            readerID.Close();
            readerID.Dispose();

            for (int i = 0; i < listaZadnjeGrupe.Count; i++)
			{
                string finalInsert = "INSERT INTO Kat_grupe VALUES (" + ID + ", " + listaZadnjeGrupe[i] + ")";
                baza.Instanca.IzvrsiUpit(finalInsert);
			}
            

           //Phew. Znači ažurirali smo Cjelinu, Grupe, i Kat_grupe, s obzirom na Predmete koji pripadaju
           //toj grupi i cjelini s obzirom na Kategoriju vozila.
        }

        #endregion

        #region Pitanje

        public void ObrisiPitanje(string id)
        {
            sql = string.Format("DELETE FROM odgovor WHERE ID_pitanja={0}",id);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("DELETE FROM pitanja WHERE ID_pitanja={0}", id);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public DbDataReader DohvatiSliku(string id)
        {
            sql = string.Format("SELECT slika FROM pitanja WHERE ID_pitanja={0}", id);
            return baza.Instanca.DohvatiDataReader(sql);
        }
        public DbDataReader DohvatiPitanja(string cjelina)
        {
            sql=string.Format("SELECT ID_pitanja,tekst,  bodovi FROM pitanja WHERE ID_cjelina={0}",cjelina);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void DodajPitanjeBezSlike( string id_cjelina, string pitanje,string bodovi)
        {
            sql = string.Format("INSERT INTO pitanja(ID_cjelina,tekst,bodovi) VALUES('{0}','{1}',{2}", id_cjelina,
                                pitanje, bodovi);
            baza.Instanca.IzvrsiUpit(sql);
        }
        public void DodajPitanjeSaSlikom(string putanja,string id_cjelina, string pitanje, string bodovi)
        {
            Image myImage = Image.FromFile(putanja);
            byte[] data;
            using (MemoryStream ms = new MemoryStream())
            {
                myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                data = ms.ToArray();
            }
           // MessageBox.Show(data.Length.ToString());
            SqlConnection con = new SqlConnection("server=SQL5004.Smarterasp.net;database=DB_9AA9DB_bgrgicak;uid=DB_9AA9DB_bgrgicak_admin;pwd=flatron1;");
            con.Open();
            sql = "INSERT INTO pitanja(ID_cjelina,tekst,slika,bodovi) VALUES(" + id_cjelina + ",'" + pitanje + "',@SL," +
                  bodovi + ")";

            SqlCommand komanda=new SqlCommand(sql,con);
            komanda.Parameters.AddWithValue("@SL",data);
            komanda.ExecuteNonQuery();
         //   komanda.ExecuteNonQuery();
            con.Close();
            sql = string.Format("INSERT INTO pitanja(ID_cjelina,tekst,slika,bodovi) VALUES("+id_cjelina+",'{0}',{1},"+bodovi+")",
                                pitanje, data);
           //   baza.Instanca.IzvrsiUpit(sql);
        }
        #endregion

        #region Odgovori

        public DbDataReader DohvatiOdgovore(string id_predmet)
        {
            sql = string.Format("SELECT*FROM odgovor WHERE ID_pitanja='{0}'", id_predmet);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void DodajOdgovor(string id_pitanja, string tekst,string tocno_netocno)
        {
                sql=string.Format("INSERT INTO odgovor(ID_pitanja,tekst,tocno_netocno) VALUES('{0}','{1}',{2})",id_pitanja,tekst,tocno_netocno);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void UrediOdgovor(string id_odgovora, string tekst,string tocno_netocno)
        {
            sql = string.Format("UPDATE odgovor SET tekst='{0}', tocno_netocno={1} WHERE ID_odgovor={2}",tekst,tocno_netocno,id_odgovora);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void ObrisiOdgovor(string id_odgovora)
        {
            sql = string.Format("DELETE FROM odgovor WHERE ID_odgovor={0}", id_odgovora);
            baza.Instanca.IzvrsiUpit(sql);
        }
        #endregion

        #region Predmeti

        public DbDataReader DohvatiPredmete()
        {
            sql = "SELECT naziv FROM predmet";
            return baza.Instanca.DohvatiDataReader(sql);
        }
        #endregion

        #region Ispit

        public int ProvjeriIspit(string id_korisnik)
        {
            sql = string.Format("SELECT otvoren_zatvoren,ispit.ID_ispit FROM ispit, korisnik_ispit WHERE korisnik_ispit.ID_ispit=ispit.ID_ispit AND korisnik_ispit.ID_korisnik" +
                  "={0}",id_korisnik);
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            int poceo = 0;
            while (citac.Read())
            {
                string test = citac[0].ToString();
                if (citac[0].ToString() == "True")
                {

                }
                else
                {
                    poceo = int.Parse(citac[1].ToString());
                }
            }
            citac.Close();
            citac.Dispose();
            return poceo;
        }
        public DbDataReader dohvatiRokZaGrupu(string id_grupa)
        {
            sql = string.Format("SELECT *FROM ispit WHERE ID_grupa={0}", id_grupa);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void ObrisiRok(string id_rok)
        {
            sql = string.Format("DELETE FROM korisnik_ispit WHERE ID_ispit={0}", id_rok);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("DELETE FROM ispit WHERE ID_ispit={0}", id_rok);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void UrediRok(string id_rok,string datum,string napomena)
        {
             DateTime dt = Convert.ToDateTime(datum);
            datum = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt);
            sql=string.Format("UPDATE ispit SET datum='{0}', napomena='{1}' WHERE ID_ispit={2}",datum,napomena,id_rok);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void DodajRok(string datum,string napomena,string id_grupa)
        {
            DateTime dt = Convert.ToDateTime(datum);
            datum = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt);
            sql =
                string.Format(
                    "INSERT INTO ispit (ID_grupa, datum, napomena, otvoren_zatvoren) VALUES ({0},'{1}','{2}',0)",
                    id_grupa, datum, napomena);
            baza.Instanca.IzvrsiUpit(sql);
            //unijeti u korisnik_dogadjaj

            sql = string.Format( "SELECT korisnik_grupa.ID_korisnik FROM korisnik_grupa WHERE korisnik_grupa.ID_grupa={0} ",id_grupa);
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            List<string> idjevi=new List<string>();
            while (citac.Read())
            {
                idjevi.Add(citac[0].ToString());
            }

            citac.Close();
            citac.Dispose();
            sql = "SELECT MAX(ID_ispit) FROM ispit";
            string id_ispit = "";
            citac = baza.Instanca.DohvatiDataReader(sql);
            while (citac.Read())
            {
                id_ispit = citac[0].ToString();
            }
            citac.Close();
            citac.Dispose();
            foreach (string s in idjevi)
            {
                sql = string.Format("INSERT INTO korisnik_ispit(ID_korisnik,ID_ispit) VALUES ({0},{1})", s,id_ispit);
                baza.Instanca.IzvrsiUpit(sql);
            }
        }

        public DbDataReader DohvatiSvaPitanja(string id_grupa)
        {
            sql = string.Format("SELECT pitanja.ID_pitanja,pitanja.tekst,pitanja.bodovi FROM pitanja,cjelina WHERE " +
                                "cjelina.ID_predmet=(SELECT id_predmet FROM grupa WHERE ID_grupa={0})AND pitanja.ID_cjelina=cjelina.ID_cjelina ",id_grupa);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public DbDataReader DohvatiPitanjaIspita(string id_ispit)
        {
            sql=string.Format("SELECT pitanja.ID_pitanja,pitanja.tekst,pitanja.bodovi FROM pitanja, pitanja_ispit WHERE pitanja_ispit.ID_ispit={0} AND pitanja_ispit.ID_pitanja=pitanja.ID_pitanja",id_ispit);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void DodajPitanjeUIspit(string id_pitanje,string id_ispit)
        {
            sql=string.Format("SELECT *FROM pitanja_ispit WHERE ID_pitanja={0} AND ID_ispit={1}",id_pitanje,id_ispit)
            ;
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            if (citac.HasRows)
            {
                MessageBox.Show("Ovo pitanje se već nalazi u listi pitanja");
                citac.Close();citac.Dispose();
            }
            else
            {
                citac.Close();
                citac.Dispose();
                sql = string.Format("INSERT INTO pitanja_ispit VALUES({0},{1})", id_ispit, id_pitanje);
                baza.Instanca.IzvrsiUpit(sql);
            }
        }

        public void ObrisiPitanjeIzIspita(string id_pitanje, string id_ispit)
        {
            sql = string.Format("DELETE FROM pitanja_ispit WHERE ID_pitanja={0} AND ID_ispit={1}",id_pitanje,id_ispit);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public void ZapocniRok(string id_ispit,List<string> pitanja )
        {
            sql = string.Format("UPDATE ispit SET otvoren_zatvoren=1 WHERE ID_ispit={0}", id_ispit);
            baza.Instanca.IzvrsiUpit(sql);
            sql = string.Format("SELECT ID_korisnik_ispit FROM korisnik_ispit WHERE ID_ispit={0}", id_ispit);
            DbDataReader citac = baza.Instanca.DohvatiDataReader(sql);
            List<string> lista_idjeva_korisnika = new List<string>();
            while (citac.Read())
            {
                lista_idjeva_korisnika.Add(citac[0].ToString());
            }
            citac.Close();citac.Dispose();
            foreach (string s in lista_idjeva_korisnika)
            {
                foreach (string k in pitanja)
                {
                    List<string> lista_odgovora=new List<string>();
                    sql = "SELECT ID_odgovor FROM odgovor WHERE ID_pitanja=" + k;
                    citac = baza.Instanca.DohvatiDataReader(sql);
                    Thread.Sleep(10);
                    while (citac.Read())
                    {
                        lista_odgovora.Add(citac[0].ToString());
                    }
                    citac.Close();
                    citac.Dispose();
                    foreach (string s1 in lista_odgovora)
                    {
                        sql = string.Format("INSERT INTO odgovor_ispit VALUES({0},{1},{2},0)", s,s1,k);
                        baza.Instanca.IzvrsiUpit(sql);
                    }
                   
                }
            }
        }

        public void zatvoriRok(string id_ispit)
        {
            sql = string.Format("UPDATE ispit SET otvoren_zatvoren=0, gotovo=1 WHERE ID_ispit={0}", id_ispit);
            baza.Instanca.IzvrsiUpit(sql);
        }

        public DbDataReader DohvatiPitanjaIspita(string id_korisnik,string id_ispit)
        {
            sql = string.Format("SELECT pitanja_ispit.ID_pitanja,pitanja.tekst FROM " +
                                "pitanja_ispit,pitanja,odgovor_ispit,korisnik_ispit WHERE " +
                                "korisnik_ispit.ID_korisnik={0} AND korisnik_ispit.ID_ispit={1} AND pitanja_ispit.ID_ispit={1} " +
                                " AND pitanja.ID_pitanja=pitanja_ispit.ID_pitanja", id_korisnik, id_ispit);
          //  MessageBox.Show(sql);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public DbDataReader DohvatiOdgovoreIspita(string id_pitanje,string id_ispit,string id_korisnik)
        {
            sql = string.Format("SELECT DISTINCT odgovor.ID_odgovor,odgovor.tekst, odgovor_ispit.oznaceno FROM " +
                                "pitanja_ispit,pitanja,odgovor_ispit,odgovor,korisnik_ispit WHERE " +
                                "korisnik_ispit.ID_korisnik={2} AND korisnik_ispit.ID_ispit={1} AND pitanja_ispit.ID_ispit={1} " +
                                " AND pitanja.ID_pitanja=pitanja_ispit.ID_pitanja AND odgovor.ID_odgovor=odgovor_ispit.ID_odgovor AND" +
                                " odgovor_ispit.ID_pitanja={0} ", id_pitanje,id_ispit,id_korisnik);
            return baza.Instanca.DohvatiDataReader(sql);
        }

        public void azurirajOdgovor(string oznaceno)
        {
        }
        #endregion
    }
}
