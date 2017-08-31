using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;
using System.Configuration;

namespace KlijentForma
{
    public partial class PrijavaZaposlenog : Form
    {
        KKInterfejsa kki;

        public PrijavaZaposlenog(KKInterfejsa kontroler)
        {
            InitializeComponent();
            kki = kontroler;
            kki.VratiImenaZaposlenih(cbKorIme);
            
        }

        private void PrijavaZaposlenog_Load(object sender, EventArgs e)
        {
            txtKorSif.PasswordChar = '*';
            txtKorSif.TextAlign = HorizontalAlignment.Center;
            txtKorSif.CharacterCasing = CharacterCasing.Lower;
            Font font = new Font("Times New Roman", 12.0f,
                        FontStyle.Bold);
            txtKorSif.Font = font;
            
        }


        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            int rezultat = kki.PrijaviZaposlenog(cbKorIme, txtKorSif);
            if (rezultat == 1) { this.Dispose(); }
        }

        private void cbKorIme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       

        

    }
}
