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
    public partial class formUciteljGlavni : Form
    {
        private data podaci = null;
        private string id = "";
        Upiti klasa_upita = new Upiti();

        public formUciteljGlavni(data Podaci,int id)
        {
            InitializeComponent();
            podaci = Podaci;
            this.id = id.ToString();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void DohvatiBrojeveGrupaIKorisnika(string id)
        {
            lblA1grupe.Text = klasa_upita.DohvatiBrojGrupa(id, "A1");
            lblA1polaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "A1");

            lblA2grupe.Text = klasa_upita.DohvatiBrojGrupa(id, "A2");
            lblA2polaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "A2");

            lblAgrupe.Text = klasa_upita.DohvatiBrojGrupa(id, "A");
            lblApolaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "A");

            lblBEgrupe.Text = klasa_upita.DohvatiBrojGrupa(id, "B+E");
            lblBEpolaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "B+E");

            lblBgrupe.Text = klasa_upita.DohvatiBrojGrupa(id, "B");
            lblBpolaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "B");

            lblC1Egrupe.Text = klasa_upita.DohvatiBrojGrupa(id, "C1+E");
            lblC1Epolaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "C1+E");

            lblC1grupe.Text = klasa_upita.DohvatiBrojGrupa(id, "C1");
            lblC1polaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "C1");

            lblCEgrupe.Text = klasa_upita.DohvatiBrojGrupa(id, "C+E");
            lblCEpolaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "C+E");

            lblCgrupe.Text = klasa_upita.DohvatiBrojGrupa(id, "C");
            lblCpolaznici.Text = klasa_upita.DohvatiBrojUcenikaUgrupama(id, "C");

            lblMgrupe.Text = klasa_upita.DohvatiBrojGrupa(id, "M");
            lblMpolaznici.Text = klasa_upita.DohvatiBrojGrupa(id, "M");
        }

        public formUciteljGlavni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("A1",id);
            formUciteljA.Show();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formPostavke formUciteljP = new formPostavke(podaci);
            formUciteljP.ShowDialog();
        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formKA = new formUciteljKategorijaA(podaci);
            formKA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sTATISTIKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUciteljStat formST = new formUciteljStat(podaci);
            this.Close();
            formST.Show();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("M", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnBE_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("B+E", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("C+E", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("B", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("A", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("C", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnC1E_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("C1+E", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("A2", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA("C1", id);
            formUciteljA.ShowDialog();
            DohvatiBrojeveGrupaIKorisnika(id.ToString());
        }

        private void kALENDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forme.frmKalendar kal = new forme.frmKalendar(id);
            kal.ShowDialog();
        }

        /// <summary>
        /// override Close btn!
        /// </summary>
        /// <param name="e"> form closing event</param>
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);
        //    if (e.CloseReason == CloseReason.WindowsShutDown)
        //        return;
        //    else
        //    {
        //        baza.Instanca.Zatvori(podaci, true);
        //    }
        //}
    }
}
