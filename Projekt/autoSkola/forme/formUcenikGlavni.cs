using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola
{
    
    
    public partial class formUcenikGlavni : Form
    {
        /// <summary>
        /// klasa za event handler za gumb vise
        /// </summary>
        public class eventHandlerVise
        {
            int idPredmeta { get; set; }
            data podaci = null;
            formUcenikGlavni frmUcenikG;

            public eventHandlerVise(data PodaciS, int id, formUcenikGlavni that)
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

        private data podaci = null;

        public formUcenikGlavni()
        {
            InitializeComponent();
        }
        public formUcenikGlavni(data Podaci)
        {
            InitializeComponent();
            podaci = Podaci;
        }
        
        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formPostavke frmPostavke = new formPostavke(podaci);
            frmPostavke.ShowDialog();
        }


        
        /// <summary>
        /// ispis korisnikovih predmeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formUcenikGlavni_Load(object sender, EventArgs e)
        {
            int lokY = 65; //za 93 povećavamo
            ToolStripMenuItem predmeti = new ToolStripMenuItem();
            predmeti.Text = "PREDMETI";
            for (int i = 0; i < podaci.Predmet.Count; i++)
            {
                GroupBox boxPredmet = new GroupBox();
                boxPredmet.Name = podaci.Predmet[i].naziv.ToString();
                boxPredmet.Size = new Size (760, 76);
                boxPredmet.Location = new Point(12, lokY);
                lokY += 93; //pozicija Y za sljedeci GroupBox

                boxPredmet.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

                boxPredmet.Text = podaci.Predmet[i].naziv.ToString();
                boxPredmet.Font = new Font ("Microsoft Sans Serif", 10);

                this.Controls.Add(boxPredmet); 

                //ELEMENTI GROUPBOXa

                //labelovi
                Label lblStatus = new Label();
                lblStatus.Text = "Status: ";
                lblStatus.Location = new Point(7, 28);
                boxPredmet.Controls.Add(lblStatus);

                //status predmeta :(
                int predmetID = podaci.Predmet[i].ID_predmet;

                Label lblVazno = new Label();
                lblVazno.Text = "Važno: ";
                lblVazno.Location = new Point(7, 51);
                boxPredmet.Controls.Add(lblVazno);

                //btn
                Button btnVise = new Button();
                btnVise.Text = "Više";
                btnVise.Location = new Point(679, 44);
                boxPredmet.Controls.Add(btnVise);

                btnVise.Name = "btn" + podaci.Predmet[i].naziv;

                predmetID = podaci.Predmet[i].ID_predmet;
                eventHandlerVise handler = new eventHandlerVise(podaci, predmetID, this);
                btnVise.Click += new EventHandler(handler.viseHandler);
                
                // menu
                ToolStripMenuItem predmet = new ToolStripMenuItem();
                predmet.Text = podaci.Predmet[i].naziv;
                predmet.Name = podaci.Predmet[i].naziv;
                predmet.Click += new EventHandler(handler.viseHandler);
                predmeti.DropDownItems.Add(predmet);
            }
            menuVertikalni.Items.Insert(0, predmeti);
            
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
