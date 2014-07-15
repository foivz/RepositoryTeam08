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
    public partial class formUcenikC1Materijali : Form
    {
        public formUcenikC1Materijali()
        {
            InitializeComponent();
        }

        private void menuBtnHome_Click(object sender, EventArgs e)
        {
            formUcenikGlavni frmUcenikGlavni = new formUcenikGlavni();
            this.Close();
            frmUcenikGlavni.Show();
        }

        private void menuBtnPredmeti_Click(object sender, EventArgs e)
        {

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

        private void btnVidiPred1_Click(object sender, EventArgs e)
        {
            formUcenikC1Predavanje1 frmC1Predavanje1 = new formUcenikC1Predavanje1();
            this.Close();
            frmC1Predavanje1.Show();
        }
    }
}
