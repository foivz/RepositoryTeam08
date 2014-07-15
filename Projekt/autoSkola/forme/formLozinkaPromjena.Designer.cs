namespace autoSkola
{
    partial class formLozinkaPromjena
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
            this.lblStara = new System.Windows.Forms.Label();
            this.txtStara = new System.Windows.Forms.TextBox();
            this.lblNova = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.txtNova2 = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStara
            // 
            this.lblStara.AutoSize = true;
            this.lblStara.Location = new System.Drawing.Point(63, 37);
            this.lblStara.Name = "lblStara";
            this.lblStara.Size = new System.Drawing.Size(71, 13);
            this.lblStara.TabIndex = 0;
            this.lblStara.Text = "Stara lozinka:";
            // 
            // txtStara
            // 
            this.txtStara.Location = new System.Drawing.Point(140, 34);
            this.txtStara.Name = "txtStara";
            this.txtStara.Size = new System.Drawing.Size(165, 20);
            this.txtStara.TabIndex = 1;
            this.txtStara.UseSystemPasswordChar = true;
            // 
            // lblNova
            // 
            this.lblNova.AutoSize = true;
            this.lblNova.Location = new System.Drawing.Point(62, 63);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(72, 13);
            this.lblNova.TabIndex = 2;
            this.lblNova.Text = "Nova lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Potvrdite novu lozinku:";
            // 
            // txtNova
            // 
            this.txtNova.Location = new System.Drawing.Point(140, 60);
            this.txtNova.Name = "txtNova";
            this.txtNova.Size = new System.Drawing.Size(165, 20);
            this.txtNova.TabIndex = 4;
            this.txtNova.UseSystemPasswordChar = true;
            // 
            // txtNova2
            // 
            this.txtNova2.Location = new System.Drawing.Point(140, 86);
            this.txtNova2.Name = "txtNova2";
            this.txtNova2.Size = new System.Drawing.Size(165, 20);
            this.txtNova2.TabIndex = 5;
            this.txtNova2.UseSystemPasswordChar = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(230, 120);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Location = new System.Drawing.Point(149, 120);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(75, 23);
            this.btnOdbaci.TabIndex = 7;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = true;
            this.btnOdbaci.Click += new System.EventHandler(this.btnOdbaci_Click);
            // 
            // formLozinkaPromjena
            // 
            this.AcceptButton = this.btnSpremi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdbaci;
            this.ClientSize = new System.Drawing.Size(325, 176);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtNova2);
            this.Controls.Add(this.txtNova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNova);
            this.Controls.Add(this.txtStara);
            this.Controls.Add(this.lblStara);
            this.Name = "formLozinkaPromjena";
            this.Text = "AutoŠkola .NET";
            this.Load += new System.EventHandler(this.formLozinkaPromjena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStara;
        private System.Windows.Forms.TextBox txtStara;
        private System.Windows.Forms.Label lblNova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNova;
        private System.Windows.Forms.TextBox txtNova2;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdbaci;
    }
}