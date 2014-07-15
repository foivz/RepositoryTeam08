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
    public partial class frmOtvoriRok : Form
    {
        Upiti klasa_upita=new Upiti();
        private string id_ispit;
        public frmOtvoriRok(string id_grupe, string id_ispit,bool nacin)
        {
            InitializeComponent();
            this.CenterToParent();
            if (nacin == false) btnZapočniRok.Visible = false;
            this.id_ispit = id_ispit;
            DbDataReader dr = klasa_upita.DohvatiSvaPitanja(id_grupe);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
            GetValue();
        }

        private void btnDodajPitanje_Click(object sender, EventArgs e)
        {
            klasa_upita.DodajPitanjeUIspit(dataGridView1[dataGridView1.SelectedCells[0].ColumnIndex, dataGridView1.SelectedCells[0].RowIndex].Value.ToString(),id_ispit);
           
            GetValue();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //
 
        }

        private void GetValue()
        {
            DbDataReader dr = klasa_upita.DohvatiPitanjaIspita(id_ispit);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        private void btnObrisiPitanje_Click(object sender, EventArgs e)
        {
            try
            {
                klasa_upita.ObrisiPitanjeIzIspita(dataGridView2[dataGridView2.SelectedCells[0].ColumnIndex, dataGridView2.SelectedCells[0].RowIndex].Value.ToString(), id_ispit);
                MessageBox.Show("Uspješno obrisano pitanje");
                GetValue();
            }
            catch
            {
                
            }
        }

        private void btnZapočniRok_Click(object sender, EventArgs e)
        {
            List<string> lista_pitanja = new List<string>();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                lista_pitanja.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }
            klasa_upita.ZapocniRok(id_ispit,lista_pitanja);
            this.Close();
        }
    }
}
