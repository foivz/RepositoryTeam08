namespace autoSkola
{
    partial class formUcenikBVoznjaRezultat
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDatum2 = new System.Windows.Forms.Label();
            this.lblInstruktor2 = new System.Windows.Forms.Label();
            this.lblRezultat2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(26, 9);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(90, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum polaganja:";
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Location = new System.Drawing.Point(62, 32);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(54, 13);
            this.lblInstruktor.TabIndex = 1;
            this.lblInstruktor.Text = "Instruktor:";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(40, 56);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(76, 13);
            this.lblRezultat.TabIndex = 2;
            this.lblRezultat.Text = "Rezultat ispita:";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(54, 80);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 3;
            this.lblNapomena.Text = "Napomena:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(258, 135);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDatum2
            // 
            this.lblDatum2.AutoSize = true;
            this.lblDatum2.Location = new System.Drawing.Point(123, 9);
            this.lblDatum2.Name = "lblDatum2";
            this.lblDatum2.Size = new System.Drawing.Size(58, 13);
            this.lblDatum2.TabIndex = 5;
            this.lblDatum2.Text = "17.5.2013.";
            // 
            // lblInstruktor2
            // 
            this.lblInstruktor2.AutoSize = true;
            this.lblInstruktor2.Location = new System.Drawing.Point(123, 32);
            this.lblInstruktor2.Name = "lblInstruktor2";
            this.lblInstruktor2.Size = new System.Drawing.Size(59, 13);
            this.lblInstruktor2.TabIndex = 6;
            this.lblInstruktor2.Text = "Nitko Nikić";
            // 
            // lblRezultat2
            // 
            this.lblRezultat2.AutoSize = true;
            this.lblRezultat2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRezultat2.Location = new System.Drawing.Point(122, 56);
            this.lblRezultat2.Name = "lblRezultat2";
            this.lblRezultat2.Size = new System.Drawing.Size(50, 13);
            this.lblRezultat2.TabIndex = 7;
            this.lblRezultat2.Text = "PROLAZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(123, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Polaznik je uspješno položio vožnju te \r\nzadovoljio sve uvjete ocjenjivača.";
            // 
            // formVoznjaRezultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRezultat2);
            this.Controls.Add(this.lblInstruktor2);
            this.Controls.Add(this.lblDatum2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblInstruktor);
            this.Controls.Add(this.lblDatum);
            this.Name = "formVoznjaRezultat";
            this.Text = "AutoŠkola .NET - Rezultat ispita iz vožnje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDatum2;
        private System.Windows.Forms.Label lblInstruktor2;
        private System.Windows.Forms.Label lblRezultat2;
        private System.Windows.Forms.Label label1;
    }
}