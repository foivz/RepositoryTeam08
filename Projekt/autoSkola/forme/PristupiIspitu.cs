using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola.forme
{
    public partial class PristupiIspitu : Form
    {
        private string id_korisnik;
        private int test;
        private int nova;
        Upiti klasa_upita = new Upiti();

        public PristupiIspitu(int test,string id_korisnik)
        {
            InitializeComponent();
            this.id_korisnik = id_korisnik;
            DbDataReader dr = klasa_upita.DohvatiPitanjaIspita(id_korisnik, test.ToString());
            this.nova = test;
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnZavrši_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DbDataReader dr =
                    klasa_upita.DohvatiOdgovoreIspita(
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),nova.ToString(),id_korisnik);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
                dr.Close();
                dr.Dispose();
                DbDataReader citac =
                       klasa_upita.DohvatiSliku(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image = null;
                }

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                while (citac.Read())
                {
                    if (citac[0].ToString() == "")
                    {

                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream((byte[])citac[0]);
                        byte[] test = (byte[])citac[0];
                        // MessageBox.Show(test.Length.ToString());
                        Image im = Image.FromStream(ms);
                        pictureBox1.Image = im;

                    }
                }

                citac.Close();
                citac.Dispose();

            }
            catch
            {
                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PristupiIspitu_Load(object sender, EventArgs e)
        {

        }
    }
}
