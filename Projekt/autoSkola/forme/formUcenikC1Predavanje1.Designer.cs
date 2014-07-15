namespace autoSkola
{
    partial class formUcenikC1Predavanje1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUcenikC1Predavanje1));
            this.menuVertikalni = new System.Windows.Forms.MenuStrip();
            this.menuBtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPredmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFPredavanje1 = new AxAcroPDFLib.AxAcroPDF();
            this.menuVertikalni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFPredavanje1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertikalni
            // 
            this.menuVertikalni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnHome,
            this.menuBtnPredmeti,
            this.menuBtnPostavke,
            this.menuBtnIzlaz});
            this.menuVertikalni.Location = new System.Drawing.Point(0, 0);
            this.menuVertikalni.Name = "menuVertikalni";
            this.menuVertikalni.Size = new System.Drawing.Size(784, 24);
            this.menuVertikalni.TabIndex = 4;
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
            this.menuBtnKatC1});
            this.menuBtnPredmeti.Name = "menuBtnPredmeti";
            this.menuBtnPredmeti.Size = new System.Drawing.Size(74, 20);
            this.menuBtnPredmeti.Text = "PREDMETI";
            this.menuBtnPredmeti.Click += new System.EventHandler(this.menuBtnPredmeti_Click);
            // 
            // menuBtnKatB
            // 
            this.menuBtnKatB.Name = "menuBtnKatB";
            this.menuBtnKatB.Size = new System.Drawing.Size(152, 22);
            this.menuBtnKatB.Text = "B kategorija";
            this.menuBtnKatB.Click += new System.EventHandler(this.menuBtnKatB_Click);
            // 
            // menuBtnKatC1
            // 
            this.menuBtnKatC1.Name = "menuBtnKatC1";
            this.menuBtnKatC1.Size = new System.Drawing.Size(152, 22);
            this.menuBtnKatC1.Text = "C1 kategorija";
            this.menuBtnKatC1.Click += new System.EventHandler(this.menuBtnKatC1_Click);
            // 
            // menuBtnPostavke
            // 
            this.menuBtnPostavke.Name = "menuBtnPostavke";
            this.menuBtnPostavke.Size = new System.Drawing.Size(76, 20);
            this.menuBtnPostavke.Text = "POSTAVKE";
            this.menuBtnPostavke.Click += new System.EventHandler(this.menuBtnPostavke_Click);
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
            // PDFPredavanje1
            // 
            this.PDFPredavanje1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFPredavanje1.Enabled = true;
            this.PDFPredavanje1.Location = new System.Drawing.Point(0, 24);
            this.PDFPredavanje1.Name = "PDFPredavanje1";
            //komentar1 this.PDFPredavanje1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFPredavanje1.OcxState")));
            this.PDFPredavanje1.Size = new System.Drawing.Size(784, 538);
            this.PDFPredavanje1.TabIndex = 5;
            // 
            // formC1Predavanje1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.PDFPredavanje1);
            this.Controls.Add(this.menuVertikalni);
            this.Name = "formC1Predavanje1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predavanje 1";
            this.Load += new System.EventHandler(this.formC1Predavanje1_Load);
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFPredavanje1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnHome;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPredmeti;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatB;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatC1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        //komentar2 private AxAcroPDFLib.AxAcroPDF PDFPredavanje1;

        public System.Windows.Forms.Control PDFPredavanje1 { get; set; }
    }
}