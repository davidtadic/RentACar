namespace KlijentForma
{
    partial class PrijavaZaposlenog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaZaposlenog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKorIme = new System.Windows.Forms.ComboBox();
            this.txtKorSif = new System.Windows.Forms.TextBox();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbLogin = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisnička šifra";
            // 
            // cbKorIme
            // 
            this.cbKorIme.FormattingEnabled = true;
            this.cbKorIme.Location = new System.Drawing.Point(162, 27);
            this.cbKorIme.Name = "cbKorIme";
            this.cbKorIme.Size = new System.Drawing.Size(121, 21);
            this.cbKorIme.TabIndex = 2;
            this.cbKorIme.SelectedIndexChanged += new System.EventHandler(this.cbKorIme_SelectedIndexChanged);
            // 
            // txtKorSif
            // 
            this.txtKorSif.Location = new System.Drawing.Point(162, 73);
            this.txtKorSif.Name = "txtKorSif";
            this.txtKorSif.Size = new System.Drawing.Size(121, 20);
            this.txtKorSif.TabIndex = 3;
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Location = new System.Drawing.Point(89, 126);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(133, 23);
            this.btnPrijavi.TabIndex = 4;
            this.btnPrijavi.Text = "Prijavi se!";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrijavi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKorSif);
            this.groupBox1.Controls.Add(this.cbKorIme);
            this.groupBox1.Location = new System.Drawing.Point(96, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pcbLogin
            // 
            this.pcbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogin.Image")));
            this.pcbLogin.Location = new System.Drawing.Point(12, 12);
            this.pcbLogin.Name = "pcbLogin";
            this.pcbLogin.Size = new System.Drawing.Size(496, 150);
            this.pcbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogin.TabIndex = 6;
            this.pcbLogin.TabStop = false;
            // 
            // PrijavaZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(520, 377);
            this.Controls.Add(this.pcbLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrijavaZaposlenog";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.PrijavaZaposlenog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKorIme;
        private System.Windows.Forms.TextBox txtKorSif;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbLogin;
    }
}

