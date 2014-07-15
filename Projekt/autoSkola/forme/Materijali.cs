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
    public partial class Materijali : Form
    {
        Upiti klasa_upita=new Upiti();
        private string kategorija;
        private bool korisnik;
        public Materijali(string kategorija)
        {
            InitializeComponent();
            this.kategorija = kategorija;
            this.CenterToParent();
            DohvatiCjeline(kategorija);
        }

        public Materijali(string kategorija,bool korisnik)
        {
            InitializeComponent();
            this.kategorija = kategorija;
            this.korisnik = korisnik;
            this.CenterToParent();
            if (korisnik == true)
            {
                groupBox1.Visible = false;
                txtNapomena.Visible = false;
                txtNaziv.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            if(korisnik==true) btnViše.Location=new Point(btnViše.Location.X,btnViše.Location.Y-300);
            DohvatiCjeline(kategorija);
        }

        private void DohvatiCjeline(string kategorija)
        {
            DbDataReader dr = klasa_upita.DohvatiCjelinePredmeta(kategorija);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            btnDodaj.BackColor = Color.LimeGreen;
            btnObriši.BackColor = btnPotvrdi.BackColor;
            btnUredi.BackColor = btnPotvrdi.BackColor;
            txtNapomena.Text = "";
            txtNaziv.Text = "";
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnObriši.BackColor = btnPotvrdi.BackColor;
            btnUredi.BackColor = Color.LimeGreen;
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnObriši.BackColor = Color.LimeGreen;
            btnUredi.BackColor = btnPotvrdi.BackColor;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (btnObriši.BackColor == Color.LimeGreen)
            {
                try
                {
                    klasa_upita.ObrisiCjelinu(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Uspješno obrisana cjelina!");
                    DohvatiCjeline(kategorija);
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisano!");
                }
            }
            else if (btnDodaj.BackColor == Color.LimeGreen)
            {
               
                    klasa_upita.DodajCjelinu(txtNaziv.Text,txtNapomena.Text,kategorija);
                    MessageBox.Show("Uspješno dodana cjelina");
                    DohvatiCjeline(kategorija);

            }
            else if (btnUredi.BackColor == Color.LimeGreen)
            {

                try
                {
                    klasa_upita.AzurirajCjelinu(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),txtNaziv.Text,txtNapomena.Text);
                    MessageBox.Show("Uspješno ažurirani podaci o cjelini");
                    DohvatiCjeline(kategorija);
                }
                catch (Exception)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati jednu od opcija potvrdi/uredi/briši!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtNaziv.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtNapomena.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }

        private void btnViše_Click(object sender, EventArgs e)
        {
            if (korisnik == false)
            {
                frmPredmeti predmeti =
                    new frmPredmeti(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                predmeti.ShowDialog();
            }
            else
            {
                frmPitanja_odgovori forma = new frmPitanja_odgovori(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                forma.ShowDialog();
            }
        }
    }
}
