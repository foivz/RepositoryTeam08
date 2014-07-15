using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola
{
    public partial class formUciteljNMaterijal : Form
    {
        public DialogResult result;
        public data dt;
        public OpenFileDialog openFileDialog123;
        public class Language
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public formUciteljNMaterijal(data data)
        {
            dt = data;
            InitializeComponent();
            var dataSource = new List<Language>();
            for (int i = 0; i < dt.Cjelina.Count; i++)
            {
                dataSource.Add(new Language() { Name = dt.Cjelina[i].naziv, Value = dt.Cjelina[i].ID_cjelina.ToString() });
            }
            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog123 = new OpenFileDialog();
            result = openFileDialog123.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ovdje citamo url koji cemo preseliti u pi\materijali i pozvati setTo
            updateFTP ufp = new updateFTP(dt);
            ufp.preuzmiLokalno("materijal",result, this);
            this.Close();
        }
    }
}
