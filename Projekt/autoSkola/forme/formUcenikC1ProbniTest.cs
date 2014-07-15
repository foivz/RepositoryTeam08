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
    public partial class formUcenikC1ProbniTest : Form
    {
        public formUcenikC1ProbniTest()
        {
            InitializeComponent();
        }

        private void menuBtnHome_Click(object sender, EventArgs e)
        {
            formUcenikGlavni frmUcenikGlavni = new formUcenikGlavni();
            this.Close();
            frmUcenikGlavni.Show();
        }

        private void menuBtnKatB_Click(object sender, EventArgs e)
        {
            formUcenikBKat frmKatB = new formUcenikBKat();
            this.Close();
            frmKatB.Show();
        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {
            formUcenikPredmet frmKatC1 = new formUcenikPredmet();
            this.Close();
            frmKatC1.Show();
        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formPostavke frmPostavke = new formPostavke();
            frmPostavke.Show();
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            formUcenikPredmet frmKatC1 = new formUcenikPredmet();
            this.Close();
            frmKatC1.Show();
        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            boxPitanje1.Hide(); boxPitanje2.Hide(); boxPitanje3.Hide(); boxPitanje4.Hide();
            btnPredaj.Enabled = false;
            // provjera i ispis rezultata prvog pitanja
            lblPitanje1odg.Text = "Pitanje 1: ";
            lblPitanje1odg.Location = new Point(30, 50);
            
            if (!chkP1a.Checked && chkP1b.Checked && !chkP1c.Checked)
            {
                lblrez1.Text = "Točno!";
                lblrez1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblrez1.Text = "Netočno! Točan odgovor: a) povećava vozačeve sposobnosti";
                lblrez1.ForeColor = System.Drawing.Color.DarkRed;
            }
            lblrez1.Location = new Point(90, 50);

            // 2. pitanje
            lblPitanje2odg.Text = "Pitanje 2: ";
            lblPitanje2odg.Location = new Point(30, 70);

            if (txtPitanje2.Text == "50")
            {
                lblrez2.Text = "Točno!";
                lblrez2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblrez2.Text = "Netočno! Točan odgovor: 50km/h";
                lblrez2.ForeColor = System.Drawing.Color.DarkRed;
            }
            lblrez2.Location = new Point(90, 70);
            
            //3. pitanje 
            lblPitanje3odg.Text = "Pitanje 3: ";
            lblPitanje3odg.Location = new Point(30, 90);

            if (chkP3a.Checked && chkP3b.Checked && !chkP3c.Checked)
            {
                lblrez3.Text = "Točno!";
                lblrez3.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblrez3.Text = "Netočno! Točni odgovori: a) motocikle bez bočne prikolice i b) mopede";
                lblrez3.ForeColor = System.Drawing.Color.DarkRed;
            }
            lblrez3.Location = new Point(90, 90);

            //4. pitanje 
            lblPitanje4odg.Text = "Pitanje 4: ";
            lblPitanje4odg.Location = new Point(30, 110);

            if (!chkP4a.Checked && !chkP4b.Checked && chkP4c.Checked)
            {
                lblrez4.Text = "Točno!";
                lblrez4.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblrez4.Text = "Netočno! Točan odgovor: c) ne kraća od 100 metara";
                lblrez4.ForeColor = System.Drawing.Color.DarkRed;
            }
            lblrez4.Location = new Point(90, 110);
        }
    }
}
