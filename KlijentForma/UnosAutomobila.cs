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
    
    public partial class UnosAutomobila : Form
    {

        KKInterfejsa kki;
        private DataGridView dgvAutomobili;

        public UnosAutomobila(KKInterfejsa kontroler)
        {
            InitializeComponent();
            kki = kontroler;
            kki.VratiNoviID(txtAutomobilID, 2);
            kki.VratiSveProizvodjace(cbProizvodjaci);
        }

        public UnosAutomobila(KKInterfejsa kontroler, DataGridView dgvautomobili)
        {
            InitializeComponent();
            kki = kontroler;
            dgvAutomobili = dgvautomobili;
            kki.PopuniDetaljeZaAutomobil(dgvAutomobili, txtAutomobilID, txtNaziv, txtRegistarski, txtGodina, txtCena, cbProizvodjaci, btnSacuvaj, btnSacuvaj1, btnOdustani);
        }
          
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int rezultat = kki.SacuvajNoviAutomobil(txtAutomobilID, txtNaziv, txtGodina, txtRegistarski, txtCena, cbProizvodjaci);
            if (rezultat == 1) { this.Dispose(); }
        }

        private void btnSacuvaj1_Click(object sender, EventArgs e)
        {
            int rezultat = kki.SacuvajNoviAutomobil(txtAutomobilID, txtNaziv, txtGodina, txtRegistarski, txtCena, cbProizvodjaci);
            if (rezultat == 1)
            {
                new UnosAutomobila(kki);
                kki.VratiNoviID(txtAutomobilID, 2);
                kki.OcistiUnosAutomobila(txtNaziv, txtGodina, txtRegistarski, txtCena);
                kki.VratiSveProizvodjace(cbProizvodjaci);
            }
        }

        private void UnosAutomobila_Load(object sender, EventArgs e)
        {
            txtGodina.MaxLength = 4;
        }
    }
}
