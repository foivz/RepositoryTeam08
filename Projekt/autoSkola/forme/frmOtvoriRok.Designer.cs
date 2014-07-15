namespace autoSkola.forme
{
    partial class frmOtvoriRok
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajPitanje = new System.Windows.Forms.Button();
            this.btnObrisiPitanje = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZapočniRok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 620);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(171, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis svih pitanja";
            // 
            // btnDodajPitanje
            // 
            this.btnDodajPitanje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPitanje.Location = new System.Drawing.Point(489, 99);
            this.btnDodajPitanje.Name = "btnDodajPitanje";
            this.btnDodajPitanje.Size = new System.Drawing.Size(75, 49);
            this.btnDodajPitanje.TabIndex = 5;
            this.btnDodajPitanje.Text = "Dodaj pitanje";
            this.btnDodajPitanje.UseVisualStyleBackColor = true;
            this.btnDodajPitanje.Click += new System.EventHandler(this.btnDodajPitanje_Click);
            // 
            // btnObrisiPitanje
            // 
            this.btnObrisiPitanje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiPitanje.Location = new System.Drawing.Point(489, 167);
            this.btnObrisiPitanje.Name = "btnObrisiPitanje";
            this.btnObrisiPitanje.Size = new System.Drawing.Size(75, 54);
            this.btnObrisiPitanje.TabIndex = 6;
            this.btnObrisiPitanje.Text = "Obriši pitanje";
            this.btnObrisiPitanje.UseVisualStyleBackColor = true;
            this.btnObrisiPitanje.Click += new System.EventHandler(this.btnObrisiPitanje_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(583, 97);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(413, 622);
            this.dataGridView2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(744, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Popis dodanih pitanja";
            // 
            // btnZapočniRok
            // 
            this.btnZapočniRok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapočniRok.Location = new System.Drawing.Point(483, 268);
            this.btnZapočniRok.Name = "btnZapočniRok";
            this.btnZapočniRok.Size = new System.Drawing.Size(88, 57);
            this.btnZapočniRok.TabIndex = 9;
            this.btnZapočniRok.Text = "ZAPOČNI ROK";
            this.btnZapočniRok.UseVisualStyleBackColor = true;
            this.btnZapočniRok.Click += new System.EventHandler(this.btnZapočniRok_Click);
            // 
            // frmOtvoriRok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnZapočniRok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnObrisiPitanje);
            this.Controls.Add(this.btnDodajPitanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmOtvoriRok";
            this.Text = "frmOtvoriRok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPitanje;
        private System.Windows.Forms.Button btnObrisiPitanje;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZapočniRok;
    }
}