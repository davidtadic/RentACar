namespace KlijentForma
{
    partial class PregledKlijenata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledKlijenata));
            this.lblText = new System.Windows.Forms.Label();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.dgvRezultati = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.pcbKlijent = new System.Windows.Forms.PictureBox();
            this.btnSviKlijenti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKlijent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(203, 33);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(130, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Unesi ime/prezime klijenta";
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(346, 30);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(133, 20);
            this.txtKriterijum.TabIndex = 1;
            // 
            // btnPronadji
            // 
            this.btnPronadji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPronadji.Location = new System.Drawing.Point(506, 22);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(135, 34);
            this.btnPronadji.TabIndex = 2;
            this.btnPronadji.Text = "Pretraži";
            this.btnPronadji.UseVisualStyleBackColor = false;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // dgvRezultati
            // 
            this.dgvRezultati.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultati.Location = new System.Drawing.Point(25, 126);
            this.dgvRezultati.Name = "dgvRezultati";
            this.dgvRezultati.Size = new System.Drawing.Size(616, 150);
            this.dgvRezultati.TabIndex = 3;
            this.dgvRezultati.Visible = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIzmeni.Location = new System.Drawing.Point(25, 282);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(157, 34);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Visible = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnObrisi.Location = new System.Drawing.Point(213, 282);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(135, 34);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Visible = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIzadji.Location = new System.Drawing.Point(506, 282);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(135, 34);
            this.btnIzadji.TabIndex = 6;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // pcbKlijent
            // 
            this.pcbKlijent.Image = ((System.Drawing.Image)(resources.GetObject("pcbKlijent.Image")));
            this.pcbKlijent.Location = new System.Drawing.Point(25, 12);
            this.pcbKlijent.Name = "pcbKlijent";
            this.pcbKlijent.Size = new System.Drawing.Size(159, 92);
            this.pcbKlijent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbKlijent.TabIndex = 7;
            this.pcbKlijent.TabStop = false;
            // 
            // btnSviKlijenti
            // 
            this.btnSviKlijenti.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSviKlijenti.Location = new System.Drawing.Point(506, 62);
            this.btnSviKlijenti.Name = "btnSviKlijenti";
            this.btnSviKlijenti.Size = new System.Drawing.Size(135, 34);
            this.btnSviKlijenti.TabIndex = 8;
            this.btnSviKlijenti.Text = "Prikaži sve klijente";
            this.btnSviKlijenti.UseVisualStyleBackColor = false;
            this.btnSviKlijenti.Click += new System.EventHandler(this.btnSviKlijenti_Click);
            // 
            // PregledKlijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(653, 333);
            this.Controls.Add(this.btnSviKlijenti);
            this.Controls.Add(this.pcbKlijent);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvRezultati);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.lblText);
            this.Name = "PregledKlijenata";
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.PregledKlijenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKlijent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.DataGridView dgvRezultati;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.PictureBox pcbKlijent;
        private System.Windows.Forms.Button btnSviKlijenti;
    }
}