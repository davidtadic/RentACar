namespace KlijentForma
{
    partial class PregledRentiranja
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
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.dgvRentiranja = new System.Windows.Forms.DataGridView();
            this.lblText = new System.Windows.Forms.Label();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.pcbRent = new System.Windows.Forms.PictureBox();
            this.btnSvaRentiranja = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentiranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStorniraj.Location = new System.Drawing.Point(206, 379);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(120, 28);
            this.btnStorniraj.TabIndex = 12;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = false;
            this.btnStorniraj.Visible = false;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIzmeni.Location = new System.Drawing.Point(51, 379);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(120, 28);
            this.btnIzmeni.TabIndex = 11;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Visible = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(150, 30);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(167, 21);
            this.cmbKlijent.TabIndex = 10;
            // 
            // dgvRentiranja
            // 
            this.dgvRentiranja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRentiranja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentiranja.Location = new System.Drawing.Point(51, 138);
            this.dgvRentiranja.Name = "dgvRentiranja";
            this.dgvRentiranja.Size = new System.Drawing.Size(1058, 230);
            this.dgvRentiranja.TabIndex = 9;
            this.dgvRentiranja.Visible = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(48, 33);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(86, 13);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Izaberite klijenta:";
            // 
            // btnPronadji
            // 
            this.btnPronadji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPronadji.Location = new System.Drawing.Point(348, 25);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(168, 28);
            this.btnPronadji.TabIndex = 7;
            this.btnPronadji.Text = "Pretraži";
            this.btnPronadji.UseVisualStyleBackColor = false;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // pcbRent
            // 
            this.pcbRent.Image = global::KlijentForma.Properties.Resources.Rent;
            this.pcbRent.Location = new System.Drawing.Point(929, 12);
            this.pcbRent.Name = "pcbRent";
            this.pcbRent.Size = new System.Drawing.Size(180, 119);
            this.pcbRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRent.TabIndex = 13;
            this.pcbRent.TabStop = false;
            // 
            // btnSvaRentiranja
            // 
            this.btnSvaRentiranja.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSvaRentiranja.Location = new System.Drawing.Point(348, 85);
            this.btnSvaRentiranja.Name = "btnSvaRentiranja";
            this.btnSvaRentiranja.Size = new System.Drawing.Size(168, 28);
            this.btnSvaRentiranja.TabIndex = 14;
            this.btnSvaRentiranja.Text = "Prikaži sva rentiranja";
            this.btnSvaRentiranja.UseVisualStyleBackColor = false;
            this.btnSvaRentiranja.Click += new System.EventHandler(this.btnSvaRentiranja_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIzadji.Location = new System.Drawing.Point(989, 384);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(120, 28);
            this.btnIzadji.TabIndex = 15;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // PregledRentiranja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1151, 419);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnSvaRentiranja);
            this.Controls.Add(this.pcbRent);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.dgvRentiranja);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnPronadji);
            this.Name = "PregledRentiranja";
            this.Text = "PregledRentiranja";
            this.Load += new System.EventHandler(this.PregledRentiranja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentiranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.DataGridView dgvRentiranja;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.PictureBox pcbRent;
        private System.Windows.Forms.Button btnSvaRentiranja;
        private System.Windows.Forms.Button btnIzadji;
    }
}