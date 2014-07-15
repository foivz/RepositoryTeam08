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
    public partial class formUciteljStat : Form
    {
        public data dt;
        public formUciteljStat(data data)
        {
            dt = data;
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void formUciteljStat_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuBtnKatB_Click(object sender, EventArgs e)
        {


            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA(dt);
            this.Close();
            formUciteljA.Show();
        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {


            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA(dt);
            this.Close();
            formUciteljA.Show();
        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {

            formUciteljPostavke formUciteljA = new formUciteljPostavke();
            //this.Close();
            formUciteljA.Show();
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void menuBtnHome_Click(object sender, EventArgs e)
        {

            formUciteljGlavni formUciteljA = new formUciteljGlavni();
            this.Close();
            formUciteljA.Show();
        }

    }
}
