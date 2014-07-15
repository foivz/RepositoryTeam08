namespace autoSkola
{
    partial class formUcenikPredmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUcenikPredmet));
            this.menuVertikalni = new System.Windows.Forms.MenuStrip();
            this.menuBtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.kalendarObveza = new System.Windows.Forms.MonthCalendar();
            this.menuVertikalni.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertikalni
            // 
            this.menuVertikalni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnHome,
            this.menuBtnPostavke,
            this.menuBtnIzlaz});
            this.menuVertikalni.Location = new System.Drawing.Point(0, 0);
            this.menuVertikalni.Name = "menuVertikalni";
            this.menuVertikalni.Size = new System.Drawing.Size(784, 24);
            this.menuVertikalni.TabIndex = 2;
            this.menuVertikalni.Text = "menuVertikalni";
            // 
            // menuBtnHome
            // 
            this.menuBtnHome.AutoSize = false;
            this.menuBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("menuBtnHome.Image")));
            this.menuBtnHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.menuBtnHome.Name = "menuBtnHome";
            this.menuBtnHome.ShowShortcutKeys = false;
            this.menuBtnHome.Size = new System.Drawing.Size(22, 17);
            this.menuBtnHome.Click += new System.EventHandler(this.menuBtnHome_Click);
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
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(16, 33);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(216, 31);
            this.lblNaziv.TabIndex = 7;
            this.lblNaziv.Text = "naziv Predmeta";
            // 
            // kalendarObveza
            // 
            this.kalendarObveza.ForeColor = System.Drawing.SystemColors.InfoText;
            this.kalendarObveza.Location = new System.Drawing.Point(573, 33);
            this.kalendarObveza.Name = "kalendarObveza";
            this.kalendarObveza.TabIndex = 6;
            this.kalendarObveza.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.kalendarObveza_DateSelected);
            // 
            // formUcenikPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.kalendarObveza);
            this.Controls.Add(this.menuVertikalni);
            this.Name = "formUcenikPredmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola .NET";
            this.Load += new System.EventHandler(this.formUcenikPredmet_Load);
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnHome;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.MonthCalendar kalendarObveza;
    }
}