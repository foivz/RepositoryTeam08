using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola.forme
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void evidencijaOsobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDKorisnika crud = new frmCRUDKorisnika();
            crud.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {

        }
    }
}
