namespace autoSkola
{
    partial class formUcenikBKat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUcenikBKat));
            this.menuVertikalni = new System.Windows.Forms.MenuStrip();
            this.menuBtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPredmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.groupTeorijaB = new System.Windows.Forms.GroupBox();
            this.btnTeorijaIspit = new System.Windows.Forms.Button();
            this.btnTeorijaEvidencija = new System.Windows.Forms.Button();
            this.btnTeorijaProbno = new System.Windows.Forms.Button();
            this.btnTeorijaMaterijali = new System.Windows.Forms.Button();
            this.lblIspitBTeorija2 = new System.Windows.Forms.Label();
            this.lblIspitBTeorija = new System.Windows.Forms.Label();
            this.lblStatusBTeorija2 = new System.Windows.Forms.Label();
            this.lblStatusBTeorija = new System.Windows.Forms.Label();
            this.groupPrvaPomocB = new System.Windows.Forms.GroupBox();
            this.btnPomocEvidencija = new System.Windows.Forms.Button();
            this.btnPomocMaterijali = new System.Windows.Forms.Button();
            this.groupVoznjaB = new System.Windows.Forms.GroupBox();
            this.kalendarObvezaB = new System.Windows.Forms.MonthCalendar();
            this.lblNaslovB = new System.Windows.Forms.Label();
            this.btnVoznjaEvidencija = new System.Windows.Forms.Button();
            this.lblStatusPomocB2 = new System.Windows.Forms.Label();
            this.lblStatusPomocB = new System.Windows.Forms.Label();
            this.lblStatusVoznjaB2 = new System.Windows.Forms.Label();
            this.lblStatusVoznjaB = new System.Windows.Forms.Label();
            this.btnVoznjaIspit = new System.Windows.Forms.Button();
            this.menuVertikalni.SuspendLayout();
            this.groupTeorijaB.SuspendLayout();
            this.groupPrvaPomocB.SuspendLayout();
            this.groupVoznjaB.SuspendLayout();
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
            this.menuVertikalni.TabIndex = 1;
            this.menuVertikalni.Text = "menuVertikalni";
            this.menuVertikalni.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuVertikalni_ItemClicked);
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
            // 
            // menuBtnKatB
            // 
            this.menuBtnKatB.Name = "menuBtnKatB";
            this.menuBtnKatB.Size = new System.Drawing.Size(143, 22);
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
            // groupTeorijaB
            // 
            this.groupTeorijaB.Controls.Add(this.btnTeorijaIspit);
            this.groupTeorijaB.Controls.Add(this.btnTeorijaEvidencija);
            this.groupTeorijaB.Controls.Add(this.btnTeorijaProbno);
            this.groupTeorijaB.Controls.Add(this.btnTeorijaMaterijali);
            this.groupTeorijaB.Controls.Add(this.lblIspitBTeorija2);
            this.groupTeorijaB.Controls.Add(this.lblIspitBTeorija);
            this.groupTeorijaB.Controls.Add(this.lblStatusBTeorija2);
            this.groupTeorijaB.Controls.Add(this.lblStatusBTeorija);
            this.groupTeorijaB.Location = new System.Drawing.Point(12, 216);
            this.groupTeorijaB.Name = "groupTeorijaB";
            this.groupTeorijaB.Size = new System.Drawing.Size(760, 90);
            this.groupTeorijaB.TabIndex = 2;
            this.groupTeorijaB.TabStop = false;
            this.groupTeorijaB.Text = "TEORIJA";
            // 
            // btnTeorijaIspit
            // 
            this.btnTeorijaIspit.Location = new System.Drawing.Point(394, 61);
            this.btnTeorijaIspit.Name = "btnTeorijaIspit";
            this.btnTeorijaIspit.Size = new System.Drawing.Size(96, 23);
            this.btnTeorijaIspit.TabIndex = 7;
            this.btnTeorijaIspit.Text = "Rezultati ispita";
            this.btnTeorijaIspit.UseVisualStyleBackColor = true;
            this.btnTeorijaIspit.Click += new System.EventHandler(this.btnTeorijaIspit_Click);
            // 
            // btnTeorijaEvidencija
            // 
            this.btnTeorijaEvidencija.Location = new System.Drawing.Point(679, 61);
            this.btnTeorijaEvidencija.Name = "btnTeorijaEvidencija";
            this.btnTeorijaEvidencija.Size = new System.Drawing.Size(75, 23);
            this.btnTeorijaEvidencija.TabIndex = 6;
            this.btnTeorijaEvidencija.Text = "Evidencija";
            this.btnTeorijaEvidencija.UseVisualStyleBackColor = true;
            this.btnTeorijaEvidencija.Click += new System.EventHandler(this.btnTeorijaEvidencija_Click);
            // 
            // btnTeorijaProbno
            // 
            this.btnTeorijaProbno.Enabled = false;
            this.btnTeorijaProbno.Location = new System.Drawing.Point(496, 61);
            this.btnTeorijaProbno.Name = "btnTeorijaProbno";
            this.btnTeorijaProbno.Size = new System.Drawing.Size(96, 23);
            this.btnTeorijaProbno.TabIndex = 5;
            this.btnTeorijaProbno.Text = "Probno testiranje";
            this.btnTeorijaProbno.UseVisualStyleBackColor = true;
            // 
            // btnTeorijaMaterijali
            // 
            this.btnTeorijaMaterijali.Enabled = false;
            this.btnTeorijaMaterijali.Location = new System.Drawing.Point(598, 61);
            this.btnTeorijaMaterijali.Name = "btnTeorijaMaterijali";
            this.btnTeorijaMaterijali.Size = new System.Drawing.Size(75, 23);
            this.btnTeorijaMaterijali.TabIndex = 4;
            this.btnTeorijaMaterijali.Text = "Materijali";
            this.btnTeorijaMaterijali.UseVisualStyleBackColor = true;
            // 
            // lblIspitBTeorija2
            // 
            this.lblIspitBTeorija2.AutoSize = true;
            this.lblIspitBTeorija2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIspitBTeorija2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIspitBTeorija2.Location = new System.Drawing.Point(60, 54);
            this.lblIspitBTeorija2.Name = "lblIspitBTeorija2";
            this.lblIspitBTeorija2.Size = new System.Drawing.Size(34, 16);
            this.lblIspitBTeorija2.TabIndex = 3;
            this.lblIspitBTeorija2.Text = "75%";
            // 
            // lblIspitBTeorija
            // 
            this.lblIspitBTeorija.AutoSize = true;
            this.lblIspitBTeorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIspitBTeorija.Location = new System.Drawing.Point(16, 54);
            this.lblIspitBTeorija.Name = "lblIspitBTeorija";
            this.lblIspitBTeorija.Size = new System.Drawing.Size(38, 16);
            this.lblIspitBTeorija.TabIndex = 2;
            this.lblIspitBTeorija.Text = "Ispit: ";
            this.lblIspitBTeorija.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusBTeorija2
            // 
            this.lblStatusBTeorija2.AutoSize = true;
            this.lblStatusBTeorija2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusBTeorija2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatusBTeorija2.Location = new System.Drawing.Point(60, 29);
            this.lblStatusBTeorija2.Name = "lblStatusBTeorija2";
            this.lblStatusBTeorija2.Size = new System.Drawing.Size(65, 16);
            this.lblStatusBTeorija2.TabIndex = 1;
            this.lblStatusBTeorija2.Text = "Položeno";
            // 
            // lblStatusBTeorija
            // 
            this.lblStatusBTeorija.AutoSize = true;
            this.lblStatusBTeorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusBTeorija.Location = new System.Drawing.Point(6, 29);
            this.lblStatusBTeorija.Name = "lblStatusBTeorija";
            this.lblStatusBTeorija.Size = new System.Drawing.Size(48, 16);
            this.lblStatusBTeorija.TabIndex = 0;
            this.lblStatusBTeorija.Text = "Status:";
            // 
            // groupPrvaPomocB
            // 
            this.groupPrvaPomocB.Controls.Add(this.lblStatusPomocB2);
            this.groupPrvaPomocB.Controls.Add(this.btnPomocEvidencija);
            this.groupPrvaPomocB.Controls.Add(this.lblStatusPomocB);
            this.groupPrvaPomocB.Controls.Add(this.btnPomocMaterijali);
            this.groupPrvaPomocB.Location = new System.Drawing.Point(12, 341);
            this.groupPrvaPomocB.Name = "groupPrvaPomocB";
            this.groupPrvaPomocB.Size = new System.Drawing.Size(760, 90);
            this.groupPrvaPomocB.TabIndex = 3;
            this.groupPrvaPomocB.TabStop = false;
            this.groupPrvaPomocB.Text = "PRVA POMOĆ";
            // 
            // btnPomocEvidencija
            // 
            this.btnPomocEvidencija.Location = new System.Drawing.Point(679, 61);
            this.btnPomocEvidencija.Name = "btnPomocEvidencija";
            this.btnPomocEvidencija.Size = new System.Drawing.Size(75, 23);
            this.btnPomocEvidencija.TabIndex = 9;
            this.btnPomocEvidencija.Text = "Evidencija";
            this.btnPomocEvidencija.UseVisualStyleBackColor = true;
            // 
            // btnPomocMaterijali
            // 
            this.btnPomocMaterijali.Enabled = false;
            this.btnPomocMaterijali.Location = new System.Drawing.Point(598, 61);
            this.btnPomocMaterijali.Name = "btnPomocMaterijali";
            this.btnPomocMaterijali.Size = new System.Drawing.Size(75, 23);
            this.btnPomocMaterijali.TabIndex = 8;
            this.btnPomocMaterijali.Text = "Materijali";
            this.btnPomocMaterijali.UseVisualStyleBackColor = true;
            // 
            // groupVoznjaB
            // 
            this.groupVoznjaB.Controls.Add(this.btnVoznjaIspit);
            this.groupVoznjaB.Controls.Add(this.lblStatusVoznjaB2);
            this.groupVoznjaB.Controls.Add(this.btnVoznjaEvidencija);
            this.groupVoznjaB.Controls.Add(this.lblStatusVoznjaB);
            this.groupVoznjaB.Location = new System.Drawing.Point(12, 460);
            this.groupVoznjaB.Name = "groupVoznjaB";
            this.groupVoznjaB.Size = new System.Drawing.Size(760, 90);
            this.groupVoznjaB.TabIndex = 4;
            this.groupVoznjaB.TabStop = false;
            this.groupVoznjaB.Text = "VOŽNJA";
            // 
            // kalendarObvezaB
            // 
            this.kalendarObvezaB.BoldedDates = new System.DateTime[] {
        new System.DateTime(2013, 5, 1, 0, 0, 0, 0)};
            this.kalendarObvezaB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.kalendarObvezaB.Location = new System.Drawing.Point(573, 33);
            this.kalendarObvezaB.Name = "kalendarObvezaB";
            this.kalendarObvezaB.TabIndex = 4;
            this.kalendarObvezaB.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.kalendarObvezaB_DateSelected);
            // 
            // lblNaslovB
            // 
            this.lblNaslovB.AutoSize = true;
            this.lblNaslovB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovB.Location = new System.Drawing.Point(16, 33);
            this.lblNaslovB.Name = "lblNaslovB";
            this.lblNaslovB.Size = new System.Drawing.Size(173, 31);
            this.lblNaslovB.TabIndex = 5;
            this.lblNaslovB.Text = "Kategorija B";
            // 
            // btnVoznjaEvidencija
            // 
            this.btnVoznjaEvidencija.Location = new System.Drawing.Point(679, 61);
            this.btnVoznjaEvidencija.Name = "btnVoznjaEvidencija";
            this.btnVoznjaEvidencija.Size = new System.Drawing.Size(75, 23);
            this.btnVoznjaEvidencija.TabIndex = 10;
            this.btnVoznjaEvidencija.Text = "Evidencija";
            this.btnVoznjaEvidencija.UseVisualStyleBackColor = true;
            // 
            // lblStatusPomocB2
            // 
            this.lblStatusPomocB2.AutoSize = true;
            this.lblStatusPomocB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusPomocB2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatusPomocB2.Location = new System.Drawing.Point(61, 30);
            this.lblStatusPomocB2.Name = "lblStatusPomocB2";
            this.lblStatusPomocB2.Size = new System.Drawing.Size(65, 16);
            this.lblStatusPomocB2.TabIndex = 9;
            this.lblStatusPomocB2.Text = "Položeno";
            // 
            // lblStatusPomocB
            // 
            this.lblStatusPomocB.AutoSize = true;
            this.lblStatusPomocB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusPomocB.Location = new System.Drawing.Point(7, 30);
            this.lblStatusPomocB.Name = "lblStatusPomocB";
            this.lblStatusPomocB.Size = new System.Drawing.Size(48, 16);
            this.lblStatusPomocB.TabIndex = 8;
            this.lblStatusPomocB.Text = "Status:";
            // 
            // lblStatusVoznjaB2
            // 
            this.lblStatusVoznjaB2.AutoSize = true;
            this.lblStatusVoznjaB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusVoznjaB2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatusVoznjaB2.Location = new System.Drawing.Point(61, 31);
            this.lblStatusVoznjaB2.Name = "lblStatusVoznjaB2";
            this.lblStatusVoznjaB2.Size = new System.Drawing.Size(65, 16);
            this.lblStatusVoznjaB2.TabIndex = 7;
            this.lblStatusVoznjaB2.Text = "Položeno";
            // 
            // lblStatusVoznjaB
            // 
            this.lblStatusVoznjaB.AutoSize = true;
            this.lblStatusVoznjaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusVoznjaB.Location = new System.Drawing.Point(7, 31);
            this.lblStatusVoznjaB.Name = "lblStatusVoznjaB";
            this.lblStatusVoznjaB.Size = new System.Drawing.Size(48, 16);
            this.lblStatusVoznjaB.TabIndex = 6;
            this.lblStatusVoznjaB.Text = "Status:";
            // 
            // btnVoznjaIspit
            // 
            this.btnVoznjaIspit.Location = new System.Drawing.Point(577, 61);
            this.btnVoznjaIspit.Name = "btnVoznjaIspit";
            this.btnVoznjaIspit.Size = new System.Drawing.Size(96, 23);
            this.btnVoznjaIspit.TabIndex = 8;
            this.btnVoznjaIspit.Text = "Rezultat ispita";
            this.btnVoznjaIspit.UseVisualStyleBackColor = true;
            this.btnVoznjaIspit.Click += new System.EventHandler(this.btnVoznjaIspit_Click);
            // 
            // formKatB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblNaslovB);
            this.Controls.Add(this.kalendarObvezaB);
            this.Controls.Add(this.groupVoznjaB);
            this.Controls.Add(this.groupPrvaPomocB);
            this.Controls.Add(this.groupTeorijaB);
            this.Controls.Add(this.menuVertikalni);
            this.Name = "formKatB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola .NET - Kategorija B";
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            this.groupTeorijaB.ResumeLayout(false);
            this.groupTeorijaB.PerformLayout();
            this.groupPrvaPomocB.ResumeLayout(false);
            this.groupPrvaPomocB.PerformLayout();
            this.groupVoznjaB.ResumeLayout(false);
            this.groupVoznjaB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPredmeti;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatB;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatC1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        private System.Windows.Forms.ToolStripMenuItem menuBtnHome;
        private System.Windows.Forms.GroupBox groupTeorijaB;
        private System.Windows.Forms.GroupBox groupPrvaPomocB;
        private System.Windows.Forms.GroupBox groupVoznjaB;
        private System.Windows.Forms.Label lblStatusBTeorija2;
        private System.Windows.Forms.Label lblStatusBTeorija;
        private System.Windows.Forms.Label lblIspitBTeorija2;
        private System.Windows.Forms.Label lblIspitBTeorija;
        private System.Windows.Forms.MonthCalendar kalendarObvezaB;
        private System.Windows.Forms.Label lblNaslovB;
        private System.Windows.Forms.Button btnTeorijaProbno;
        private System.Windows.Forms.Button btnTeorijaMaterijali;
        private System.Windows.Forms.Button btnTeorijaIspit;
        private System.Windows.Forms.Button btnTeorijaEvidencija;
        private System.Windows.Forms.Button btnPomocEvidencija;
        private System.Windows.Forms.Button btnPomocMaterijali;
        private System.Windows.Forms.Button btnVoznjaEvidencija;
        private System.Windows.Forms.Label lblStatusPomocB2;
        private System.Windows.Forms.Label lblStatusPomocB;
        private System.Windows.Forms.Label lblStatusVoznjaB2;
        private System.Windows.Forms.Label lblStatusVoznjaB;
        private System.Windows.Forms.Button btnVoznjaIspit;
    }
}