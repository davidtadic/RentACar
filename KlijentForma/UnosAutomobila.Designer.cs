namespace KlijentForma
{
    partial class UnosAutomobila
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtRegistarski = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAutomobilID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvaj1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbAddAutomobil = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddAutomobil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSacuvaj.Location = new System.Drawing.Point(39, 265);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(142, 45);
            this.btnSacuvaj.TabIndex = 27;
            this.btnSacuvaj.Text = "Sačuvaj i završi unos";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOdustani.Location = new System.Drawing.Point(695, 265);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 44);
            this.btnOdustani.TabIndex = 26;
            this.btnOdustani.Text = "Izađi";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cbProizvodjaci
            // 
            this.cbProizvodjaci.FormattingEnabled = true;
            this.cbProizvodjaci.Location = new System.Drawing.Point(404, 84);
            this.cbProizvodjaci.Name = "cbProizvodjaci";
            this.cbProizvodjaci.Size = new System.Drawing.Size(150, 21);
            this.cbProizvodjaci.TabIndex = 25;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(404, 44);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(150, 20);
            this.txtCena.TabIndex = 24;
            // 
            // txtRegistarski
            // 
            this.txtRegistarski.Location = new System.Drawing.Point(137, 133);
            this.txtRegistarski.Name = "txtRegistarski";
            this.txtRegistarski.Size = new System.Drawing.Size(121, 20);
            this.txtRegistarski.TabIndex = 23;
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(137, 86);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(121, 20);
            this.txtGodina.TabIndex = 22;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(137, 41);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 21;
            // 
            // txtAutomobilID
            // 
            this.txtAutomobilID.Enabled = false;
            this.txtAutomobilID.Location = new System.Drawing.Point(128, 194);
            this.txtAutomobilID.Name = "txtAutomobilID";
            this.txtAutomobilID.ReadOnly = true;
            this.txtAutomobilID.Size = new System.Drawing.Size(53, 20);
            this.txtAutomobilID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Proizvođač:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cena rentiranja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Registarski broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Godina proizvodnje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model automobila:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Automobil ID:";
            // 
            // btnSacuvaj1
            // 
            this.btnSacuvaj1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSacuvaj1.Location = new System.Drawing.Point(351, 265);
            this.btnSacuvaj1.Name = "btnSacuvaj1";
            this.btnSacuvaj1.Size = new System.Drawing.Size(142, 45);
            this.btnSacuvaj1.TabIndex = 28;
            this.btnSacuvaj1.Text = "Sačuvaj i nastavi unos";
            this.btnSacuvaj1.UseVisualStyleBackColor = false;
            this.btnSacuvaj1.Click += new System.EventHandler(this.btnSacuvaj1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbProizvodjaci);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRegistarski);
            this.groupBox1.Controls.Add(this.txtGodina);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Location = new System.Drawing.Point(235, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 167);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o automobilu";
            // 
            // pcbAddAutomobil
            // 
            this.pcbAddAutomobil.Image = global::KlijentForma.Properties.Resources.CarLogo;
            this.pcbAddAutomobil.Location = new System.Drawing.Point(12, 12);
            this.pcbAddAutomobil.Name = "pcbAddAutomobil";
            this.pcbAddAutomobil.Size = new System.Drawing.Size(190, 167);
            this.pcbAddAutomobil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAddAutomobil.TabIndex = 30;
            this.pcbAddAutomobil.TabStop = false;
            // 
            // UnosAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(819, 328);
            this.Controls.Add(this.pcbAddAutomobil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtAutomobilID);
            this.Name = "UnosAutomobila";
            this.Text = "Unos automobila";
            this.Load += new System.EventHandler(this.UnosAutomobila_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddAutomobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cbProizvodjaci;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtRegistarski;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAutomobilID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbAddAutomobil;

    }
}