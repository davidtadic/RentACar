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
    public partial class UnosKlijenta : Form
    {
        KKInterfejsa kki;
        bool izmena;

        public UnosKlijenta(KKInterfejsa kontroler)
        {
            InitializeComponent();
            kki = kontroler;
            izmena = false;
            kki.VratiSvaMesta(cbMesta);
            kki.VratiNoviID(txtID, 1);
        }

        public UnosKlijenta(KKInterfejsa kontroler, DataGridView dgvRezultati)
        {
            InitializeComponent();
            kki = kontroler;
            izmena = true;
            kki.PopuniZaIzmenuKlijenta(dgvRezultati, cbMesta, txtID, txtIme, txtPrezime, txtJMBG, txtTel, txtLK);
        }

        private void UnosKlijenta_Load(object sender, EventArgs e)
        {
           // string location = ConfigurationManager.AppSettings["AddClientImage"].ToString();
            //pbLogo.Image = Image.FromFile(@location);
            txtJMBG.MaxLength = 13;
            txtLK.MaxLength = 9;

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            int rezultat;

            if (izmena)
            {
                rezultat = kki.IzmeniKlijenta(txtID, txtIme, txtPrezime, txtJMBG, txtTel, txtLK, cbMesta);
            }
            else
            {
                rezultat = kki.SacuvajNovogKlijenta(txtID, txtIme, txtPrezime, txtJMBG, txtTel, txtLK, cbMesta);
            }
            if (rezultat == 1) { this.Dispose(); }
        }

        private void btnSacuvaj1_Click(object sender, EventArgs e)
        {
            int rezultat;

            if (izmena)
            {
                rezultat = kki.IzmeniKlijenta(txtID, txtIme, txtPrezime, txtJMBG, txtTel, txtLK, cbMesta);
            }
            else
            {
                rezultat = kki.SacuvajNovogKlijenta(txtID, txtIme, txtPrezime, txtJMBG, txtTel, txtLK, cbMesta);
            }
            if (rezultat == 1)
            {
                new UnosKlijenta(kki);
                izmena = false;
                kki.VratiNoviID(txtID, 1);
                kki.VratiSvaMesta(cbMesta);
                kki.OcistiUnosKlijenta(txtIme, txtPrezime, txtJMBG, txtTel, txtLK);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
