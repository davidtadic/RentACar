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
    public partial class UnosRentiranja : Form
    {
        KKInterfejsa kki;
        bool izmena;


        public UnosRentiranja(KKInterfejsa kontroler)
        {
            InitializeComponent();
            kki = kontroler;
            izmena = false;
            kki.VratiNoviID(txtRentiranjeID, 3);
            kki.SrediFormu(ckbRazduzeno.Checked, dtpDatumRazduzenja, cbRazduzio, ckbStornirano);
            kki.PostaviZaposlenog(cbZaduzio);
            kki.VratiSveKlijente(cbKlijent);
            kki.VratiSveAutomobile(cbAutomobil);
            
        }

        public UnosRentiranja(KKInterfejsa kontroler, DataGridView dgvRentiranja)
        {
            InitializeComponent();
            kki = kontroler;
            izmena = true;
            kki.PopuniZaIzmenuRentiranja(dgvRentiranja, txtRentiranjeID, dtpDatumZaduzenja, dtpDatumRazduzenja, ckbRazduzeno, ckbStornirano, cbKlijent, cbAutomobil, cbZaduzio, cbRazduzio, txtCena, txtUkupnaCena);
        }


        private void UnosRentiranja_Load(object sender, EventArgs e)
        {
           
        }

        private void ckbStornirano_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da stornirate rentiranje?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
            }
            else if (dr == DialogResult.Cancel) { }
        }

        private void ckbRazduzeno_CheckedChanged(object sender, EventArgs e)
        {
            kki.SrediFormu(ckbRazduzeno.Checked, dtpDatumRazduzenja, cbRazduzio, ckbStornirano);
            
            kki.IzracunajCenu(dtpDatumRazduzenja, dtpDatumZaduzenja, txtCena, txtUkupnaCena);
        }

        private void cbMasine_SelectedIndexChanged(object sender, EventArgs e)
        {
            kki.PostaviCenu(cbAutomobil, txtCena);
            kki.IzracunajCenu(dtpDatumRazduzenja, dtpDatumZaduzenja, txtCena, txtUkupnaCena);
        }

        private void dtpDatumRazduzenja_ValueChanged(object sender, EventArgs e)
        {
            kki.IzracunajCenu(dtpDatumRazduzenja, dtpDatumZaduzenja, txtCena, txtUkupnaCena);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int rezultat;

            if (izmena)
            {
                rezultat = kki.IzmeniRentiranje(txtRentiranjeID, dtpDatumZaduzenja, dtpDatumRazduzenja, txtUkupnaCena, ckbRazduzeno, ckbStornirano, cbKlijent, cbAutomobil, cbZaduzio, cbRazduzio);
            }
            else
            {
                rezultat = kki.SacuvajNovoRentiranje(txtRentiranjeID, dtpDatumZaduzenja, dtpDatumRazduzenja, txtUkupnaCena, ckbRazduzeno, ckbStornirano, cbKlijent, cbAutomobil, cbZaduzio, cbRazduzio);
            }
            if (rezultat == 1) { this.Dispose(); }
        }

        private void btnSacuvaj1_Click(object sender, EventArgs e)
        {
            int rezultat;

            if (izmena)
            {
                rezultat = kki.IzmeniRentiranje(txtRentiranjeID, dtpDatumZaduzenja, dtpDatumRazduzenja, txtUkupnaCena, ckbRazduzeno, ckbStornirano, cbKlijent, cbAutomobil, cbZaduzio, cbRazduzio);
            }
            else
            {
                rezultat = kki.SacuvajNovoRentiranje(txtRentiranjeID, dtpDatumZaduzenja, dtpDatumRazduzenja, txtUkupnaCena, ckbRazduzeno, ckbStornirano, cbKlijent, cbAutomobil, cbZaduzio, cbRazduzio);
            }
            if (rezultat == 1)
            {
                new UnosRentiranja(kki);
                izmena = false;
                kki.VratiNoviID(txtRentiranjeID, 3);
                kki.SrediFormu(ckbRazduzeno.Checked, dtpDatumRazduzenja, cbRazduzio, ckbStornirano);
                kki.PostaviZaposlenog(cbZaduzio);
                txtCena.Text = "";
                txtUkupnaCena.Text = "";
                ckbRazduzeno.Checked = false;
               

            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
