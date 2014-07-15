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
    public partial class formPostavke : Form
    {
        private data podaci = null;
        public formPostavke()
        {
            InitializeComponent();
        }
        public formPostavke(data Podaci)
        {
            InitializeComponent();
            podaci = Podaci;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formUcenikPostavke_Load(object sender, EventArgs e)
        {
            MessageBox.Show(podaci.AktivniKorisnikID.ToString());
            txtKorIme.Text = podaci.Korisnik[podaci.AktivniKorisnikID].korisnicko_ime.ToString();
            txtIme.Text = podaci.Korisnik[podaci.AktivniKorisnikID].ime.ToString();
            txtPrezime.Text = podaci.Korisnik[podaci.AktivniKorisnikID].prezime.ToString();
            txtMail.Text = podaci.Korisnik[podaci.AktivniKorisnikID].mail.ToString();
            txtOIB.Text = podaci.Korisnik[podaci.AktivniKorisnikID].oib.ToString();
            txtTelefon.Text = podaci.Korisnik[podaci.AktivniKorisnikID].telefon.ToString();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            List<string> greske = new List<string>();
            
            if (txtIme.Text != "")
                podaci.Korisnik[podaci.AktivniKorisnikID].ime = txtIme.Text;
            else
                greske.Add("ime");

            if (txtPrezime.Text != "")
                podaci.Korisnik[podaci.AktivniKorisnikID].prezime = txtPrezime.Text;
            else 
                greske.Add("prezime");

            if (txtMail.Text != "")
                podaci.Korisnik[podaci.AktivniKorisnikID].mail = txtMail.Text;
            else
                greske.Add("e-mail adresa");

            if (txtOIB.Text != "")
                podaci.Korisnik[podaci.AktivniKorisnikID].oib = txtOIB.Text;
            else
                greske.Add("OIB");
            if (txtTelefon.Text != "")
                podaci.Korisnik[podaci.AktivniKorisnikID].telefon = txtTelefon.Text;
            else
                greske.Add("telefon");

            int brGresaka = greske.Count();
            if (brGresaka != 0)
            {
                string greskeIspis = "Sljedeći podaci su krivo uneseni: ";
                for (int i = 0; i < brGresaka; i++)
                {
                    greskeIspis += greske[i];
                    if (brGresaka > 0 && i < brGresaka - 1)
                        greskeIspis += ", ";
                    if (i == brGresaka - 1)
                        greskeIspis += ".";
                }

                MessageBox.Show(greskeIspis, "AutoŠkola.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Podaci uspješno ažurirani!", "AutoŠkola.NET", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            formLozinkaPromjena frmLozinkaPrm = new formLozinkaPromjena(podaci);
            frmLozinkaPrm.ShowDialog();
        }
    }
}
