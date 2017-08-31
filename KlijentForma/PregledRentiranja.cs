using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;
using Domen;
using System.Configuration;

namespace KlijentForma
{
    public partial class PregledRentiranja : Form
    {
        KKInterfejsa kki;
        
        

        public PregledRentiranja(KKInterfejsa kontroler)
        {
            InitializeComponent();
            kki = kontroler;
            kki.VratiSveKlijente(cmbKlijent);
            
            
        }

        private void PregledRentiranja_Load(object sender, EventArgs e)
        {
           // string location = ConfigurationManager.AppSettings["RentImage"].ToString();
           // pcbRent.Image = Image.FromFile(@location);
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            dgvRentiranja.Visible = true;
            btnIzmeni.Visible = true;
            btnPronadji.Visible = true;
            btnStorniraj.Visible = true;
            kki.PronadjiRentiranje(cmbKlijent, dgvRentiranja);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Rentiranje r=dgvRentiranja.CurrentRow.DataBoundItem as Rentiranje;
            if (r.Stornirano == false)
            {
                MessageBox.Show("Sistem je pronasao podatke o izabranom rentiranju");
                new UnosRentiranja(kki, dgvRentiranja).ShowDialog();
                kki.PronadjiRentiranje(cmbKlijent, dgvRentiranja);
            }

            else
            {
                MessageBox.Show("Ne mozete izmeniti stornirano rentiranje");
            }
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            kki.StornirajRentiranje(dgvRentiranja);
            kki.PronadjiRentiranje(cmbKlijent, dgvRentiranja);
        }

        private void btnSvaRentiranja_Click(object sender, EventArgs e)
        {
            kki.VratiSvaRentiranja(dgvRentiranja);
            dgvRentiranja.Visible = true;
            btnIzmeni.Visible = true;
            btnIzmeni.Visible = true;
            btnStorniraj.Visible = true;
            
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
