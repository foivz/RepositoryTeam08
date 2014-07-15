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

namespace autoSkola
{
    public partial class formUcenikEvidencija : Form
    {

        Upiti klasa_upita = new Upiti();
        public formUcenikEvidencija()
        {
            InitializeComponent();
        }
        data podaci = null;
        int cjelinaID = 0;
        public formUcenikEvidencija(data Podaci, int ID_cjelina)
        {
            InitializeComponent();
            podaci = Podaci;
            cjelinaID = ID_cjelina;
        }

        string id_dogadaj;
        public formUcenikEvidencija(string id_dogadaj,string datum)
        {
            InitializeComponent();
            DateTime dt = Convert.ToDateTime(datum);

            lblDolazak.Text = "Evidencija dolazaka učenika na dan "+dt.ToShortDateString();
            this.id_dogadaj = id_dogadaj;
            DohvatiKorisnikeNaDogadaju();
        }

        private void DohvatiKorisnikeNaDogadaju()
        {
            DbDataReader dr = klasa_upita.DohvatiKorisnikeNaDogadaju(id_dogadaj);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void btnEvidencijaOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formUcenikEvidencija_Load(object sender, EventArgs e)
        {
            #region obrisano
            //int IDkreirao = 0;
                   //string cjelinaNaziv = "";
                   //for (int j = 0; j < podaci.Cjelina.Count; j++)
                   //{
                   //    if (podaci.Cjelina[j].ID_cjelina == cjelinaID)
                   //    {
                   //        cjelinaNaziv = podaci.Cjelina[j].naziv;
                   //        break;
                   //    }
                   //}
                   ////lblNaslov
                   //lblNaslov.Text += " " + cjelinaNaziv;

                   //for (int j = 0; j < podaci.Grupa.Count; j++)
                   //{
                   //    if (podaci.Grupa[j].ID_cjelina == cjelinaID)
                   //    {
                   //        IDkreirao = podaci.Grupa[j].predavac;
                   //    }
                   //}

                   ////lblDatum i lblDolazak
                   //int lokY = 53;
                   //for (int j = 0; j < podaci.Dogadjaj.Count; j++)
                   //{
                   //    if (podaci.Dogadjaj[j].kreirao == IDkreirao)
                   //    {
                   //        Label lblDatum = new Label();
                   //        lblDatum.Text = podaci.Dogadjaj[j].datum.ToShortDateString();
                   //        lblDatum.Location = new Point(12, lokY);
                   //        lblDatum.Size = new Size(64, 13);
                           
                   //        this.Controls.Add(lblDatum);

                   //        Label lblDolazak = new Label();
                   //        lblDolazak.Text = "Odsutan";
                   //        lblDolazak.ForeColor = Color.DarkRed;

                   //        for (int k = 0; k < podaci.Korisnik_dogadjaj.Count; k++)
                   //        {
                   //            if (podaci.Korisnik_dogadjaj[k].ID_dogadjaj == podaci.Dogadjaj[j].ID_dogadjaj)
                   //            {
                   //                if (podaci.Korisnik_dogadjaj[k].dolazak)
                   //                {
                   //                    lblDolazak.Text = "Prisutan";
                   //                    lblDolazak.ForeColor = Color.DarkGreen;
                   //                }
                   //                else break;
                   //            }
                   //        }

                   //        lblDolazak.Location = new Point(96, lokY);
                   //        lblDolazak.Size = new Size(64, 13);
                   //        this.Controls.Add(lblDolazak);
                   //        lokY += 22;
                           
                   //    }
            //}
            #endregion
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                e.Cancel = true;
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    klasa_upita.UrediKorisnikaNaDogadaju(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                        id_dogadaj, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());
                }
                MessageBox.Show("Uspješno ažurirani dolasci korisnika!");
                DohvatiKorisnikeNaDogadaju();
            }
            catch
            {
                MessageBox.Show("Nisu uspješno ažurirani dolasci korisnika!");
            }
        }
    }
}
