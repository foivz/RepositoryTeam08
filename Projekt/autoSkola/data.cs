using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

// za debug!
using System.Windows.Forms;

namespace autoSkola
{
    /// <summary>
    /// Klasa za povlačenje podataka s servera i pohranu u liste 
    /// </summary>
    public class data
    {
        
        public List<cjelina> Cjelina;
        public List<dogadjaj> Dogadjaj;
        public List<grupa> Grupa;
        public List<ispit> Ispit;
        public List<korisnik> Korisnik;
        public List<korisnik_dogadjaj> Korisnik_dogadjaj;
        public List<korisnik_grupa> Korisnik_grupa;
        public List<korisnik_ispit> Korisnik_ispit;
        public List<korisnikTip> KorisnikTip;
        public List<materijal> Materijal;
        public List<odgovor> Odgovor;
        public List<odgovor_ispit> Odgovor_ispit;
        public List<pitanja> Pitanja;
        public List<predmet> Predmet;

        public int AktivniKorisnikID;

        public data() { }

        public data(string korIme, string lozinka, string tip) 
        {
            string sqlUpit = "SELECT ID_korisnik FROM korisnik WHERE korisnicko_ime='" + korIme +"' and lozinka='"+lozinka+"';";
            int ID = 0;
            bool imaNeta = true;
            try
            {
                ID = (int)baza.Instanca.DohvatiVrijednost(sqlUpit);
            }
            catch (Exception)
            {
                imaNeta = false;
            }
            
            if (!imaNeta)
            {
                string docPath = "xml/cjelina.xml";
                Cjelina = new List<cjelina>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var cj in xml.Descendants("cjelina"))
                    {
                        cjelina cjIspis = new cjelina();
                        cjIspis.opis = cj.Element("opis").Value.ToString().Trim();
                        cjIspis.naziv = cj.Element("naziv").Value.ToString().Trim();
                        cjIspis.ID_predmet = int.Parse(cj.Element("ID_predmet").Value);
                        cjIspis.ID_cjelina = int.Parse(cj.Element("ID_cjelina").Value);
                        cjIspis.promjena = false;
                        cjIspis.bodovi = float.Parse(cj.Element("bodovi").Value);

                        Cjelina.Add(cjIspis);
                    }
                }

