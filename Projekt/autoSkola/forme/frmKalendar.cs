using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace autoSkola.forme
{
    public partial class frmKalendar : Form
    {
        Upiti klasa_upita = new Upiti();
        string id;
        public frmKalendar(string id)
        {
            InitializeComponent();
            this.id = id;
            this.CenterToParent();
            DbDataReader dr = klasa_upita.DohvatiDogadjaje(id);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
            dr = klasa_upita.DohvatiRokove(id);
            DataTable dt2 = new DataTable();
            dt2.Load(dr);
            dataGridView2.DataSource = dt2;
            dr.Close();
            dr.Dispose();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {

            }
        }

        private void frmKalendar_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //monthCalendar1.SelectionRange.Start.ToString()
            textBox1.Text = "";
            DbDataReader dr = klasa_upita.DohvatiRokovePremaDatumu(monthCalendar1.SelectionRange.Start.ToString(),id);
            while (dr.Read())
            {
                textBox1.Text += "ISPIT GRUPA " + dr[1].ToString();
                textBox1.Text += Environment.NewLine;
                textBox1.Text += dr[3].ToString() + Environment.NewLine + Environment.NewLine;
            }
            dr.Close();
            dr.Dispose();
            dr = klasa_upita.DohvatiDogadjajePremaDatumu(monthCalendar1.SelectionRange.Start.ToString(), id);
            while (dr.Read())
            {

                textBox1.Text += "PREDAVANJE GRUPA " + dr[4].ToString();
                textBox1.Text += Environment.NewLine;
                textBox1.Text += dr[2].ToString() + Environment.NewLine + Environment.NewLine;
            }
            dr.Close();
            dr.Dispose();
        }
    }
}
