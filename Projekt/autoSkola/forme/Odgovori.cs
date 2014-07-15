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
    public partial class Odgovori : Form
    {
        private string id_predmet;
        Upiti klasa_upita=new Upiti();

        public Odgovori(string id_predmet,string tekst)
        {
            InitializeComponent();
            this.id_predmet = id_predmet;
            lblPitanje.Text = tekst;
            DohvatiOdgovore();
        }

        private void DohvatiOdgovore()
        {
              DbDataReader dr = klasa_upita.DohvatiOdgovore(id_predmet);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnObrisi.BackColor = btnPotvrdi.BackColor;
            btnUredi.BackColor = Color.LimeGreen;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            btnUredi.BackColor = btnPotvrdi.BackColor;
            btnObrisi.BackColor = Color.LimeGreen;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            txtOdgovor.Text = "";
            chkTocno.Checked = false;
            btnUredi.BackColor = btnPotvrdi.BackColor;
            btnDodaj.BackColor = Color.LimeGreen;
            btnObrisi.BackColor = btnPotvrdi.BackColor;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 == 4)
            {
                MessageBox.Show("Maksimalno 4 odgovora po pitanju!");
            }
            else
            {
                if (btnDodaj.BackColor == Color.LimeGreen)
                {
                    try
                    {
                        if (chkTocno.Checked == true)
                        {
                            klasa_upita.DodajOdgovor(id_predmet, txtOdgovor.Text,"1" );
                        }
                        else
                        {
                            klasa_upita.DodajOdgovor(id_predmet,txtOdgovor.Text,"0");
                        }
                        MessageBox.Show("Uspješno dodan odgovor");
                        DohvatiOdgovore();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nije uspješno dodan odgovor");
                    }
                }
                else if (btnObrisi.BackColor == Color.LimeGreen)
                {
                    try
                    {
                        klasa_upita.ObrisiOdgovor(id_predmet);
                        MessageBox.Show("Uspješno obrisan odgovor");
                        DohvatiOdgovore();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nije uspješno obrisan odgovor");
                    }
                }
                else if (btnUredi.BackColor == Color.LimeGreen)
                {
                    try
                    {
                        if (chkTocno.Checked)
                        {
                            klasa_upita.UrediOdgovor(
                                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                                txtOdgovor.Text, "1");
                        }
                        else
                        {
                            klasa_upita.UrediOdgovor(
                                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                                txtOdgovor.Text, "0");
                        }
                    MessageBox.Show("Uspješno ažuriran odgovor");
                        DohvatiOdgovore();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nije uspješno ažuriran odgovor");
                    }
                }
                else
                {

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtOdgovor.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                //MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString());
                if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString() == "True")
                {
                    chkTocno.Checked = true;
                }
                else
                {
                    chkTocno.Checked = false;
                }
            }
            catch (Exception)
            {
                
            }
            
        }
    }
}