                docPath = "xml/dogadjaj.xml";
                Dogadjaj = new List<dogadjaj>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("dogadjaj"))
                    {
                        dogadjaj elIspis = new dogadjaj();
                        elIspis.ID_dogadjaj = int.Parse(el.Element("ID_dogadjaj").Value);
                        elIspis.kreirao = int.Parse(el.Element("kreirao").Value);
                        elIspis.promjena = false;
                        elIspis.datum = DateTime.Parse(el.Element("datum").Value);
                        elIspis.napomena = el.Element("napomena").Value.ToString().Trim();

                        Dogadjaj.Add(elIspis);
                    }
                }

                docPath = "xml/grupa.xml";
                Grupa = new List<grupa>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("grupa"))
                    {
                        grupa elIspis = new grupa();
                        elIspis.ID_cjelina = int.Parse(el.Element("ID_cjelina").Value);
                        elIspis.ID_grupa = int.Parse(el.Element("ID_grupa").Value);
                        elIspis.predavac = int.Parse(el.Element("predavac").Value);
                        elIspis.promjena = false;

                        Grupa.Add(elIspis);
                    }
                }

                docPath = "xml/ispit.xml";
                Ispit = new List<ispit>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("ispit"))
                    {
                        ispit elIspis = new ispit();

                        elIspis.datum = el.Element("datum").Value.ToString().Trim();
                        elIspis.ID_ispit = int.Parse(el.Element("ID_ispit").Value);
                        elIspis.ID_grupa = int.Parse(el.Element("ID_grupa").Value);
                        elIspis.promjena = false;
                        elIspis.napomena = el.Element("napomena").Value.ToString().Trim();
                        elIspis.trajanje = el.Element("trajanje").Value.ToString().Trim();

                        Ispit.Add(elIspis);
                    }
                }

                docPath = "xml/korisnik.xml";
                Korisnik = new List<korisnik>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("korisnik"))
                    {
                        korisnik elIspis = new korisnik();
                        elIspis.ID_korisnik = int.Parse(el.Element("ID_korisnik").Value);
                        elIspis.ID_korisnikTip = int.Parse(el.Element("ID_korisnikTip").Value);
                        elIspis.promjena = false;
                        elIspis.ime = el.Element("ime").Value.ToString();

                        elIspis.korisnicko_ime = el.Element("korisnicko_ime").Value.ToString().Trim();
                        elIspis.prezime = el.Element("prezime").Value.ToString().Trim();
                        elIspis.lozinka = el.Element("lozinka").Value.ToString().Trim();
                        elIspis.mail = el.Element("mail").Value.ToString().Trim();

                        elIspis.oib = el.Element("oib").Value.ToString().Trim();
                        elIspis.telefon = el.Element("telefon").Value.ToString().Trim();

                        Korisnik.Add(elIspis);
                    }
                }

                docPath = "xml/korisnik_dogadjaj.xml";
                Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("korisnik_dogadjaj"))
                    {
                        korisnik_dogadjaj elIspis = new korisnik_dogadjaj();
                        elIspis.ID_korisnik = int.Parse(el.Element("ID_korisnik").Value);
                        elIspis.ID_dogadjaj = int.Parse(el.Element("ID_dogadjaj").Value);
                        elIspis.promjena = false;
                        elIspis.dolazak = bool.Parse(el.Element("dolazak").Value);

                        Korisnik_dogadjaj.Add(elIspis);

                    }
                }

                docPath = "xml/korisnik_grupa.xml";
                Korisnik_grupa = new List<korisnik_grupa>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("korisnik_grupa"))
                    {
                        korisnik_grupa elIspis = new korisnik_grupa();
                        elIspis.ID_korisnik = int.Parse(el.Element("ID_korisnik").Value);
                        elIspis.ID_grupa = int.Parse(el.Element("ID_grupa").Value);
                        elIspis.promjena = false;

                        Korisnik_grupa.Add(elIspis);
                    }
                }

                docPath = "xml/korisnik_ispit.xml";
                Korisnik_ispit = new List<korisnik_ispit>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("korisnik_ispit"))
                    {
                        korisnik_ispit elIspis = new korisnik_ispit();
                        elIspis.ID_korisnik = int.Parse(el.Element("ID_korisnik").Value);
                        elIspis.ID_ispit = int.Parse(el.Element("ID_ispit").Value);
                        elIspis.ID_korisnik_ispit = int.Parse(el.Element("ID_korisnik_ispit").Value);
                        elIspis.promjena = false;

                        Korisnik_ispit.Add(elIspis);
                    }
                }

                docPath = "xml/korisnikTip.xml";
                KorisnikTip = new List<korisnikTip>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("korisnikTip"))
                    {
                        korisnikTip elIspis = new korisnikTip();
                        elIspis.ID_korisnikTip = int.Parse(el.Element("ID_korisnikTip").Value);
                        elIspis.naziv = el.Element("naziv").Value.ToString().Trim();
                        elIspis.promjena = false;

                        KorisnikTip.Add(elIspis);
                    }
                }

                docPath = "xml/materijal.xml";
                Materijal = new List<materijal>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("materijal"))
                    {
                        materijal elIspis = new materijal();
                        elIspis.srcMaterijal = el.Element("srcMaterijal").Value.ToString().Trim();
                        elIspis.ID_cjelina = int.Parse(el.Element("ID_cjelina").Value);
                        elIspis.ID_materijal = int.Parse(el.Element("ID_materijal").Value);
                        elIspis.opis = el.Element("opis").Value.ToString().Trim();
                        elIspis.promjena = false;

                        Materijal.Add(elIspis);
                    }
                }

                docPath = "xml/odgovor.xml";
                Odgovor = new List<odgovor>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("odgovor"))
                    {
                        odgovor elIspis = new odgovor();
                        elIspis.tekst = el.Element("tekst").Value.ToString().Trim();
                        elIspis.srcOdgovor = el.Element("srcOdgovor").Value.ToString().Trim();
                        elIspis.ID_pitanja = int.Parse(el.Element("ID_pitanja").Value);
                        elIspis.ID_odgovor = int.Parse(el.Element("ID_odgovor").Value);
                        elIspis.bodovi = float.Parse(el.Element("bodovi").Value);
                        elIspis.promjena = false;

                        Odgovor.Add(elIspis);
                    }
                }

                docPath = "xml/odgovor_ispit.xml";
                Odgovor_ispit = new List<odgovor_ispit>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("odgovor_ispit"))
                    {
                        odgovor_ispit elIspis = new odgovor_ispit();
                        elIspis.ID_korisnik_ispit = int.Parse(el.Element("ID_korisnik_ispit").Value);
                        elIspis.ID_pitanja = int.Parse(el.Element("ID_pitanja").Value);
                        elIspis.ID_odgovor = int.Parse(el.Element("ID_odgovor").Value);
                        elIspis.promjena = false;

                        Odgovor_ispit.Add(elIspis);
                    }
                }

                docPath = "xml/pitanja.xml";
                Pitanja = new List<pitanja>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var el in xml.Descendants("pitanja"))
                    {
                        pitanja elIspis = new pitanja();
                        elIspis.tekst = el.Element("tekst").Value.ToString().Trim();
                        elIspis.srcPitanja = el.Element("srcPitanja").Value.ToString().Trim();
                        elIspis.ID_pitanja = int.Parse(el.Element("ID_pitanja").Value);
                        elIspis.ID_cjelina = int.Parse(el.Element("ID_cjelina").Value);
                        elIspis.promjena = false;

                        Pitanja.Add(elIspis);
                    }
                }

                docPath = "xml/predmet.xml";
                Predmet = new List<predmet>();
                if (File.Exists(docPath))
                {
                    XDocument xml = XDocument.Load(docPath);
                    foreach (var pr in xml.Descendants("predmet"))
                    {
                        predmet prIspis = new predmet();
                        prIspis.naziv = pr.Element("naziv").Value.ToString().Trim();
                        prIspis.ID_predmet = int.Parse(pr.Element("ID_predmet").Value);
                        prIspis.promjena = false;
                        prIspis.opis = pr.Element("opis").Value.ToString().Trim();

                        Predmet.Add(prIspis);
                    }
                }

            }
            else
            {
                if (int.Parse(tip) == 100)
                {
                    // dohvaća podatke koje korisnik može pregledavati i pohranjuje ih u listu
                    DbDataReader reader;
                    Cjelina = new List<cjelina>();
                    sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis,cjelina.bodovi FROM cjelina,grupa,korisnik_grupa WHERE cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);

                    while (reader.Read())
                    {
                        Cjelina.Add(new cjelina(reader));
                    }
                    reader.Close();

                    //postupak se ponavlja za svaku listu

                    Dogadjaj = new List<dogadjaj>();
                    sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj,korisnik_dogadjaj WHERE dogadjaj.ID_dogadjaj=korisnik_dogadjaj.ID_dogadjaj and korisnik_dogadjaj.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Dogadjaj.Add(new dogadjaj(reader));
                    }
                    reader.Close();


                    Grupa = new List<grupa>();
                    sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa,korisnik_grupa WHERE grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                      Grupa.Add(new grupa(reader));
                    }
                    reader.Close();
                        
                    
                    Ispit = new List<ispit>();
                    sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit,korisnik_ispit WHERE ispit.ID_ispit=korisnik_ispit.ID_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Ispit.Add(new ispit(reader));
                    }
                    reader.Close();


                    Korisnik = new List<korisnik>();
                    sqlUpit = "SELECT * FROM korisnik WHERE ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                       Korisnik.Add(new korisnik(reader));
                    }
                    reader.Close();


                    Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
                    sqlUpit = "SELECT * FROM korisnik_dogadjaj WHERE korisnik_dogadjaj.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_dogadjaj.Add(new korisnik_dogadjaj(reader));
                    }
                    reader.Close();

                    Korisnik_grupa = new List<korisnik_grupa>();
                    sqlUpit = "SELECT * FROM korisnik_grupa WHERE korisnik_grupa.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_grupa.Add(new korisnik_grupa(reader));
                    }
                    reader.Close();

                    Korisnik_ispit = new List<korisnik_ispit>();
                    sqlUpit = "SELECT * FROM korisnik_ispit WHERE korisnik_ispit.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                       Korisnik_ispit.Add(new korisnik_ispit(reader));
                    }
                    reader.Close();

                    KorisnikTip = new List<korisnikTip>();
                    sqlUpit = "SELECT * FROM korisnikTip;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                       KorisnikTip.Add(new korisnikTip(reader));
                    }
                    reader.Close();


                    Materijal = new List<materijal>();
                    sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcMaterijal FROM materijal,grupa,korisnik_grupa WHERE materijal.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Materijal.Add(new materijal(reader));
                    }
                    reader.Close();
                    

                    Odgovor = new List<odgovor>();
                    sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.bodovi,odgovor.srcOdgovor FROM odgovor,pitanja,grupa,korisnik_grupa WHERE odgovor.ID_pitanja=pitanja.ID_pitanja and pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Odgovor.Add(new odgovor(reader));
                    }
                    reader.Close();
                    

                    Odgovor_ispit = new List<odgovor_ispit>();
                    sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit,korisnik_ispit WHERE odgovor_ispit.ID_korisnik_ispit=korisnik_ispit.ID_korisnik_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                       Odgovor_ispit.Add(new odgovor_ispit(reader));
                    }
                    reader.Close();

                    Pitanja = new List<pitanja>();
                    sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja FROM pitanja,grupa,korisnik_grupa WHERE pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Pitanja.Add(new pitanja(reader));
                    }
                    reader.Close();

                    Predmet = new List<predmet>();
                    sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet,cjelina,grupa,korisnik_grupa WHERE predmet.ID_predmet=cjelina.ID_predmet and cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Predmet.Add(new predmet(reader));
                    }
                    reader.Close();

                }

                //ADMIN

                else if (int.Parse(tip) == 103)
                {

                    DbDataReader reader;
                    Cjelina = new List<cjelina>();
                    sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis,cjelina.bodovi FROM cjelina;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Cjelina.Add(new cjelina(reader));
                    }
                    reader.Close();

                    Dogadjaj = new List<dogadjaj>();
                    sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Dogadjaj.Add(new dogadjaj(reader));
                    }
                    reader.Close();

                    Grupa = new List<grupa>();
                    sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Grupa.Add(new grupa(reader));
                    }
                    reader.Close();

                    Ispit = new List<ispit>();
                    sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Ispit.Add(new ispit(reader));
                    }
                    reader.Close();

                    Korisnik = new List<korisnik>();
                    sqlUpit = "SELECT * FROM korisnik;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik.Add(new korisnik(reader));
                    }
                    reader.Close();


                    Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
                    sqlUpit = "SELECT * FROM korisnik_dogadjaj;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_dogadjaj.Add(new korisnik_dogadjaj(reader));
                    }
                    reader.Close();

                    Korisnik_grupa = new List<korisnik_grupa>();
                    sqlUpit = "SELECT * FROM korisnik_grupa;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_grupa.Add(new korisnik_grupa(reader));
                    }
                    reader.Close();

                    Korisnik_ispit = new List<korisnik_ispit>();
                    sqlUpit = "SELECT * FROM korisnik_ispit;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_ispit.Add(new korisnik_ispit(reader));
                    }
                    reader.Close();

                    KorisnikTip = new List<korisnikTip>();
                    sqlUpit = "SELECT * FROM korisnikTip;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        KorisnikTip.Add(new korisnikTip(reader));
                    }
                    reader.Close();

                    Materijal = new List<materijal>();
                    sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcMaterijal FROM materijal;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Materijal.Add(new materijal(reader));
                    }
                    reader.Close();

                    Odgovor = new List<odgovor>();
                    sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.bodovi,odgovor.srcOdgovor FROM odgovor;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Odgovor.Add(new odgovor(reader));
                    }
                    reader.Close();

                    Odgovor_ispit = new List<odgovor_ispit>();
                    sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Odgovor_ispit.Add(new odgovor_ispit(reader));
                    }
                    reader.Close();

                    Pitanja = new List<pitanja>();
                    sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja FROM pitanja;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Pitanja.Add(new pitanja(reader));
                    }
                    reader.Close();

                    Predmet = new List<predmet>();
                    sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Predmet.Add(new predmet(reader));
                    }
                    reader.Close();
                }
                else if (int.Parse(tip) == 101 || int.Parse(tip) == 102)
                {

                    //TO DO
                    //cjelina.bodovi ne postoji!
                    //
                    Cjelina = new List<cjelina>();
                    sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis, cjelina.bodovi FROM cjelina,grupa WHERE cjelina.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                    DbDataReader reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    int debugC = 0;
                    while (reader.Read())
                    {
                        Cjelina.Add(new cjelina(reader));
                    }
                    reader.Close();

                    Dogadjaj = new List<dogadjaj>();
                    sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj,korisnik_dogadjaj WHERE dogadjaj.kreirao=" + ID + "OR (dogadjaj.ID_dogadjaj=korisnik_dogadjaj.ID_dogadjaj AND korisnik_dogadjaj.ID_korisnik=" + ID + ");";
                    
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Dogadjaj.Add(new dogadjaj(reader));
                    }
                    reader.Close();

                    Grupa = new List<grupa>();
                    sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa WHERE grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Grupa.Add(new grupa(reader));
                    }
                    reader.Close();

                    Ispit = new List<ispit>();
                    sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit,grupa,cjelina WHERE ispit.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Ispit.Add(new ispit(reader));
                    }
                    reader.Close();

                    Korisnik = new List<korisnik>();
                    sqlUpit = "SELECT korisnik.ID_korisnik,korisnik.ime,korisnik.prezime,korisnik.korisnicko_ime,korisnik.lozinka,korisnik.oib,korisnik.mail,korisnik.telefon,korisnik.ID_korisnikTip FROM korisnik,grupa,korisnik_grupa WHERE (korisnik.ID_korisnik=korisnik_grupa.ID_korisnik and korisnik_grupa.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ") or korisnik.ID_korisnikTip<>100;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik.Add(new korisnik(reader));
                    }
                    reader.Close();

                    Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
                    sqlUpit = "SELECT korisnik_dogadjaj.ID_dogadjaj,korisnik_dogadjaj.ID_korisnik,korisnik_dogadjaj.dolazak FROM korisnik_dogadjaj,dogadjaj WHERE korisnik_dogadjaj.ID_dogadjaj=dogadjaj.ID_dogadjaj and dogadjaj.kreirao=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_dogadjaj.Add(new korisnik_dogadjaj(reader));
                        //MessageBox.Show(Korisnik_dogadjaj[debugC].ID_korisnik.ToString());
                        debugC++;
                    }
                    reader.Close();
                    Korisnik_grupa = new List<korisnik_grupa>();
                    sqlUpit = "SELECT korisnik_grupa.ID_grupa,korisnik_grupa.ID_korisnik FROM korisnik_grupa,grupa WHERE korisnik_grupa.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_grupa.Add(new korisnik_grupa(reader));
                    }
                    reader.Close();

                    Korisnik_ispit = new List<korisnik_ispit>();
                    sqlUpit = "SELECT korisnik_ispit.ID_korisnik_ispit,korisnik_ispit.ID_korisnik,korisnik_ispit.ID_ispit FROM korisnik_ispit,ispit,grupa WHERE korisnik_ispit.ID_ispit=ispit.ID_ispit and ispit.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Korisnik_ispit.Add(new korisnik_ispit(reader));
                    }
                    reader.Close();

                    KorisnikTip = new List<korisnikTip>();
                    sqlUpit = "SELECT * FROM korisnikTip;";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        KorisnikTip.Add(new korisnikTip(reader));
                    }
                    reader.Close();

                    Materijal = new List<materijal>();
                    sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcMaterijal FROM materijal,grupa WHERE materijal.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Materijal.Add(new materijal(reader));
                    }
                    reader.Close();

                    Odgovor = new List<odgovor>();
                    sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.bodovi,odgovor.srcOdgovor FROM odgovor,pitanja,grupa WHERE odgovor.ID_pitanja=pitanja.ID_pitanja and pitanja.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Odgovor.Add(new odgovor(reader));
                    }
                    reader.Close();

                    Odgovor_ispit = new List<odgovor_ispit>(); ;
                    sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit,korisnik_ispit,ispit,grupa WHERE odgovor_ispit.ID_korisnik_ispit=korisnik_ispit.ID_korisnik_ispit and korisnik_ispit.ID_ispit=ispit.ID_ispit and ispit.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Odgovor_ispit.Add(new odgovor_ispit(reader));
                    }
                    reader.Close();

                    Pitanja = new List<pitanja>(); ;
                    sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja FROM pitanja,grupa WHERE pitanja.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Pitanja.Add(new pitanja(reader));
                    }
                    reader.Close();

                    Predmet = new List<predmet>(); ;
                    sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet,cjelina,grupa WHERE predmet.ID_predmet=cjelina.ID_predmet and cjelina.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                    reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                    while (reader.Read())
                    {
                        Predmet.Add(new predmet(reader));
                    }
                    reader.Close();
                }

                AktivniKorisnikID = ID;
            }
         
            
        }




    }
}
