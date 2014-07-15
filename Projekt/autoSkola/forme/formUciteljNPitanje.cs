using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola
{
    public partial class formUciteljNPitanje : Form
    {
        public formUciteljNPitanje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formUciteljNOdg formUciteljNO = new formUciteljNOdg();
            formUciteljNO.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            formUciteljNPitanje aa = new formUciteljNPitanje();
            aa.Show();
        }
    }
}
