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
using System.IO;
namespace autoSkola.forme
{
    public partial class frmPredmeti : Form
    {
        Upiti klasa_upita=new Upiti();
        private string cjelina;
        public frmPredmeti(string cjelina)
        {
            InitializeComponent();
            this.CenterToParent();
            this.cjelina = cjelina;
            GetValue(cjelina);
        }

        private void GetValue(string cjelina)
        {
            DbDataReader dr = klasa_upita.DohvatiPitanja(cjelina);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
    
            dr.Dispose();
        }
        

        private void frmPredmeti_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image.Dispose();
           
           // pictureBox1=new PictureBox();
            int indeks_selektiranog = dataGridView1.CurrentCell.RowIndex;
            txtBodovi.Text = dataGridView1.Rows[indeks_selektiranog].Cells[2].Value.ToString();
            txtPitanja.Text = dataGridView1.Rows[indeks_selektiranog].Cells[1].Value.ToString();
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
                   MemoryStream ms =new MemoryStream((byte[])citac[0]);
                    byte[] test = (byte[]) citac[0];
                   // MessageBox.Show(test.Length.ToString());
                    Image im = Image.FromStream(ms);
                    pictureBox1.Image = im;
                   
                }
            }

            citac.Close();
            citac.Dispose();

            

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            btnObrisi.BackColor = Color.LimeGreen;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnUredi.BackColor = btnPotvrdi.BackColor;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            txtBodovi.Text = "";
            txtPitanja.Text = "";
            chkSlika.Checked = false;
            btnDodaj.BackColor = Color.LimeGreen;
            btnObrisi.BackColor = btnPotvrdi.BackColor;
            btnUredi.BackColor = btnPotvrdi.BackColor;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnUredi.BackColor = Color.LimeGreen;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnObrisi.BackColor = btnPotvrdi.BackColor;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (btnObrisi.BackColor == Color.LimeGreen)
            {

                try
                {
                    klasa_upita.ObrisiPitanje(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Uspješno obrisano pitanje");
                    GetValue(cjelina);
                }
                catch (Exception)
                {
                }
            }
            else if (btnDodaj.BackColor == Color.LimeGreen)
            {
                try
                {
                   if (chkSlika.Checked)
                   {
                       klasa_upita.DodajPitanjeSaSlikom(btnBrowse.Text,cjelina,txtPitanja.Text,txtBodovi.Text);
                   }
                   else
                   {
                       klasa_upita.DodajPitanjeBezSlike(cjelina,txtPitanja.Text,txtBodovi.Text);
                   }
                    MessageBox.Show("Uspješno dodano pitanje");
                    GetValue(cjelina);
                }
                catch (Exception)
                {
                    
                }
            }
            else if (btnUredi.BackColor == Color.LimeGreen)
            {
                try
                {
                    MessageBox.Show("Uspješno uređeno pitanje");
                    GetValue(cjelina);
                }
                catch (Exception)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati jednu od ponuđenih opcija dodaj/uredi/briši");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dijalog=new OpenFileDialog();
            if (dijalog.ShowDialog() == DialogResult.OK)
            {
                btnBrowse.Text = dijalog.FileName;
                pictureBox1.ImageLocation = dijalog.FileName;
            }
        }

        private void btnOdgovori_Click(object sender, EventArgs e)
        {
            forme.Odgovori odgovori=new Odgovori(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
            odgovori.ShowDialog();
        }
    }
}
