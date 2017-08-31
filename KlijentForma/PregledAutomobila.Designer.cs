namespace KlijentForma
{
    partial class PregledAutomobila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledAutomobila));
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnSviAutomobili = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIzadji.Location = new System.Drawing.Point(585, 384);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(127, 27);
            this.btnIzadji.TabIndex = 11;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDetalji.Location = new System.Drawing.Point(24, 384);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(127, 27);
            this.btnDetalji.TabIndex = 10;
            this.btnDetalji.Text = "Prikaži detalje";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Visible = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.Location = new System.Drawing.Point(24, 148);
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.Size = new System.Drawing.Size(688, 221);
            this.dgvAutomobili.TabIndex = 9;
            this.dgvAutomobili.Visible = false;
            // 
            // btnPronadji
            // 
            this.btnPronadji.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPronadji.Location = new System.Drawing.Point(487, 29);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(127, 27);
            this.btnPronadji.TabIndex = 8;
            this.btnPronadji.Text = "Pretraži";
            this.btnPronadji.UseVisualStyleBackColor = false;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(305, 33);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(126, 20);
            this.txtKriterijum.TabIndex = 7;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(159, 36);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(128, 13);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Unesite naziv automobila:";
            // 
            // btnSviAutomobili
            // 
            this.btnSviAutomobili.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSviAutomobili.Location = new System.Drawing.Point(487, 84);
            this.btnSviAutomobili.Name = "btnSviAutomobili";
            this.btnSviAutomobili.Size = new System.Drawing.Size(127, 27);
            this.btnSviAutomobili.TabIndex = 13;
            this.btnSviAutomobili.Text = "Prikaži sve automobile";
            this.btnSviAutomobili.UseVisualStyleBackColor = false;
            this.btnSviAutomobili.Click += new System.EventHandler(this.btnSviAutomobili_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // PregledAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(745, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSviAutomobili);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvAutomobili);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.lblText);
            this.Name = "PregledAutomobila";
            this.Text = "Automobili";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnSviAutomobili;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}