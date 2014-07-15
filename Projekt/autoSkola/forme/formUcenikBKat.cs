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
    public partial class formUcenikBKat : Form
    {
        public formUcenikBKat()
        {
            InitializeComponent();
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formPostavke frmPostavke = new formPostavke();
            frmPostavke.Show();
        }

        private void menuBtnKatB_Click(object sender, EventArgs e)
        {
            formUcenikBKat frmKatB = new formUcenikBKat();
            this.Close();
            frmKatB.Show();
        }

        private void menuVertikalni_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuBtnHome_Click(object sender, EventArgs e)
        {
            formUcenikGlavni frmUcenikGlavni = new formUcenikGlavni();
            this.Close();
            frmUcenikGlavni.Show();
        }

        private void kalendarObvezaB_DateSelected(object sender, DateRangeEventArgs e)
        {
            string datumOdabrani = kalendarObvezaB.SelectionStart.ToShortDateString();
            
            if (datumOdabrani == "1.5.2013.")
            {
                string obavijest = "Ispit iz teorije, dvorana1, 08:00-10:00h";
                MessageBox.Show(obavijest, datumOdabrani, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnTeorijaEvidencija_Click(object sender, EventArgs e)
        {
            formUcenikEvidencija frmEvidencijaTeorijaB = new formUcenikEvidencija();
            frmEvidencijaTeorijaB.Show();
        }

        private void btnTeorijaIspit_Click(object sender, EventArgs e)
        {
            formUcenikBTeorijaRezultat frmRezultatiIspita = new formUcenikBTeorijaRezultat();
            frmRezultatiIspita.Show();
        }

        private void btnVoznjaIspit_Click(object sender, EventArgs e)
        {
            formUcenikBVoznjaRezultat frmVoznjaRezultat = new formUcenikBVoznjaRezultat();
            frmVoznjaRezultat.Show();
        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {
            formUcenikPredmet frmKatC1 = new formUcenikPredmet();
            this.Close();
            frmKatC1.Show();
        }
    }
}
