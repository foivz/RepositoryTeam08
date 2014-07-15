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
    public partial class frmDodajUcenikaUgrupu : Form
    {
        Upiti klasa_upita = new Upiti();
        string id_grupe;

        public frmDodajUcenikaUgrupu(string id_grupe)
        {
            InitializeComponent();
            DbDataReader dr = klasa_upita.DohvatiSveKorisnike();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
            this.id_grupe = id_grupe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(klasa_upita.provjeriDuplikatUcenikaUgrupi(
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(),id_grupe)==true){
                    MessageBox.Show("Ovaj učenik već postoji u grupi!");
                }
                else{
                    klasa_upita.DodajKorisnikaUGrupu(
                        id_grupe, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Učenik uspješno dodan u grupu!");
                }
            }
            catch
            {
                MessageBox.Show("Učenik nije uspješno dodan u grupu!");
            }
        }
    }
}
