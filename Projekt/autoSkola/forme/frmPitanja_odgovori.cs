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
    public partial class frmPitanja_odgovori : Form
    {
        Upiti klasa_upita=new Upiti();
        public frmPitanja_odgovori(string cjelina)
        {
            InitializeComponent();
            this.CenterToParent();
            DbDataReader dr = klasa_upita.DohvatiPitanja(cjelina);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();

            dr.Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // pictureBox1=new PictureBox();
            int indeks_selektiranog = dataGridView1.CurrentCell.RowIndex;

            BackgroundWorker bw = new BackgroundWorker();


            DbDataReader citac =
                klasa_upita.DohvatiSliku(dataGridView1.Rows[indeks_selektiranog].Cells[0].Value.ToString());

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
            try
            {
                DbDataReader dr =
                    klasa_upita.DohvatiOdgovore(
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
                dr.Close();
                dr.Dispose();
            }
            catch{}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
