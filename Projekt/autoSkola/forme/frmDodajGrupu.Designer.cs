namespace autoSkola.forme
{
    partial class frmDodajGrupu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPredavac = new System.Windows.Forms.TextBox();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.chkObavljeno = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.txtDodani = new System.Windows.Forms.TextBox();
            this.cmbPopis = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajGrupu = new System.Windows.Forms.Button();
            this.lblPopisSvih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnDodajKorisnikeUgrupu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPredavac
            // 
            this.txtPredavac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPredavac.Location = new System.Drawing.Point(91, 37);
            this.txtPredavac.Name = "txtPredavac";
            this.txtPredavac.ReadOnly = true;
            this.txtPredavac.Size = new System.Drawing.Size(322, 26);
            this.txtPredavac.TabIndex = 0;
            // 
            // txtPredmet
            // 
            this.txtPredmet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPredmet.Location = new System.Drawing.Point(91, 77);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.ReadOnly = true;
            this.txtPredmet.Size = new System.Drawing.Size(100, 26);
            this.txtPredmet.TabIndex = 1;
            // 
            // chkObavljeno
            // 
            this.chkObavljeno.AutoSize = true;
            this.chkObavljeno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkObavljeno.Location = new System.Drawing.Point(215, 79);
            this.chkObavljeno.Name = "chkObavljeno";
            this.chkObavljeno.Size = new System.Drawing.Size(117, 23);
            this.chkObavljeno.TabIndex = 2;
            this.chkObavljeno.Text = "Obavljeni ispiti";
            this.chkObavljeno.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 491);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrupa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrupa.Location = new System.Drawing.Point(206, 9);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(67, 24);
            this.lblGrupa.TabIndex = 4;
            this.lblGrupa.Text = "Grupa";
            // 
            // txtDodani
            // 
            this.txtDodani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDodani.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDodani.Location = new System.Drawing.Point(12, 327);
            this.txtDodani.Multiline = true;
            this.txtDodani.Name = "txtDodani";
            this.txtDodani.ReadOnly = true;
            this.txtDodani.Size = new System.Drawing.Size(344, 361);
            this.txtDodani.TabIndex = 5;
            this.txtDodani.Visible = false;
            // 
            // cmbPopis
            // 
            this.cmbPopis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPopis.FormattingEnabled = true;
            this.cmbPopis.Location = new System.Drawing.Point(12, 197);
            this.cmbPopis.Name = "cmbPopis";
            this.cmbPopis.Size = new System.Drawing.Size(344, 24);
            this.cmbPopis.TabIndex = 6;
            this.cmbPopis.Visible = false;
            this.cmbPopis.SelectedIndexChanged += new System.EventHandler(this.cmbPopis_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(190, 242);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 43);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj učenika u grupu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(79, 243);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(91, 42);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Makni učenika iz grupe";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Visible = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Predmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Predavač";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajGrupu);
            this.groupBox1.Controls.Add(this.txtPredavac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPredmet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkObavljeno);
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma za dodavanje nove grupe";
            // 
            // btnDodajGrupu
            // 
            this.btnDodajGrupu.Location = new System.Drawing.Point(338, 69);
            this.btnDodajGrupu.Name = "btnDodajGrupu";
            this.btnDodajGrupu.Size = new System.Drawing.Size(75, 42);
            this.btnDodajGrupu.TabIndex = 12;
            this.btnDodajGrupu.Text = "Dodaj grupu";
            this.btnDodajGrupu.UseVisualStyleBackColor = true;
            this.btnDodajGrupu.Click += new System.EventHandler(this.btnDodajGrupu_Click);
            // 
            // lblPopisSvih
            // 
            this.lblPopisSvih.AutoSize = true;
            this.lblPopisSvih.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopisSvih.Location = new System.Drawing.Point(427, 170);
            this.lblPopisSvih.Name = "lblPopisSvih";
            this.lblPopisSvih.Size = new System.Drawing.Size(149, 21);
            this.lblPopisSvih.TabIndex = 12;
            this.lblPopisSvih.Text = "Popis svih učenika";
            this.lblPopisSvih.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(59, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Privremeni popis učenika u grupi";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(61, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pregledniji popis učenika u grupi";
            this.label5.Visible = false;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.Color.Red;
            this.lblOpis.Location = new System.Drawing.Point(483, 49);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(491, 24);
            this.lblOpis.TabIndex = 15;
            this.lblOpis.Text = "Morate prvo dodati grupu kako bi dodali korisnike u grupu";
            // 
            // btnDodajKorisnikeUgrupu
            // 
            this.btnDodajKorisnikeUgrupu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajKorisnikeUgrupu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKorisnikeUgrupu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDodajKorisnikeUgrupu.Location = new System.Drawing.Point(621, 93);
            this.btnDodajKorisnikeUgrupu.Name = "btnDodajKorisnikeUgrupu";
            this.btnDodajKorisnikeUgrupu.Size = new System.Drawing.Size(187, 63);
            this.btnDodajKorisnikeUgrupu.TabIndex = 16;
            this.btnDodajKorisnikeUgrupu.Text = "Završi s upisom učenika u grupu";
            this.btnDodajKorisnikeUgrupu.UseVisualStyleBackColor = false;
            this.btnDodajKorisnikeUgrupu.Visible = false;
            this.btnDodajKorisnikeUgrupu.Click += new System.EventHandler(this.btnDodajKorisnikeUgrupu_Click);
            // 
            // frmDodajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 700);
            this.Controls.Add(this.btnDodajKorisnikeUgrupu);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPopisSvih);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbPopis);
            this.Controls.Add(this.txtDodani);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDodajGrupu";
            this.Text = "frmDodajGrupu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPredavac;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.CheckBox chkObavljeno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.TextBox txtDodani;
        private System.Windows.Forms.ComboBox cmbPopis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajGrupu;
        private System.Windows.Forms.Label lblPopisSvih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnDodajKorisnikeUgrupu;
    }
}