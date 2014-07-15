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
    public partial class frmIspitniRok : Form
    {Upiti klasa_upita=new Upiti();

        private string id_grupa;
        public frmIspitniRok(string id_grupa)
        {
            InitializeComponent();
            this.id_grupa = id_grupa;
        }

        private void frmIspitniRok_Load(object sender, EventArgs e)
        {
            GetValue();
        }

        private void GetValue()
        {
            DbDataReader dr = klasa_upita.dohvatiRokZaGrupu(id_grupa);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnUredi.BackColor = Color.LawnGreen;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnBrisi.BackColor = btnPotvrdi.BackColor;

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            btnBrisi.BackColor = Color.LawnGreen;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnUredi.BackColor = btnPotvrdi.BackColor;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            btnDodaj.BackColor = Color.LawnGreen;
            btnUredi.BackColor = btnPotvrdi.BackColor;
            btnBrisi.BackColor = btnPotvrdi.BackColor;
            txtNapomena.Text = "";
            
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (btnBrisi.BackColor == Color.LawnGreen)
            {
                try
                {
                    klasa_upita.ObrisiRok(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Uspješno obrisan rok");
                    GetValue();

                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisan rok!");
                }
            }
            else if (btnDodaj.BackColor == Color.LawnGreen)
            {
                try
                {
                    klasa_upita.DodajRok(monthCalendar1.SelectionRange.Start.ToString(),txtNapomena.Text,id_grupa);
                    MessageBox.Show("Uspješno dodan rok");
                    GetValue();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije uspješno dodan rok!");
                    throw;
                }

            }
            else if (btnUredi.BackColor == Color.LawnGreen)
            {
                try
                {
                    klasa_upita.UrediRok(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(), monthCalendar1.SelectionRange.Start.ToString(),txtNapomena.Text);
                    MessageBox.Show("Uspješno uređen rok");
                    GetValue();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije uspješno ažuriran rok!");
                    
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati jednu od opcija uredi/briši/dodaj!");
            }
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            frmOtvoriRok otvori_rok=new frmOtvoriRok(id_grupa,dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString().TrimEnd(new char[]{' '}),true);
            otvori_rok.ShowDialog();
            GetValue();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnZatvori.Visible = true;
                btnOtvori.Visible = true;
                btnPromijeniPitanjaRoka.Visible = true;
                if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString() == "True")
                {
                    btnZatvori.Visible = false;
                    btnOtvori.Visible = false;
                    btnPromijeniPitanjaRoka.Visible = false;
                }
                else
                {
                    if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString() == "True")
                    {
                        btnZatvori.Visible = true;
                        btnOtvori.Visible = false;
                        btnPromijeniPitanjaRoka.Visible = false;
                    }
                    else
                    {
                        btnZatvori.Visible = false;
                        btnOtvori.Visible = true;
                        btnPromijeniPitanjaRoka.Visible = true;
                    }

                }
                monthCalendar1.SetDate(
                        Convert.ToDateTime(
                            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()))
                ;
                txtNapomena.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            }
            catch{}
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            klasa_upita.zatvoriRok(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            GetValue();

        }

        private void btnPromijeniPitanjaRoka_Click(object sender, EventArgs e)
        {
            frmOtvoriRok otvori_rok = new frmOtvoriRok(id_grupa, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(), false);
            otvori_rok.ShowDialog();
            GetValue();
        }
    }
}
