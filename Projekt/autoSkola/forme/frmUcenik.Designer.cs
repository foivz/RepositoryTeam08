namespace autoSkola.forme
{
    partial class frmUcenik
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
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.lblPopis = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblrok = new System.Windows.Forms.Label();
            this.btnBuduciDolasci = new System.Windows.Forms.Button();
            this.btnBuduci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaterijali = new System.Windows.Forms.Button();
            this.btnPristupi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 627);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbKat
            // 
            this.cmbKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.Location = new System.Drawing.Point(454, 60);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(121, 27);
            this.cmbKat.TabIndex = 1;
            this.cmbKat.SelectedIndexChanged += new System.EventHandler(this.cmbKat_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(397, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Svi dolasci na predavanja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregled.Location = new System.Drawing.Point(536, 271);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(94, 74);
            this.btnPregled.TabIndex = 3;
            this.btnPregled.Text = "Svi izlasci na ispite";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // lblPopis
            // 
            this.lblPopis.AutoSize = true;
            this.lblPopis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopis.Location = new System.Drawing.Point(24, 68);
            this.lblPopis.Name = "lblPopis";
            this.lblPopis.Size = new System.Drawing.Size(45, 19);
            this.lblPopis.TabIndex = 4;
            this.lblPopis.Text = "label1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(636, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(365, 627);
            this.dataGridView2.TabIndex = 5;
            // 
            // lblrok
            // 
            this.lblrok.AutoSize = true;
            this.lblrok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblrok.Location = new System.Drawing.Point(645, 68);
            this.lblrok.Name = "lblrok";
            this.lblrok.Size = new System.Drawing.Size(45, 19);
            this.lblrok.TabIndex = 6;
            this.lblrok.Text = "label1";
            // 
            // btnBuduciDolasci
            // 
            this.btnBuduciDolasci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuduciDolasci.Location = new System.Drawing.Point(397, 411);
            this.btnBuduciDolasci.Name = "btnBuduciDolasci";
            this.btnBuduciDolasci.Size = new System.Drawing.Size(96, 74);
            this.btnBuduciDolasci.TabIndex = 7;
            this.btnBuduciDolasci.Text = "Budući dolasci";
            this.btnBuduciDolasci.UseVisualStyleBackColor = true;
            this.btnBuduciDolasci.Click += new System.EventHandler(this.btnBuduciDolasci_Click);
            // 
            // btnBuduci
            // 
            this.btnBuduci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuduci.Location = new System.Drawing.Point(536, 411);
            this.btnBuduci.Name = "btnBuduci";
            this.btnBuduci.Size = new System.Drawing.Size(94, 74);
            this.btnBuduci.TabIndex = 8;
            this.btnBuduci.Text = "Ispiti koji se trebaju održati";
            this.btnBuduci.UseVisualStyleBackColor = true;
            this.btnBuduci.Click += new System.EventHandler(this.btnBuduci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(477, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kategorija";
            // 
            // btnMaterijali
            // 
            this.btnMaterijali.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaterijali.Location = new System.Drawing.Point(475, 105);
            this.btnMaterijali.Name = "btnMaterijali";
            this.btnMaterijali.Size = new System.Drawing.Size(75, 52);
            this.btnMaterijali.TabIndex = 10;
            this.btnMaterijali.Text = "Materijali";
            this.btnMaterijali.UseVisualStyleBackColor = true;
            this.btnMaterijali.Click += new System.EventHandler(this.btnMaterijali_Click);
            // 
            // btnPristupi
            // 
            this.btnPristupi.BackColor = System.Drawing.Color.Red;
            this.btnPristupi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPristupi.ForeColor = System.Drawing.Color.Black;
            this.btnPristupi.Location = new System.Drawing.Point(441, 180);
            this.btnPristupi.Name = "btnPristupi";
            this.btnPristupi.Size = new System.Drawing.Size(144, 63);
            this.btnPristupi.TabIndex = 11;
            this.btnPristupi.Text = "PRISTUPI ISPITU";
            this.btnPristupi.UseVisualStyleBackColor = false;
            this.btnPristupi.Visible = false;
            this.btnPristupi.Click += new System.EventHandler(this.btnPristupi_Click);
            // 
            // frmUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 729);
            this.Controls.Add(this.btnPristupi);
            this.Controls.Add(this.btnMaterijali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuduci);
            this.Controls.Add(this.btnBuduciDolasci);
            this.Controls.Add(this.lblrok);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblPopis);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbKat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUcenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUcenik";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Label lblPopis;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblrok;
        private System.Windows.Forms.Button btnBuduciDolasci;
        private System.Windows.Forms.Button btnBuduci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaterijali;
        private System.Windows.Forms.Button btnPristupi;
    }
}