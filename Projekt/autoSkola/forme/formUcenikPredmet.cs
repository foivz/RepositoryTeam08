using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola
{
    
    public partial class formUcenikPredmet : Form
    {
        /// <summary>
        /// klasa za event handler za gumb Evidencija
        /// </summary>
        public class eventHandlerEvidencija
        {
            int idCjelina { get; set; }
            data podaci = null;

            public eventHandlerEvidencija(data PodaciS, int id)
            {
                this.idCjelina = id;
                podaci = PodaciS;
            }

            /// <summary>
            /// funkcija za dogadjaj nakon klika na određeni gumb Više.
            /// Naziv predmeta se proslijeđuje preko klase - eventHandlerVise
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            public void evidencijaHandler(object sender, EventArgs e)
            {
                int idT = this.idCjelina;
                formUcenikEvidencija frmEvidencija = new formUcenikEvidencija(podaci, idT);
                frmEvidencija.ShowDialog();
            }
        }

        /// <summary>
        /// klasa za event handler za gumb vise
        /// </summary>
        public class eventHandlerVise
        {
            int idPredmeta { get; set; }
            data podaci = null;
            formUcenikPredmet frmUcenikG;

            public eventHandlerVise(data PodaciS, int id, formUcenikPredmet that)
            {
                this.idPredmeta = id;
                podaci = PodaciS;
                frmUcenikG = that;
            }

            /// <summary>
            /// funkcija za dogadjaj nakon klika na određeni gumb Više.
            /// Naziv predmeta se proslijeđuje preko klase - eventHandlerVise
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            public void viseHandler(object sender, EventArgs e)
            {
                int idT = this.idPredmeta;
                formUcenikPredmet frmPredmet = new formUcenikPredmet(podaci, idT);

                frmPredmet.Show();
                frmUcenikG.Hide();

            }
        }
        
        data podaci = null;
        int predmetID;
        int poz; //pozicija predmeta
        public formUcenikPredmet()
        {
            InitializeComponent();
        }
        public formUcenikPredmet(data Podaci, int ID)
        {
            InitializeComponent();
            podaci = Podaci;
            predmetID = ID;
        }
        //MENU start
        private void menuBtnHome_Click(object sender, EventArgs e)
        {
            formUcenikGlavni frmUcenikGlavni = new formUcenikGlavni(podaci);
            frmUcenikGlavni.Show();
            this.Hide();
        }

       
        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formPostavke frmPostavke = new formPostavke(podaci);
            frmPostavke.ShowDialog();
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            baza.Instanca.Zatvori(podaci);
            Application.Exit();
        }
        
        //MENU end

        /// <summary>
        /// funkcija za ispis dogadjaja prilikom klika na određeni datum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kalendarObveza_DateSelected(object sender, DateRangeEventArgs e)
        {
            string datumOdabrani = kalendarObveza.SelectionStart.ToShortDateString();


            for (int i = 0; i < podaci.Dogadjaj.Count; i++)
            {
                for (int j = 0; j < podaci.Cjelina.Count; j++)
                {
                    if (podaci.Cjelina[j].ID_predmet == this.predmetID)
                    {
                        for (int k = 0; k < podaci.Grupa.Count; k++)
                        {
                            if (podaci.Grupa[k].ID_cjelina == podaci.Cjelina[j].ID_cjelina && podaci.Dogadjaj[i].kreirao == podaci.Grupa[k].predavac && podaci.Dogadjaj[i].datum.ToShortDateString() == datumOdabrani)
                            {
                                string obavijest = podaci.Dogadjaj[i].datum.ToShortTimeString() + "h - " + podaci.Dogadjaj[i].napomena;
                                MessageBox.Show(obavijest, datumOdabrani, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
                
        }

        private void formUcenikPredmet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < podaci.Dogadjaj.Count; i++)
            {
                for (int j = 0; j < podaci.Cjelina.Count; j++)
                {
                    if (podaci.Cjelina[j].ID_predmet == this.predmetID)
                    {
                        for (int k = 0; k < podaci.Grupa.Count; k++)
                        {
                            if (podaci.Grupa[k].ID_cjelina == podaci.Cjelina[j].ID_cjelina && podaci.Dogadjaj[i].kreirao == podaci.Grupa[k].predavac)
                            {
                                kalendarObveza.AddBoldedDate(podaci.Dogadjaj[i].datum);
                            }
                        }
                    }
                }
            }
            
            ToolStripMenuItem predmeti = new ToolStripMenuItem();
            predmeti.Text = "PREDMETI";
            for (int i = 0; i < podaci.Predmet.Count; i++)
            {
                ToolStripMenuItem predmet = new ToolStripMenuItem();
                predmet.Text = podaci.Predmet[i].naziv;
                predmet.Name = podaci.Predmet[i].naziv;
                int ID = podaci.Predmet[i].ID_predmet;
                eventHandlerVise handler = new eventHandlerVise(podaci, ID, this);
                predmet.Click += new EventHandler(handler.viseHandler);
                predmeti.DropDownItems.Add(predmet);
            }
            menuVertikalni.Items.Insert(1, predmeti);          

           for (int i = 0; i < podaci.Predmet.Count; i++)
            {
                if (podaci.Predmet[i].ID_predmet == predmetID)
                {
                    poz = i;
                    break;
                }
            }

           lblNaziv.Text = podaci.Predmet[poz].naziv.Trim();

            //ispis cjelina
            int lokY = 216; //za 90 povećavamo
            for (int i = 0; i < podaci.Cjelina.Count; i++)
            {
                
                if (podaci.Cjelina[i].ID_predmet == predmetID)
                {
                   
                    GroupBox boxCjelina = new GroupBox();
                    boxCjelina.Name = podaci.Cjelina[i].naziv.Trim();
                    boxCjelina.Size = new Size(760, 90);
                    boxCjelina.Location = new Point(12, lokY);
                    lokY += 90; //pozicija Y za sljedeci gbox
                    
                    boxCjelina.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

                    boxCjelina.Text = podaci.Cjelina[i].naziv;
                    boxCjelina.Font = new Font("Microsoft Sans Serif", 10);

                    this.Controls.Add(boxCjelina);

                    //ELEMENTI GROUPBOXa

                    //label STATUS:
                    Label lblStatus = new Label();
                    lblStatus.Text = "Status: ";
                    lblStatus.Size = new Size(55,16);
                    lblStatus.Location = new Point(6, 29);
                    boxCjelina.Controls.Add(lblStatus);

                    //label status info
                    Label lblStatusInfo = new Label();
                    lblStatusInfo.Text = "Nije položeno";
                    lblStatusInfo.ForeColor = Color.DarkRed;
                    
                    if (podaci.Cjelina[i].prolaz == 1)
                    {
                        lblStatusInfo.Text = "Položeno";
                        lblStatusInfo.ForeColor = Color.DarkGreen;
                    }
                   
                    lblStatusInfo.Location = new Point(60, 29);
                    boxCjelina.Controls.Add(lblStatusInfo);

                    //label ISPIT:
                    Label lblIspit = new Label();
                    lblIspit.Text = "Ispit: ";
                    lblIspit.Location = new Point(16, 54);

                    boxCjelina.Controls.Add(lblIspit);
                    
                    //btn Evidencija
                    Button btnEvidencija = new Button();
                    btnEvidencija.Text = "Evidencija";
                    btnEvidencija.Location = new Point(679, 61);
                    btnEvidencija.Font = new Font("Microsoft Sans Serif", 8);
                    boxCjelina.Controls.Add(btnEvidencija);
                    eventHandlerEvidencija handler = new eventHandlerEvidencija(podaci, podaci.Cjelina[i].ID_cjelina);
                    btnEvidencija.Click += new EventHandler(handler.evidencijaHandler);
                   
                    //btn Materijali
                    Button btnMaterijali = new Button();
                    btnMaterijali.Text = "Materijali";
                    btnMaterijali.Location = new Point(598, 61);
                    btnMaterijali.Font = new Font("Microsoft Sans Serif", 8);
                    boxCjelina.Controls.Add(btnMaterijali);

                    //btn Probno testiranje
                    Button btnProbno = new Button();
                    btnProbno.Text = "Probno testiranje";
                    btnProbno.Location = new Point(496, 61);
                    btnProbno.Font = new Font("Microsoft Sans Serif", 8);
                    btnProbno.Size = new Size(96,23);
                    //ako je korisnik prosao cjelinu nema potrebe za probnim testiranjem
                    if (podaci.Cjelina[i].prolaz == 1)
                        btnProbno.Enabled = false;
                    boxCjelina.Controls.Add(btnProbno);

                    //btn Ispit
                    Button btnIspit = new Button();
                    btnIspit.Text = "Pristupi ispitu";
                    btnIspit.Location = new Point(394, 61);
                    btnIspit.Enabled = false;
                    btnIspit.Font = new Font("Microsoft Sans Serif", 8);
                    btnIspit.Size = new Size(96, 23);
                    boxCjelina.Controls.Add(btnIspit);

                } //if (podaci.Cjelina[i].ID_predmet == predmetID)
            } //for 
            
        }

        /// <summary>
        /// override Close (x) btn!
        /// </summary>
        /// <param name="e"> form closing event</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            else
            {
                baza.Instanca.Zatvori(podaci, true);
            }
        }
    }
}
