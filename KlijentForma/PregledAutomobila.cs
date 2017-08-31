using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domen;
using KontrolerKorisnickogInterfejsa;
using System.Configuration;

namespace KlijentForma
{
    public partial class PregledAutomobila : Form
    {
        KKInterfejsa kki;
        UnosRentiranja ur;

        public PregledAutomobila(KKInterfejsa kontroler)
        {
            InitializeComponent();
            kki = kontroler;
        }

        public PregledAutomobila(KKInterfejsa kontroler, UnosRentiranja forma)
        {
            InitializeComponent();
            kki = kontroler;
            ur = forma;
            kki.SrediFormuPrikazAutomobila(btnDetalji, btnIzadji);
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            dgvAutomobili.Visible = true;
            btnDetalji.Visible = true;
            btnIzadji.Visible = true;
            kki.PronadjiAutomobil(txtKriterijum, dgvAutomobili, null);

        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistem je pronasao podatke o izabranom automobilu");
            new UnosAutomobila(kki, dgvAutomobili).ShowDialog();
            
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSviAutomobili_Click(object sender, EventArgs e)
        {
            kki.VratiSveAutomobile(dgvAutomobili);
            dgvAutomobili.Visible = true;
            btnDetalji.Visible = true;
            btnIzadji.Visible = true;
            
        }

       
        



        
    }
}
