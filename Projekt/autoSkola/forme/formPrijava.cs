using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using autoSkola.forme;

namespace autoSkola
{
    public partial class formPrijava : Form

    {////

        public data podaci;

        public formPrijava()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            
           if (KorisnikPrijava.verificirajKorisnika(txtKorIme.Text, txtLozinka.Text, ref podaci))
           {
               this.Hide();
           }

        }

        private void formPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
