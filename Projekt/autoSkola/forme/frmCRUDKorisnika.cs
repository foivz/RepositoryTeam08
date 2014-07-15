using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace autoSkola.forme
{
    public partial class frmCRUDKorisnika : Form
    {
        Upiti klasa_upita = new Upiti();

        /// <summary>
        /// Centrira se forma i dohvaćaju se podaci u datagrid
        /// </summary>
        public frmCRUDKorisnika()
        {
            InitializeComponent();
            this.CenterToParent();
            DohvatiKorisnikeUDatagrid();
            cmbTip.Items.Add("100");
            cmbTip.Items.Add("101");
            cmbTip.Items.Add("102");
            cmbTip.Items.Add("103");
            cmbTip.SelectedIndex = 0;
        }

        /// <summary>
        /// Dohvaćaju se korisnici uz pomoć sql upita iz klase Upiti i mijenja se izvor podataka datagrida
        /// </summary>
        private void DohvatiKorisnikeUDatagrid()
        {
            DbDataReader dr = klasa_upita.DohvatiSveKorisnike();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            dr.Dispose();
        }

        /// <summary>
        /// Ukoliko se klikne na gumb obriši, prvo se prazne kontrole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            btnUredi.BackColor = btnPotvrdi.BackColor;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnObrisi.BackColor = Color.LawnGreen;
            IsprazniKontrole();
        }

        /// <summary>
        /// Ukoliko se klikne na gumb potvrdi, prvo se provjeri koja je opcija odabrana, preko boje gumba
        /// Ukoliko je odabrano briši, briše se korisnik i refresha se datagrid
        /// Ukoliko je odabrano uredi, moraju se prvo provjeriti jesu li uspješno upisani podaci pa se ide na uređivanje korisnika
        /// //Ukoliko je odabrano dodaj novi onda se također provjeravaju jesu li uspješno upisani podaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (btnObrisi.BackColor == SystemColors.ButtonHighlight)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati korisnika", "Brisanje korisnika", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string id_brisanog=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        klasa_upita.ObrisiKorisnika(id_brisanog);
                        MessageBox.Show("Uspješno ste obrisali korisnika");
                        DohvatiKorisnikeUDatagrid();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                catch
                {
                    MessageBox.Show("Nije uspješno");
                }
            }
            else if (btnDodaj.BackColor == Color.LawnGreen)
            {
                if(ProvjeriKontrole()==false)
                {
                    try
                    {
                        if(ProvjeriDuplikate()==false)
                        {
                            klasa_upita.DodajKorisnika(txtIMe.Text, txtPrezime.Text, txtUsername.Text,
                                txtLozinka.Text, txtOIB.Text, txtMail.Text, txtTelefon.Text, cmbTip.Text);
                            MessageBox.Show("Uspješno ste dodali korisnika");
                            DohvatiKorisnikeUDatagrid();
                            IsprazniKontrole();
                        }               
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Nije uspješno dodan korisnik, razlog: "+ex.ToString());
                    }
                }
            }
            else if (btnUredi.BackColor == Color.LawnGreen)
            {
                if (ProvjeriKontrole() == false)
                {
                    try
                    {
                        if (ProvjeriDuplikate() == false)
                        {
                            string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                            klasa_upita.UrediKorisnika(id, txtIMe.Text, txtPrezime.Text, txtUsername.Text,
                                txtLozinka.Text, txtOIB.Text, txtMail.Text, txtTelefon.Text, cmbTip.Text);
                            DohvatiKorisnikeUDatagrid();
                            NapuniKontrole();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Nisu uspješno ažurirani podaci o korisniku!"+ex.ToString());
                    }
                }
            }
            else{
                MessageBox.Show("Niste odabrali niti jednu opciju uredi/dodaj/obriši!");
            }
        }

        /// <summary>
        /// Provjerava duplikate korisnickog imena i Oiba
        /// </summary>
        /// <returns></returns>
        private bool ProvjeriDuplikate()
        {
            bool isti_oib = false;
            bool isti_user = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string za_usporedbu_user = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string za_usporedbu_oib = dataGridView1.Rows[i].Cells[5].Value.ToString();
                int duljina = 0;
                for (int j = 0; j < za_usporedbu_user.Length; j++)
                {
                    if (za_usporedbu_user[j] != ' ') duljina++;
                    else j = 30;
                }
                if (duljina == txtUsername.Text.Length)
                {
                    string novi = "";
                    for (int j = 0; j < duljina; j++)
                    {
                        novi += za_usporedbu_user[j].ToString();
                    }
                    if (novi == txtUsername.Text)
                    {
                        isti_user = true;
                    }
                }
                duljina = 0;
                for (int j = 0; j < za_usporedbu_oib.Length; j++)
                {
                    if (za_usporedbu_oib[j] != ' ') duljina++;
                    else j = 30;
                }
                if (duljina == txtOIB.Text.Length)
                {
                    string novi = "";
                    for (int j = 0; j < duljina; j++)
                    {
                        novi += za_usporedbu_oib[j].ToString();
                    }
                    if (novi == txtOIB.Text)
                    {
                        isti_oib = true;
                    }
                }
            }
            if (isti_user == true)
            {
                MessageBox.Show("Duplikat korisničkog imena !");
                return true;
            }
            else if (isti_oib == true)
            {
                MessageBox.Show("Duplikat OIB-a!");
                return true;
            }
            return false;
        }

        /// <summary>
        /// provjerava jesu li uspjesno uneseni podaci u kontrole
        /// </summary>
        /// <returns></returns>
        private bool ProvjeriKontrole()
        {
            if (txtIMe.Text == "")
            {
                MessageBox.Show("Niste unijeli ime");
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku");
            }
            else if (txtMail.Text == "")
            {
                MessageBox.Show("Niste unijeli Email");
            }
            else if (txtOIB.Text == "")
            {
                MessageBox.Show("Niste unijeli OIB");
            }
            else if (txtPrezime.Text == "")
            {
                MessageBox.Show("Niste unijeli prezime");
            }
            else if (txtTelefon.Text == "")
            {
                MessageBox.Show("Niste unijeli telefon");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Niste unijeli username");
            }
            else if (txtOIB.Text.Length < 11)
            {
                MessageBox.Show("OIB mora imati 11 znakova");
            }
            else return false;
            return true;
        }

        /// <summary>
        /// Pune se kontrole sa odabranim zaposlenikom iz datagrida
        /// </summary>
        private void NapuniKontrole()
        {
            try
            {
                int pozicija_odabranog = dataGridView1.CurrentCell.RowIndex;
                txtIMe.Text = dataGridView1.Rows[pozicija_odabranog].Cells[1].Value.ToString();
                txtPrezime.Text = dataGridView1.Rows[pozicija_odabranog].Cells[2].Value.ToString();
                txtUsername.Text = dataGridView1.Rows[pozicija_odabranog].Cells[3].Value.ToString();
                txtLozinka.Text = dataGridView1.Rows[pozicija_odabranog].Cells[4].Value.ToString();
                txtOIB.Text = dataGridView1.Rows[pozicija_odabranog].Cells[5].Value.ToString();
                txtMail.Text = dataGridView1.Rows[pozicija_odabranog].Cells[6].Value.ToString();
                txtTelefon.Text = dataGridView1.Rows[pozicija_odabranog].Cells[7].Value.ToString();
                if (dataGridView1.Rows[pozicija_odabranog].Cells[8].Value.ToString() == "100")
                {
                    cmbTip.SelectedIndex = 0;
                }
                else if (dataGridView1.Rows[pozicija_odabranog].Cells[8].Value.ToString() == "101")
                {
                    cmbTip.SelectedIndex = 1;
                }
                else if (dataGridView1.Rows[pozicija_odabranog].Cells[8].Value.ToString() == "102")
                {
                    cmbTip.SelectedIndex = 2;
                }
                else
                {
                    cmbTip.SelectedIndex = 3;
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Prazne se svi tekst boxovi
        /// </summary>
        private void IsprazniKontrole()
        {
            txtIMe.Text = "";
            txtPrezime.Text = "";
            txtTelefon.Text = "";
            txtUsername.Text = "";
            txtLozinka.Text = "";
            txtMail.Text = "";
            txtOIB.Text = "";
            cmbTip.SelectedIndex = 0;
        }

        /// <summary>
        /// Kad se odabere gumb dodaj, mijenja se boja gumba i prazne se text boxovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            btnUredi.BackColor = btnPotvrdi.BackColor;
            btnDodaj.BackColor = Color.LawnGreen;
            btnObrisi.BackColor = btnPotvrdi.BackColor;
            IsprazniKontrole();
        }

        /// <summary>
        /// Kad se odabere gumb uredi, mijenja se boja gumba i pune se text boxovi sa podacima o odabranom studentu za uređivanje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnUredi.BackColor = Color.LawnGreen;
            btnDodaj.BackColor = btnPotvrdi.BackColor;
            btnObrisi.BackColor = btnPotvrdi.BackColor;
            NapuniKontrole();
        }

        /// <summary>
        /// Ukoliko se promijenio izbor na datagridu i ukoliko je odabrana kontrola uredi, onda se refreshaju podaci u tekst boxovima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (btnUredi.BackColor== Color.LawnGreen)
            {
                NapuniKontrole();
            }
        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.Text == "100") lblTipK.Text = "Učenik";
            else if (cmbTip.Text == "101") lblTipK.Text = "Predavač";
            else if (cmbTip.Text == "102") lblTipK.Text = "Instruktor";
            else lblTipK.Text = "Admin";
        }
    }
}
