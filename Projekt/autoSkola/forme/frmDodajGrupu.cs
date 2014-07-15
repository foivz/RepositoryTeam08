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

namespace autoSkola.forme
{
    public partial class frmDodajGrupu : Form
    {
        Upiti klasa_upita = new Upiti();
        string id;
        string kategorija;
        string grupa_id;

        public frmDodajGrupu(string id, string kategorija)
        {
            InitializeComponent();
            txtPredavac.Text = klasa_upita.DohvatiImePrezimeKorisnika(id);
            txtPredmet.Text = kategorija;
            this.id = id;
            this.kategorija = kategorija;
        }

        private void cmbPopis_SelectedIndexChanged(object sender, EventArgs e)
        {
            AzurirajPopis();
        }

        private void AzurirajPopis()
        {
            if (cmbPopis.Items.Count == 0) txtDodani.Text = "--";
            else
            {
                txtDodani.Text = "";
                foreach (string x in cmbPopis.Items)
                {
                    txtDodani.Text += x + Environment.NewLine;
                }
            }
        }

        private void btnDodajGrupu_Click(object sender, EventArgs e)
        {
            string id_grupe = "";
            if (chkObavljeno.Checked) { id_grupe=klasa_upita.DodajGrupu(id, kategorija, "1"); }
            else id_grupe=klasa_upita.DodajGrupu(id, kategorija, "0");
            lblGrupa.Text = "GRUPA " + id_grupe;
            grupa_id = id_grupe;
            lblGrupa.BackColor = Color.Red;
            lblOpis.Text = "Grupa je uspješno dodana, još fale korisnici grupe";
            lblOpis.ForeColor = Color.YellowGreen;
            foreach (Control a in this.Controls)
            {
                a.Visible = true;
            }
            DbDataReader dr = klasa_upita.DohvatiSveKorisnike();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
            btnDodajGrupu.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string provjera = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                bool pronadjen = false;
                foreach (string x in cmbPopis.Items)
                {
                    string[] odvojeno = x.Split(' ');
                    if (odvojeno[0] == provjera) pronadjen = true;
                }
                if (pronadjen == true)
                {
                    MessageBox.Show("Duplikat");
                }
                else
                {
                    cmbPopis.Items.Add(provjera + " " + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString() + " " +
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString());
                }
                AzurirajPopis();
                cmbPopis.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                cmbPopis.Items.Remove(cmbPopis.SelectedItem);
                AzurirajPopis();
                cmbPopis.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void btnDodajKorisnikeUgrupu_Click(object sender, EventArgs e)
        {
            if (cmbPopis.Items.Count == 0)
            {
                MessageBox.Show("Nije dodan niti jedan učenik!");
            }
            else
            {
                foreach (string x in cmbPopis.Items)
                {
                    string[] spl = x.Split(' ');
                    klasa_upita.DodajKorisnikaUGrupu(grupa_id, spl[0]);
                }
                MessageBox.Show("Uspješno dodani svi učenici u grupu!");
                this.Close();
            }
        }
    }
}
