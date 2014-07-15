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
using autoSkola.forme;

namespace autoSkola
{
    public partial class formUciteljKategorijaA : Form
    {
        public data dt;
        Upiti klasa_upita = new Upiti();
        string id;
        public formUciteljKategorijaA(data data)
        {
            dt = data;
            InitializeComponent();

            
        }

        private string kategorija;
        public formUciteljKategorijaA(string kategorija,string id)
        {
            InitializeComponent();
            this.kategorija = kategorija;
            this.id = id;
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void DohvatiGrupe(string kategorija, string id)
        {
            DbDataReader dr = klasa_upita.DohvatiGrupeKorisnika(id, kategorija);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUciteljNRok formUciteljNR = new formUciteljNRok();
            formUciteljNR.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formUciteljNMaterijal formUciteljNMat = new formUciteljNMaterijal(dt);
            formUciteljNMat.Show();
        }

        private void btnNCjelina_Click(object sender, EventArgs e)
        {
            formUciteljNCjelina formUciteljNCj = new formUciteljNCjelina();
            formUciteljNCj.Show();
        }

        private void btnEvidencija_Click(object sender, EventArgs e)
        {
            formUciteljNEvidencija formUciteljNE = new formUciteljNEvidencija();
            formUciteljNE.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            formUciteljNPitanje formUciteljNP = new formUciteljNPitanje();
            formUciteljNP.Show();
        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {
            this.kategorija = "A2";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);

        }

        private void menuBtnKatB_Click(object sender, EventArgs e)
        {
            this.kategorija = "A1";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
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

        private void sTATISTIKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUciteljStat formST = new formUciteljStat(dt);
            this.Close();
            formST.Show();
        }

        private void btnEvidentirajDogađaj_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            forme.frmEvidentirajDogadaj evidentiraj = new forme.frmEvidentirajDogadaj(
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),id);

            evidentiraj.ShowDialog();
            this.Enabled = true;
        }

        private void btnNovirok_Click(object sender, EventArgs e)
        {
            frmIspitniRok rokovi_forma=new frmIspitniRok(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            rokovi_forma.ShowDialog();
        }

        private void btnDodajGrupu_Click(object sender, EventArgs e)
        {
            forme.frmDodajGrupu dodajgrupu = new forme.frmDodajGrupu(id,kategorija);
            dodajgrupu.ShowDialog();
            DohvatiGrupe(kategorija, id);
        }

        private void btnBrisiGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati grupu", "Brisanje grupe", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    klasa_upita.ObrisiGrupu(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Uspješno obrisana grupa");
                    DohvatiGrupe(kategorija, id);
                }
            }
            catch
            {
                MessageBox.Show("Nije obrisana grupa");
            }
        }

        private void btnUrediGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati učenik iz grupe", "Brisanje učenik iz grupe", 
                   MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {
                   klasa_upita.BrisiKorisnikaIzGrupe(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                       dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                   MessageBox.Show("Uspješno obrisan učenik iz grupe");
                   DohvatiGrupe(kategorija, id);
               }
            }
            catch
            {
                MessageBox.Show("Nije uspješno obrisano!");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblPopisKorisnika.Text = "Popis korisnika u grupi " + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                DbDataReader dr;
                dr = klasa_upita.DohvatiKorisnikeNaGrupi(id,kategorija,dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                DataTable dt2 = new DataTable();
                dt2.Load(dr);
                dataGridView2.DataSource = dt2;
                dr.Close();
                dr.Dispose();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forme.frmDodajUcenikaUgrupu dodajUgrupu = 
                new forme.frmDodajUcenikaUgrupu(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            dodajUgrupu.ShowDialog();
            DohvatiGrupe(kategorija, id);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "A";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "B";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void bEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "B+E";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void c1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "C1";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void c1EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "C1+E";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "C";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void cEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "C+E";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kategorija = "M";
            lblNaslovB.Text = "Kategorija " + kategorija;
            DohvatiGrupe(kategorija, id);
        }

        private void btnMaterijali_Click(object sender, EventArgs e)
        {
          forme.Materijali materijali= new Materijali(kategorija,false);
            materijali.ShowDialog();
        }

        private void formUciteljKategorijaA_Load(object sender, EventArgs e)
        {

        }
    }
}
