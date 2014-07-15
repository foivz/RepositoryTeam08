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
    public partial class frmEvidentirajDogadaj : Form
    {

        Upiti klasa_upita = new Upiti();
        string id_grupe;
        string id_korisnika;

        public frmEvidentirajDogadaj(string id_grupe, string id_korisnika)
        {
            InitializeComponent();
            this.id_grupe = id_grupe;
            this.id_korisnika = id_korisnika;
            lblPopis.Text = "Popis svih događaja za grupu " + id_grupe;
            DohvatiDogadaje(id_grupe);
        }

        private void DohvatiDogadaje(string id_grupe)
        {
            DbDataReader dr = klasa_upita.DohvatiSveDogadaje(id_grupe, id_korisnika);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (btnBrisi.BackColor == Color.LawnGreen)
            {
                try
                {
                     DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati događaj", "Brisanje događaja", 
                   MessageBoxButtons.YesNo);
                     if (dialogResult == DialogResult.Yes)
                     {
                         klasa_upita.ObrisiDogadaj(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                         MessageBox.Show("Uspješno obrisan događaj!");
                         DohvatiDogadaje(id_grupe);
                     }
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisan događaj!");
                }
            }
            else if (btnDodajdogadaj.BackColor == Color.LawnGreen)
            {
                try
                {
                    klasa_upita.DodajDogadaj(id_grupe, id_korisnika, txtNapomena.Text, monthCalendar1.SelectionRange.Start.ToString());
                    MessageBox.Show("Uspješno dodan događaj! Još treba napraviti evidenciju učenika!");
                    DohvatiDogadaje(id_grupe);
                    txtNapomena.Text = "";
                }
                catch
                {
                    MessageBox.Show("Nije uspješno dodan događaj!");
                }
            }
            else if (btnUredi.BackColor == Color.LawnGreen)
            {
                try
                {
                    klasa_upita.DogadajUredi(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(), txtNapomena.Text,
                        monthCalendar1.SelectionRange.Start.ToString());
                    MessageBox.Show("Uspješno ažuriran događaj!");
                    DohvatiDogadaje(id_grupe);
                }
                catch
                {
                    MessageBox.Show("Nije uspješno ažuriran događaj!");
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana niti jedna od ponuđenih opcija uredi/briši/dodaj");
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            btnBrisi.BackColor = Color.LawnGreen;
            btnUredi.BackColor = btnPotvrdi.BackColor;
            btnDodajdogadaj.BackColor = btnPotvrdi.BackColor;

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnUredi.BackColor = Color.LawnGreen;
            btnDodajdogadaj.BackColor = btnPotvrdi.BackColor;
            btnBrisi.BackColor = btnPotvrdi.BackColor;
            DohvatiPodatkeUkontrole();
        }

        private void DohvatiPodatkeUkontrole()
        {
            try
            {
                txtNapomena.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                  monthCalendar1.SetDate(Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()));
            }
            catch
            {

            }
        }

        private void btnDodajdogadaj_Click(object sender, EventArgs e)
        {
            btnDodajdogadaj.BackColor = Color.LawnGreen;
            btnBrisi.BackColor = btnPotvrdi.BackColor;
            btnUredi.BackColor = btnPotvrdi.BackColor;
            monthCalendar1.SetDate(DateTime.Now.Date);
            txtNapomena.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (btnUredi.BackColor == Color.LawnGreen)
            {
                DohvatiPodatkeUkontrole();
            }
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            //try
            {
                formUcenikEvidencija evidencija = new formUcenikEvidencija(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString());
                evidencija.ShowDialog();
            }
            //catch
            {
                //MessageBox.Show("Ne mogu raditi evidenciju učenika za nepostojeći događaj!");
            }
        }
    }
}
