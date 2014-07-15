using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace autoSkola
{
    class xmlManip
    {
        public data DT;

        public bool save()
        {
            string mapaPath = "xml";
            if (!Directory.Exists(mapaPath))
                Directory.CreateDirectory(mapaPath);

            if (DT.Cjelina.Count > 0)
            {
                string docPath = mapaPath + "/cjelina.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<cjelina>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<cjelina> CjelinaUpis = new List<cjelina>();

                for (int i = 0; i < DT.Cjelina.Count; i++)
                {
                    CjelinaUpis.Add(DT.Cjelina[i]);
                }
                srl.Serialize(pisac, CjelinaUpis);
                pisac.Close();
            }

            if (DT.Dogadjaj.Count > 0)
            {
                string docPath = mapaPath + "/dogadjaj.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<dogadjaj>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<dogadjaj> DogadjajUpis = new List<dogadjaj>();

                for (int i = 0; i < DT.Dogadjaj.Count; i++)
                {
                    DogadjajUpis.Add(DT.Dogadjaj[i]);
                }
                srl.Serialize(pisac, DogadjajUpis);
                pisac.Close();

            }

            if (DT.Grupa.Count > 0)
            {
                string docPath = mapaPath + "/grupa.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<grupa>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<grupa> GrupaUpis = new List<grupa>();

                for (int i = 0; i < DT.Grupa.Count; i++)
                {
                    GrupaUpis.Add(DT.Grupa[i]);
                }
                srl.Serialize(pisac, GrupaUpis);
                pisac.Close();

            }

            if (DT.Ispit.Count > 0)
            {
                string docPath = mapaPath + "/ispit.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<ispit>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<ispit> IspitUpis = new List<ispit>();

                for (int i = 0; i < DT.Ispit.Count; i++)
                {
                    IspitUpis.Add(DT.Ispit[i]);
                }
                srl.Serialize(pisac, IspitUpis);
                pisac.Close();

            }

            if (DT.Korisnik.Count > 0)
            {
                string docPath = mapaPath + "/korisnik.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<korisnik>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<korisnik> KorisnikUpis = new List<korisnik>();

                for (int i = 0; i < DT.Korisnik.Count; i++)
                {
                    KorisnikUpis.Add(DT.Korisnik[i]);
                }
                srl.Serialize(pisac, KorisnikUpis);
                pisac.Close();
            }

            if (DT.Korisnik_dogadjaj.Count > 0)
            {
                string docPath = mapaPath + "/korisnik_dogadjaj.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<korisnik_dogadjaj>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<korisnik_dogadjaj> Korisnik_dogadjajUpis = new List<korisnik_dogadjaj>();

                for (int i = 0; i < DT.Korisnik_dogadjaj.Count; i++)
                {
                    Korisnik_dogadjajUpis.Add(DT.Korisnik_dogadjaj[i]);
                }
                srl.Serialize(pisac, Korisnik_dogadjajUpis);
                pisac.Close();

            }

            if (DT.Korisnik_grupa.Count > 0)
            {
                string docPath = mapaPath + "/korisnik_grupa.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<korisnik_grupa>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<korisnik_grupa> Korisnik_grupaUpis = new List<korisnik_grupa>();

                for (int i = 0; i < DT.Korisnik_grupa.Count; i++)
                {
                    Korisnik_grupaUpis.Add(DT.Korisnik_grupa[i]);
                }
                srl.Serialize(pisac, Korisnik_grupaUpis);
                pisac.Close();
            }

            if (DT.Korisnik_ispit.Count > 0)
            {
                string docPath = mapaPath + "/korisnik_ispit.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<korisnik_ispit>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<korisnik_ispit> Korisnik_ispitUpis = new List<korisnik_ispit>();

                for (int i = 0; i < DT.Korisnik_ispit.Count; i++)
                {
                    Korisnik_ispitUpis.Add(DT.Korisnik_ispit[i]);
                }
                srl.Serialize(pisac, Korisnik_ispitUpis);
                pisac.Close();
            }

            if (DT.KorisnikTip.Count > 0)
            {
                string docPath = mapaPath + "/korisnikTip.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<korisnikTip>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<korisnikTip> KorisnikTipUpis = new List<korisnikTip>();

                for (int i = 0; i < DT.KorisnikTip.Count; i++)
                {
                    KorisnikTipUpis.Add(DT.KorisnikTip[i]);
                }
                srl.Serialize(pisac, KorisnikTipUpis);
                pisac.Close();

            }

            if (DT.Materijal.Count > 0)
            {
                string docPath = mapaPath + "/materijal.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<materijal>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<materijal> MaterijalUpis = new List<materijal>();

                for (int i = 0; i < DT.Materijal.Count; i++)
                {
                    MaterijalUpis.Add(DT.Materijal[i]);
                }
                srl.Serialize(pisac, MaterijalUpis);
                pisac.Close();

            }

            if (DT.Odgovor.Count > 0)
            {
                string docPath = mapaPath + "/odgovor.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<odgovor>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<odgovor> OdgovorUpis = new List<odgovor>();

                for (int i = 0; i < DT.Odgovor.Count; i++)
                {
                    OdgovorUpis.Add(DT.Odgovor[i]);
                }
                srl.Serialize(pisac, OdgovorUpis);
                pisac.Close();

            }

            if (DT.Odgovor_ispit.Count > 0)
            {
                string docPath = mapaPath + "/odgovor_ispit.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<odgovor_ispit>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<odgovor_ispit> Odgovor_ispitUpis = new List<odgovor_ispit>();

                for (int i = 0; i < DT.Odgovor_ispit.Count; i++)
                {
                    Odgovor_ispitUpis.Add(DT.Odgovor_ispit[i]);
                }
                srl.Serialize(pisac, Odgovor_ispitUpis);
                pisac.Close();

            }

            if (DT.Pitanja.Count > 0)
            {
                string docPath = mapaPath + "/pitanja.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<pitanja>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<pitanja> PitanjaUpis = new List<pitanja>();

                for (int i = 0; i < DT.Pitanja.Count; i++)
                {
                    PitanjaUpis.Add(DT.Pitanja[i]);
                }
                srl.Serialize(pisac, PitanjaUpis);
                pisac.Close();

            }

            if (DT.Predmet.Count > 0)
            {
                string docPath = mapaPath + "/predmet.xml";
                XmlSerializer srl = new XmlSerializer(typeof(List<predmet>));
                StreamWriter pisac = new StreamWriter(docPath);

                List<predmet> PredmetUpis = new List<predmet>();

                for (int i = 0; i < DT.Predmet.Count; i++)
                {
                    PredmetUpis.Add(DT.Predmet[i]);
                }
                srl.Serialize(pisac, PredmetUpis);
                pisac.Close();

            }
            System.Windows.Forms.MessageBox.Show("xmlWrite");
            return true;
        }
    }
}
