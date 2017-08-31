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
    public partial class PregledKlijenata : Form
    {
        KKInterfejsa kki;
        UnosRentiranja ur;


        public PregledKlijenata(KKInterfejsa kontroler)
        {
            InitializeComponent();
            kki = kontroler;
        }

        public PregledKlijenata(KKInterfejsa kontroler, UnosRentiranja forma)
        {
            InitializeComponent();
            kki = kontroler;
            ur = forma;
            kki.SrediFormuKlijenti(btnIzmeni, btnObrisi, btnIzadji);
        }



        private void PregledKlijenata_Load(object sender, EventArgs e)
        {
           // string location = ConfigurationManager.AppSettings["ClientImage"].ToString();
            //pcbKlijent.Image = Image.FromFile(@location);
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            kki.PronadjiKlijenta(txtKriterijum, dgvRezultati, null);
            dgvRezultati.Visible = true;
           
            btnIzadji.Visible = true;
            btnIzmeni.Visible = true;
            btnObrisi.Visible = true;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.ObrisiKlijenta(dgvRezultati, txtKriterijum);
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistem je pronasao podatke o klijentu");
            new UnosKlijenta(kki, dgvRezultati).ShowDialog();
            kki.PronadjiKlijenta(txtKriterijum, dgvRezultati, null);
        }

        private void btnSviKlijenti_Click(object sender, EventArgs e)
        {
            kki.PrikaziSveKlijente(dgvRezultati);
            dgvRezultati.Visible = true;
            btnIzadji.Visible = true;
            btnObrisi.Visible = true;
            btnIzmeni.Visible = true;
        }

        


       
    }
}
