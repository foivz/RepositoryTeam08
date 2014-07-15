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
    public partial class formLozinkaPromjena : Form
    {
        data podaci = null;
        public formLozinkaPromjena()
        {
            InitializeComponent();
        }
        public formLozinkaPromjena(data Podaci)
        {
            InitializeComponent();
            podaci = Podaci;
        }

        private void formLozinkaPromjena_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOdbaci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if ( txtStara.Text != podaci.Korisnik[0].lozinka.TrimEnd(new char[] { ' ' }) )
                MessageBox.Show("Stara lozinka je neispravna!", "AutoŠkola.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtNova.Text != txtNova2.Text)
                    MessageBox.Show("Nove lozinke se ne podudaraju!", "AutoŠkola.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    podaci.Korisnik[0].lozinka = txtNova.Text;
                    MessageBox.Show("Lozinka ažurirana!","AutoŠkola.NET",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }
    }
}
