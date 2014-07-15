using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola.forme
{
    public partial class frmUcenik : Form
    {

        Upiti klasa_upita=new Upiti();
        private Thread a;
        private string id;
        private int ispit;
        private int spavaj = 1000;
        public frmUcenik(string id)
        {
            InitializeComponent();
            this.id = id;
            DbDataReader dr = klasa_upita.DohvatiPredmete();
            while (dr.Read())
            {
                cmbKat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            dr.Dispose();
            try
            {
                cmbKat.SelectedIndex = 0;
            }
            catch
            {
            }
            a = new Thread(new ThreadStart(SampleFunction));
            a.Start();
        }
        public void MakniVisible(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(MakniVisible), new object[] { value });
                return;
            }
            btnPristupi.Visible = false;
        }
        public void PrikaziVisible(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(PrikaziVisible), new object[] { value });
                return;
            }
            btnPristupi.Visible = true;
        }
        void SampleFunction()
        {
            // Gets executed on a seperate thread and 
            // doesn't block the UI while sleeping
            for (int i = 0; i < 5; i++)
            {
                  //provjeri je li ispit
               int id_test= klasa_upita.ProvjeriIspit(id);
                if (id_test == 0)
                {
                    MakniVisible("test");
                }

                else
                {
                    ispit = id_test;
                    PrikaziVisible("test");
                }
                //ako je onda visible postavi

                //ako nije makni visible
                Thread.Sleep(30000);
            }
        }
        private void cmbKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbDataReader dr = klasa_upita.DohvatiDogadajeKorisnika(id, cmbKat.Text);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
            dr = klasa_upita.DohvatiIspiteKorisnika(id, cmbKat.Text);
            DataTable dt2 = new DataTable();
            dt2.Load(dr);
            dataGridView2.DataSource = dt2;
            dr.Close();
            dr.Dispose();
            lblPopis.Text = "Popis budućih predavanja za odabranu kategoriju";
            lblrok.Text = "Popis budućih rokova za odabranu kategoriju";
        }

        private void button1_Click(object sender, EventArgs e)
        {a.Abort();
            DbDataReader dr = klasa_upita.DohvatiSveDogadajeKorisnika(id, cmbKat.Text);
            DataTable dt2 = new DataTable();
            dt2.Load(dr);
            dataGridView1.DataSource = dt2;
            dr.Close();
            dr.Dispose();
            lblPopis.Text = "Popis svih predavanja za odabranu kategoriju";
        }

        private void btnBuduciDolasci_Click(object sender, EventArgs e)
        {a.Abort();
            DbDataReader dr = klasa_upita.DohvatiDogadajeKorisnika(id, cmbKat.Text);
            DataTable dt2 = new DataTable();
            dt2.Load(dr);
            dataGridView1.DataSource = dt2;
            dr.Close();
            dr.Dispose();
            lblPopis.Text = "Popis budućih" +
                            " predavanja za odabranu kategoriju";
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {a.Abort();
            DbDataReader dr = klasa_upita.DohvatiSveIspiteKorisnika(id, cmbKat.Text);
            DataTable dt2 = new DataTable();
            dt2.Load(dr);
            dataGridView2.DataSource = dt2;
            dr.Close();
            dr.Dispose();
            lblrok.Text = "Popis svih" +
                            " ispita za odabranu kategoriju";
        }

        private void btnBuduci_Click(object sender, EventArgs e)
        {
            a.Abort();
            DbDataReader dr = klasa_upita.DohvatiIspiteKorisnika(id, cmbKat.Text);
            DataTable dt2 = new DataTable();
            dt2.Load(dr);
            dataGridView2.DataSource = dt2;
            dr.Close();
            dr.Dispose();
            lblrok.Text = "Popis budućih" +
                            " ispita za odabranu kategoriju";
        }

        private void btnMaterijali_Click(object sender, EventArgs e)
        {   a.Abort();
           Materijali forma=new Materijali(cmbKat.Text,true);
            forma.ShowDialog();
        }

        private void btnPristupi_Click(object sender, EventArgs e)
        {
            PristupiIspitu pristupi=new PristupiIspitu(ispit,id);
            a.Abort();
          
            pristupi.ShowDialog();

        }
    }
}
