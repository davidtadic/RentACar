namespace KlijentForma
{
    partial class UnosRentiranja
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
            this.ckbStornirano = new System.Windows.Forms.CheckBox();
            this.ckbRazduzeno = new System.Windows.Forms.CheckBox();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbRazduzio = new System.Windows.Forms.ComboBox();
            this.cbZaduzio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.cbAutomobil = new System.Windows.Forms.ComboBox();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDatumRazduzenja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZaduzenja = new System.Windows.Forms.DateTimePicker();
            this.txtRentiranjeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvaj1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbRent = new System.Windows.Forms.PictureBox();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRent)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbStornirano
            // 
            this.ckbStornirano.AutoSize = true;
            this.ckbStornirano.Location = new System.Drawing.Point(195, 204);
            this.ckbStornirano.Name = "ckbStornirano";
            this.ckbStornirano.Size = new System.Drawing.Size(74, 17);
            this.ckbStornirano.TabIndex = 43;
            this.ckbStornirano.Text = "Stornirano";
            this.ckbStornirano.UseVisualStyleBackColor = true;
            this.ckbStornirano.CheckedChanged += new System.EventHandler(this.ckbStornirano_CheckedChanged);
            // 
            // ckbRazduzeno
            // 
            this.ckbRazduzeno.AutoSize = true;
            this.ckbRazduzeno.Location = new System.Drawing.Point(25, 204);
            this.ckbRazduzeno.Name = "ckbRazduzeno";
            this.ckbRazduzeno.Size = new System.Drawing.Size(80, 17);
            this.ckbRazduzeno.TabIndex = 42;
            this.ckbRazduzeno.Text = "Razduženo";
            this.ckbRazduzeno.UseVisualStyleBackColor = true;
            this.ckbRazduzeno.CheckedChanged += new System.EventHandler(this.ckbRazduzeno_CheckedChanged);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Location = new System.Drawing.Point(450, 144);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(121, 20);
            this.txtUkupnaCena.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ukupna cena:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(15, 353);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(167, 44);
            this.btnSacuvaj.TabIndex = 39;
            this.btnSacuvaj.Text = "Sačuvaj i završi unos";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbRazduzio
            // 
            this.cbRazduzio.FormattingEnabled = true;
            this.cbRazduzio.Location = new System.Drawing.Point(79, 63);
            this.cbRazduzio.Name = "cbRazduzio";
            this.cbRazduzio.Size = new System.Drawing.Size(143, 21);
            this.cbRazduzio.TabIndex = 37;
            // 
            // cbZaduzio
            // 
            this.cbZaduzio.FormattingEnabled = true;
            this.cbZaduzio.Location = new System.Drawing.Point(79, 31);
            this.cbZaduzio.Name = "cbZaduzio";
            this.cbZaduzio.Size = new System.Drawing.Size(143, 21);
            this.cbZaduzio.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Razdužio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Zadužio:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(450, 44);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(121, 20);
            this.txtCena.TabIndex = 33;
            // 
            // cbAutomobil
            // 
            this.cbAutomobil.FormattingEnabled = true;
            this.cbAutomobil.Location = new System.Drawing.Point(148, 142);
            this.cbAutomobil.Name = "cbAutomobil";
            this.cbAutomobil.Size = new System.Drawing.Size(121, 21);
            this.cbAutomobil.TabIndex = 32;
            this.cbAutomobil.SelectedIndexChanged += new System.EventHandler(this.cbMasine_SelectedIndexChanged);
            // 
            // cbKlijent
            // 
            this.cbKlijent.AllowDrop = true;
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(148, 90);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(121, 21);
            this.cbKlijent.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cena iznajmljivanja:";
            // 
            // dtpDatumRazduzenja
            // 
            this.dtpDatumRazduzenja.CustomFormat = "yyyy-MM-dd";
            this.dtpDatumRazduzenja.Location = new System.Drawing.Point(450, 91);
            this.dtpDatumRazduzenja.Name = "dtpDatumRazduzenja";
            this.dtpDatumRazduzenja.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumRazduzenja.TabIndex = 27;
            this.dtpDatumRazduzenja.ValueChanged += new System.EventHandler(this.dtpDatumRazduzenja_ValueChanged);
            // 
            // dtpDatumZaduzenja
            // 
            this.dtpDatumZaduzenja.CustomFormat = "yyyy-MM-dd";
            this.dtpDatumZaduzenja.Location = new System.Drawing.Point(148, 44);
            this.dtpDatumZaduzenja.Name = "dtpDatumZaduzenja";
            this.dtpDatumZaduzenja.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumZaduzenja.TabIndex = 26;
            // 
            // txtRentiranjeID
            // 
            this.txtRentiranjeID.Enabled = false;
            this.txtRentiranjeID.Location = new System.Drawing.Point(122, 175);
            this.txtRentiranjeID.Name = "txtRentiranjeID";
            this.txtRentiranjeID.ReadOnly = true;
            this.txtRentiranjeID.Size = new System.Drawing.Size(60, 20);
            this.txtRentiranjeID.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Datum razduženja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Datum zaduženja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rentiranje ID:";
            // 
            // btnSacuvaj1
            // 
            this.btnSacuvaj1.Location = new System.Drawing.Point(368, 353);
            this.btnSacuvaj1.Name = "btnSacuvaj1";
            this.btnSacuvaj1.Size = new System.Drawing.Size(167, 44);
            this.btnSacuvaj1.TabIndex = 46;
            this.btnSacuvaj1.Text = "Sačuvaj i nastavi unos";
            this.btnSacuvaj1.UseVisualStyleBackColor = true;
            this.btnSacuvaj1.Click += new System.EventHandler(this.btnSacuvaj1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckbStornirano);
            this.groupBox1.Controls.Add(this.dtpDatumZaduzenja);
            this.groupBox1.Controls.Add(this.ckbRazduzeno);
            this.groupBox1.Controls.Add(this.dtpDatumRazduzenja);
            this.groupBox1.Controls.Add(this.txtUkupnaCena);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbKlijent);
            this.groupBox1.Controls.Add(this.cbAutomobil);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Location = new System.Drawing.Point(220, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 316);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o rentiranju";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Izaberite automobil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Izaberite klijenta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbZaduzio);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbRazduzio);
            this.groupBox2.Location = new System.Drawing.Point(327, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 95);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zaposleni";
            // 
            // pcbRent
            // 
            this.pcbRent.Image = global::KlijentForma.Properties.Resources.AddRent;
            this.pcbRent.Location = new System.Drawing.Point(12, 12);
            this.pcbRent.Name = "pcbRent";
            this.pcbRent.Size = new System.Drawing.Size(167, 153);
            this.pcbRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRent.TabIndex = 48;
            this.pcbRent.TabStop = false;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(734, 353);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 44);
            this.btnIzadji.TabIndex = 49;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // UnosRentiranja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(846, 424);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.pcbRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtRentiranjeID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UnosRentiranja";
            this.Text = "Unos rentiranja";
            this.Load += new System.EventHandler(this.UnosRentiranja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbStornirano;
        private System.Windows.Forms.CheckBox ckbRazduzeno;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbRazduzio;
        private System.Windows.Forms.ComboBox cbZaduzio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ComboBox cbAutomobil;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDatumRazduzenja;
        private System.Windows.Forms.DateTimePicker dtpDatumZaduzenja;
        private System.Windows.Forms.TextBox txtRentiranjeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pcbRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzadji;
    }
}