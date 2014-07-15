namespace autoSkola
{
    partial class formUciteljKategorijaA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUciteljKategorijaA));
            this.lblNaslovB = new System.Windows.Forms.Label();
            this.menuVertikalni = new System.Windows.Forms.MenuStrip();
            this.menuBtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPredmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATISTIKAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPopis = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDodajGrupu = new System.Windows.Forms.Button();
            this.btnBrisiGrupu = new System.Windows.Forms.Button();
            this.btnEvidentirajDogađaj = new System.Windows.Forms.Button();
            this.lblPopisKorisnika = new System.Windows.Forms.Label();
            this.btnNovirok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUrediGrupu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMaterijali = new System.Windows.Forms.Button();
            this.menuVertikalni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaslovB
            // 
            this.lblNaslovB.AutoSize = true;
            this.lblNaslovB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovB.Location = new System.Drawing.Point(19, 35);
            this.lblNaslovB.Name = "lblNaslovB";
            this.lblNaslovB.Size = new System.Drawing.Size(173, 31);
            this.lblNaslovB.TabIndex = 6;
            this.lblNaslovB.Text = "Kategorija A";
            // 
            // menuVertikalni
            // 
            this.menuVertikalni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnHome,
            this.menuBtnPredmeti,
            this.menuBtnPostavke,
            this.sTATISTIKAToolStripMenuItem,
            this.menuBtnIzlaz});
            this.menuVertikalni.Location = new System.Drawing.Point(0, 0);
            this.menuVertikalni.Name = "menuVertikalni";
            this.menuVertikalni.Size = new System.Drawing.Size(1009, 24);
            this.menuVertikalni.TabIndex = 10;
            this.menuVertikalni.Text = "menuVertikalni";
            // 
            // menuBtnHome
            // 
            this.menuBtnHome.AutoSize = false;
            this.menuBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("menuBtnHome.Image")));
            this.menuBtnHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.menuBtnHome.Name = "menuBtnHome";
            this.menuBtnHome.Size = new System.Drawing.Size(22, 17);
            this.menuBtnHome.Click += new System.EventHandler(this.menuBtnHome_Click);
            // 
            // menuBtnPredmeti
            // 
            this.menuBtnPredmeti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnKatB,
            this.menuBtnKatC1,
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.bEToolStripMenuItem,
            this.c1ToolStripMenuItem,
            this.c1EToolStripMenuItem,
            this.cToolStripMenuItem,
            this.cEToolStripMenuItem,
            this.mToolStripMenuItem});
            this.menuBtnPredmeti.Name = "menuBtnPredmeti";
            this.menuBtnPredmeti.Size = new System.Drawing.Size(84, 20);
            this.menuBtnPredmeti.Text = "KATEGORIJE";
            // 
            // menuBtnKatB
            // 
            this.menuBtnKatB.Name = "menuBtnKatB";
            this.menuBtnKatB.Size = new System.Drawing.Size(102, 22);
            this.menuBtnKatB.Text = "A1";
            this.menuBtnKatB.Click += new System.EventHandler(this.menuBtnKatB_Click);
            // 
            // menuBtnKatC1
            // 
            this.menuBtnKatC1.Name = "menuBtnKatC1";
            this.menuBtnKatC1.Size = new System.Drawing.Size(102, 22);
            this.menuBtnKatC1.Text = "A2";
            this.menuBtnKatC1.Click += new System.EventHandler(this.menuBtnKatC1_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.aToolStripMenuItem.Text = "A";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // bEToolStripMenuItem
            // 
            this.bEToolStripMenuItem.Name = "bEToolStripMenuItem";
            this.bEToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.bEToolStripMenuItem.Text = "B+E";
            this.bEToolStripMenuItem.Click += new System.EventHandler(this.bEToolStripMenuItem_Click);
            // 
            // c1ToolStripMenuItem
            // 
            this.c1ToolStripMenuItem.Name = "c1ToolStripMenuItem";
            this.c1ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.c1ToolStripMenuItem.Text = "C1";
            this.c1ToolStripMenuItem.Click += new System.EventHandler(this.c1ToolStripMenuItem_Click);
            // 
            // c1EToolStripMenuItem
            // 
            this.c1EToolStripMenuItem.Name = "c1EToolStripMenuItem";
            this.c1EToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.c1EToolStripMenuItem.Text = "C1+E";
            this.c1EToolStripMenuItem.Click += new System.EventHandler(this.c1EToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cToolStripMenuItem.Text = "C";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cEToolStripMenuItem
            // 
            this.cEToolStripMenuItem.Name = "cEToolStripMenuItem";
            this.cEToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cEToolStripMenuItem.Text = "C+E";
            this.cEToolStripMenuItem.Click += new System.EventHandler(this.cEToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.mToolStripMenuItem.Text = "M";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // menuBtnPostavke
            // 
            this.menuBtnPostavke.Name = "menuBtnPostavke";
            this.menuBtnPostavke.Size = new System.Drawing.Size(76, 20);
            this.menuBtnPostavke.Text = "POSTAVKE";
            this.menuBtnPostavke.Click += new System.EventHandler(this.menuBtnPostavke_Click);
            // 
            // sTATISTIKAToolStripMenuItem
            // 
            this.sTATISTIKAToolStripMenuItem.Name = "sTATISTIKAToolStripMenuItem";
            this.sTATISTIKAToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sTATISTIKAToolStripMenuItem.Text = "STATISTIKA";
            this.sTATISTIKAToolStripMenuItem.Click += new System.EventHandler(this.sTATISTIKAToolStripMenuItem_Click);
            // 
            // menuBtnIzlaz
            // 
            this.menuBtnIzlaz.Checked = true;
            this.menuBtnIzlaz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBtnIzlaz.Name = "menuBtnIzlaz";
            this.menuBtnIzlaz.Size = new System.Drawing.Size(50, 20);
            this.menuBtnIzlaz.Text = "IZLAZ";
            this.menuBtnIzlaz.Click += new System.EventHandler(this.menuBtnIzlaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(267, 487);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblPopis
            // 
            this.lblPopis.AutoSize = true;
            this.lblPopis.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopis.Location = new System.Drawing.Point(83, 191);
            this.lblPopis.Name = "lblPopis";
            this.lblPopis.Size = new System.Drawing.Size(109, 23);
            this.lblPopis.TabIndex = 13;
            this.lblPopis.Text = "Popis grupa";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(422, 217);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(575, 487);
            this.dataGridView2.TabIndex = 14;
            // 
            // btnDodajGrupu
            // 
            this.btnDodajGrupu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajGrupu.Location = new System.Drawing.Point(22, 23);
            this.btnDodajGrupu.Name = "btnDodajGrupu";
            this.btnDodajGrupu.Size = new System.Drawing.Size(75, 46);
            this.btnDodajGrupu.TabIndex = 15;
            this.btnDodajGrupu.Text = "Dodaj grupu";
            this.btnDodajGrupu.UseVisualStyleBackColor = true;
            this.btnDodajGrupu.Click += new System.EventHandler(this.btnDodajGrupu_Click);
            // 
            // btnBrisiGrupu
            // 
            this.btnBrisiGrupu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisiGrupu.Location = new System.Drawing.Point(22, 75);
            this.btnBrisiGrupu.Name = "btnBrisiGrupu";
            this.btnBrisiGrupu.Size = new System.Drawing.Size(75, 47);
            this.btnBrisiGrupu.TabIndex = 16;
            this.btnBrisiGrupu.Text = "Briši grupu";
            this.btnBrisiGrupu.UseVisualStyleBackColor = true;
            this.btnBrisiGrupu.Click += new System.EventHandler(this.btnBrisiGrupu_Click);
            // 
            // btnEvidentirajDogađaj
            // 
            this.btnEvidentirajDogađaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEvidentirajDogađaj.Location = new System.Drawing.Point(11, 12);
            this.btnEvidentirajDogađaj.Name = "btnEvidentirajDogađaj";
            this.btnEvidentirajDogađaj.Size = new System.Drawing.Size(97, 79);
            this.btnEvidentirajDogađaj.TabIndex = 18;
            this.btnEvidentirajDogađaj.Text = "Evidentiraj dolaske na predavanja";
            this.btnEvidentirajDogađaj.UseVisualStyleBackColor = true;
            this.btnEvidentirajDogađaj.Click += new System.EventHandler(this.btnEvidentirajDogađaj_Click);
            // 
            // lblPopisKorisnika
            // 
            this.lblPopisKorisnika.AutoSize = true;
            this.lblPopisKorisnika.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopisKorisnika.Location = new System.Drawing.Point(418, 191);
            this.lblPopisKorisnika.Name = "lblPopisKorisnika";
            this.lblPopisKorisnika.Size = new System.Drawing.Size(204, 23);
            this.lblPopisKorisnika.TabIndex = 19;
            this.lblPopisKorisnika.Text = "Popis korisnika u grupi";
            // 
            // btnNovirok
            // 
            this.btnNovirok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovirok.Location = new System.Drawing.Point(11, 97);
            this.btnNovirok.Name = "btnNovirok";
            this.btnNovirok.Size = new System.Drawing.Size(97, 55);
            this.btnNovirok.TabIndex = 20;
            this.btnNovirok.Text = "Ispitni rok";
            this.btnNovirok.UseVisualStyleBackColor = true;
            this.btnNovirok.Click += new System.EventHandler(this.btnNovirok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajGrupu);
            this.groupBox1.Controls.Add(this.btnBrisiGrupu);
            this.groupBox1.Location = new System.Drawing.Point(292, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 137);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btnUrediGrupu
            // 
            this.btnUrediGrupu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediGrupu.Location = new System.Drawing.Point(22, 11);
            this.btnUrediGrupu.Name = "btnUrediGrupu";
            this.btnUrediGrupu.Size = new System.Drawing.Size(75, 71);
            this.btnUrediGrupu.TabIndex = 17;
            this.btnUrediGrupu.Text = "Briši učenika iz grupe";
            this.btnUrediGrupu.UseVisualStyleBackColor = true;
            this.btnUrediGrupu.Click += new System.EventHandler(this.btnUrediGrupu_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(22, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 22;
            this.button2.Text = "Dodaj učenika u grupu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnUrediGrupu);
            this.groupBox2.Location = new System.Drawing.Point(292, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 163);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNovirok);
            this.groupBox3.Controls.Add(this.btnEvidentirajDogađaj);
            this.groupBox3.Location = new System.Drawing.Point(292, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 155);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // btnMaterijali
            // 
            this.btnMaterijali.Location = new System.Drawing.Point(52, 83);
            this.btnMaterijali.Name = "btnMaterijali";
            this.btnMaterijali.Size = new System.Drawing.Size(101, 50);
            this.btnMaterijali.TabIndex = 25;
            this.btnMaterijali.Text = "Materijali";
            this.btnMaterijali.UseVisualStyleBackColor = true;
            this.btnMaterijali.Click += new System.EventHandler(this.btnMaterijali_Click);
            // 
            // formUciteljKategorijaA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 716);
            this.Controls.Add(this.btnMaterijali);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPopisKorisnika);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblPopis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuVertikalni);
            this.Controls.Add(this.lblNaslovB);
            this.Name = "formUciteljKategorijaA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola.NET - Kategorija A";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formUciteljKategorijaA_Load);
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovB;
        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnHome;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPredmeti;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatB;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatC1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem sTATISTIKAToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPopis;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDodajGrupu;
        private System.Windows.Forms.Button btnBrisiGrupu;
        private System.Windows.Forms.Button btnEvidentirajDogađaj;
        private System.Windows.Forms.Label lblPopisKorisnika;
        private System.Windows.Forms.Button btnNovirok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUrediGrupu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c1EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.Button btnMaterijali;
    }
}