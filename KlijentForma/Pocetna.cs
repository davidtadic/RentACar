using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using KontrolerKorisnickogInterfejsa;
using System.Configuration;

namespace KlijentForma
{
    public partial class Pocetna : Form
    {
        KKInterfejsa kki;
       
        public Pocetna()
        {
            InitializeComponent();
            kki = new KKInterfejsa();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            new PrijavaZaposlenog(kki).ShowDialog();
            kki.PostaviZaposlenog(cmbZaposleni);
        }

        private void unosNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosKlijenta(kki).ShowDialog();
        }

        private void pregledKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PregledKlijenata(kki).ShowDialog();
        }

        private void unosNovogAutomobilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosAutomobila(kki).ShowDialog();
        }

        private void pregledAutomobilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PregledAutomobila(kki).ShowDialog();
        }

        private void unosNovogRentiranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosRentiranja(kki).ShowDialog();
        }

        private void pregledRentiranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PregledRentiranja(kki).ShowDialog();
        }

        private void btnPromeniZaposlenog_Click(object sender, EventArgs e)
        {
            new PrijavaZaposlenog(kki).ShowDialog();
            kki.PostaviZaposlenog(cmbZaposleni);
        }

    }
}
