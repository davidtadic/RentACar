using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KontorlerAplikacioneLogike;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KontrolerKorisnickogInterfejsa
{
    public class KKInterfejsa
    {
        Zaposleni tekuciZaposleni;
        Komunikacija komunikacija;

        public Zaposleni TekuciZaposleni
        {
            get { return tekuciZaposleni; }
            set { tekuciZaposleni = value; }
        }

        public KKInterfejsa()
        {
            komunikacija = new Komunikacija();
            bool status = komunikacija.PoveziSeSaServerom();
            if (status == true)
            {
                MessageBox.Show("Uspešno povezivanje na server!");
            }
            else
            {
                MessageBox.Show("Neuspešno povezivanje na server!");
                Application.Exit();
            }
        }

        public void VratiImenaZaposlenih(ComboBox cmbKorIme)
        {
            cmbKorIme.DataSource = komunikacija.VratiImenaZaposlenih();
        }

        public int PrijaviZaposlenog(ComboBox cbKorIme, TextBox tbKorSif)
        {

            string korime = (string)cbKorIme.SelectedItem;
            string korsif = tbKorSif.Text;

            Zaposleni z = new Zaposleni();
            z.KorisnickoIme = korime;
            z.KorisnickaSifra = korsif;

            if (korime.Equals("") || korsif.Equals(""))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return 0;
            }
            else
            {
                Zaposleni zaposleni = komunikacija.PrijaviZaposlenog(z);

                if (zaposleni != null)
                {
                    MessageBox.Show("Uspesno ste se prijavili na sistem.");
                    tekuciZaposleni = zaposleni;
                    return 1;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da pronadje zaposlenog na osnovu unetih vrednosti", "Greska!");
                    return 0;
                }
            }
        }

        public void VratiSvaMesta(ComboBox cbMesta)
        {
            cbMesta.DataSource = komunikacija.VratiSvaMesta();
            cbMesta.DisplayMember = "Naziv";

        }

        public void VratiNoviID(TextBox tbID, int tip)
        {
            if (tip == 1)
            { tbID.Text = komunikacija.VratiNoviID(new Klijent()).ToString(); }
            if (tip == 2)
            { tbID.Text = komunikacija.VratiNoviID(new Automobil()).ToString(); }
            if (tip == 3)
            { tbID.Text = komunikacija.VratiNoviID(new Rentiranje()).ToString(); }
        }

        public int SacuvajNovogKlijenta(TextBox tbID, TextBox tbIme, TextBox tbPrezime, TextBox tbJMBG, TextBox tbTel, TextBox tbLK, ComboBox cbMesta)
        {
            Regex r = new Regex("[0-9]");
            Regex rjmbg = new Regex("^[0-9]{13}");
            String jmbg = tbJMBG.ToString();
            String lk = tbLK.ToString();

            if (r.IsMatch(jmbg))
            {
                if (r.IsMatch(lk))
                {
                    Klijent k = new Klijent();
                    k.KlijentID = tbID.Text;
                    k.Ime = tbIme.Text;
                    k.Prezime = tbPrezime.Text;
                    k.Jmbg = tbJMBG.Text;
                    k.KontaktTel = tbTel.Text;
                    k.BrLicneKarte = tbLK.Text;
                    k.Mesto = cbMesta.SelectedItem as Mesto;

                    try
                    {
                        int rezultat = komunikacija.Unesi(k);
                        if (rezultat > 0)
                        {
                            MessageBox.Show("Sistem je zapamtio klijenta!");
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("Sistem ne moze da zapamti klijenta!");
                            return 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Vec postoji taj klijent u bazi!" + ex.Message);
                        return 0;
                    }
                }

                else
                {
                    MessageBox.Show("Niste pravilno uneli broj licne karte");
                    return 0;

                }
            }

            else
            {
                MessageBox.Show("Niste pravilno uneli JMBG");
                return 0;
            }





        }

        public void PronadjiKlijenta(TextBox tbKriterijum, DataGridView dgvRezultati, ComboBox cbKlijenti)
        {
            string kriterijum = tbKriterijum.Text;


            List<Klijent> rezultati = komunikacija.PronadjiKlijente(kriterijum);

            if (rezultati.Count > 0)
            {
                if (dgvRezultati != null) dgvRezultati.DataSource = rezultati;
                if (cbKlijenti != null) cbKlijenti.DataSource = rezultati;
                MessageBox.Show("Sistem je pronasao klijente po zadatoj vrednosti");
            }
            else
            {
                MessageBox.Show("Sistem ne može da nađe klijente po zadatim vrednostima!");
                if (dgvRezultati != null) dgvRezultati.DataSource = null;
                if (cbKlijenti != null) cbKlijenti.DataSource = null;
            }

        }

        public void ObrisiKlijenta(DataGridView dgvRezultati, TextBox kriterijum)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da želite da obrišete klijenta?", "Pažnja!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Klijent k = dgvRezultati.CurrentRow.DataBoundItem as Klijent;

                int rezultat = komunikacija.ObrisiKlijenta(k);
                if (rezultat > 0)
                {
                    MessageBox.Show("Sistem je obrisao klijenta");
                    PronadjiKlijenta(kriterijum, dgvRezultati, null);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise klijenta");
                }
            }
            else if (dr == DialogResult.Cancel) { }
        }

        public void OcistiUnosKlijenta(TextBox tbIme, TextBox tbPrezime, TextBox tbJMBG, TextBox tbTel, TextBox tbLK)
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbJMBG.Text = "";
            tbTel.Text = "";
            tbLK.Text = "";
        }

        public void PopuniZaIzmenuKlijenta(DataGridView dgvRezultati, ComboBox cbMesta, TextBox tbID, TextBox tbIme, TextBox tbPrezime, TextBox tbJMBG, TextBox tbTel, TextBox tbLK)
        {
            Klijent k = dgvRezultati.CurrentRow.DataBoundItem as Klijent;
            tbID.Text = k.KlijentID;
            tbIme.Text = k.Ime;
            tbPrezime.Text = k.Prezime;
            tbJMBG.Text = k.Jmbg;
            tbTel.Text = k.KontaktTel;
            tbLK.Text = k.BrLicneKarte;
            VratiSvaMesta(cbMesta);

        }

        public int IzmeniKlijenta(TextBox tbId, TextBox tbIme, TextBox tbPrezime, TextBox tbJMBG, TextBox tbTel, TextBox tbLK, ComboBox cbMesta)
        {
            Klijent k = new Klijent();
            k.KlijentID = tbId.Text;
            k.Ime = tbIme.Text;
            k.Prezime = tbPrezime.Text;
            k.Jmbg = tbJMBG.Text;
            k.KontaktTel = tbTel.Text;
            k.BrLicneKarte = tbLK.Text;
            k.Mesto = cbMesta.SelectedItem as Mesto;

            try
            {
                int rezultat = komunikacija.AzurirajKlijenta(k);
                if (rezultat > 0)
                {
                    MessageBox.Show("Uspesno ste izmenili klijenta!");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da izmeni klijenta");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemi sa bazom, pokusajte ponovo!" + ex.Message);
                return 0;
            }
        }

        public void VratiSveProizvodjace(ComboBox cbProizvodjaci)
        {
            cbProizvodjaci.DataSource = komunikacija.VratiSveProizvodjace();
            cbProizvodjaci.DisplayMember = "Naziv";
        }

        public int SacuvajNoviAutomobil(TextBox tbAutomobilID, TextBox tbNaziv, TextBox tbGodina, TextBox tbRegistarskiBroj, TextBox tbCena, ComboBox cbProizvodjaci)
        {

            Regex rn = new Regex("[0-9]");
            Regex rg = new Regex("/d{4}");
            String godina = tbGodina.ToString();
            String cena = tbCena.ToString();

            if (rn.IsMatch(godina))
            {
                if (rn.IsMatch(cena))
                {
                    Automobil auto = new Automobil();
                    auto.AutomobilID = tbAutomobilID.Text;
                    auto.ModelAutomobila = tbNaziv.Text;
                    auto.GodinaProizvodnje = Convert.ToInt32(tbGodina.Text);
                    auto.RegistarskiBroj = tbRegistarskiBroj.Text;
                    auto.CenaRentiranja = Convert.ToDouble(tbCena.Text);
                    auto.Proizvodjac = cbProizvodjaci.SelectedItem as Proizvodjac;
                    try
                    {
                        int rezultat = komunikacija.Unesi(auto);
                        if (rezultat > 0)
                        {
                            MessageBox.Show("Sistem je zapamtio automobil!");
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("Sistem ne moze da zapamti automobil!");
                            return 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Vec postoji taj automobil u bazi!" + ex.Message);
                        return 0;
                    }
                }

                else
                {
                    MessageBox.Show("Niste pravilno uneli cenu");
                    return 0;
                }
            }

            else
            {
                MessageBox.Show("Niste pravilno uneli godinu proizvodnje");
                return 0;
            }


        }

        public void PronadjiAutomobil(TextBox tbKriterijum, DataGridView dgvAutomobili, ComboBox cbAutomobil)
        {
            string kriterijum = tbKriterijum.Text;
            List<Automobil> rezultati = komunikacija.PronadjiAutomobil(kriterijum);

            if (rezultati.Count > 0)
            {
                if (dgvAutomobili != null) dgvAutomobili.DataSource = rezultati;
                if (cbAutomobil != null) cbAutomobil.DataSource = rezultati;
                MessageBox.Show("Sistem je pronašao automobil po zadatoj vrednosti");
            }
            else
            {
                MessageBox.Show("Sistem ne može da nađe automobil po zadatoj vrednosti!");
                if (dgvAutomobili != null) dgvAutomobili.DataSource = null;
                if (cbAutomobil != null) cbAutomobil.DataSource = null;
            }



        }

        public void OcistiUnosAutomobila(TextBox tbNaziv, TextBox tbGodina, TextBox tbRegistarski, TextBox tbCena)
        {
            tbNaziv.Text = "";
            tbGodina.Text = "";
            tbRegistarski.Text = "";
            tbCena.Text = "";
        }

        public void PopuniDetaljeZaAutomobil(DataGridView dgvAutomobili, TextBox tbAutomobilID, TextBox tbNaziv, TextBox tbRegistarski, TextBox tbGodina, TextBox tbCena, ComboBox cbProizvodjaci, Button btnSacuvaj, Button btnSacuvaj1, Button btnOdustani)
        {
            btnSacuvaj.Visible = false;
            btnSacuvaj1.Visible = false;
            btnOdustani.Text = "U redu";
            Automobil auto = dgvAutomobili.CurrentRow.DataBoundItem as Automobil;
            tbAutomobilID.Text = auto.AutomobilID;
            tbNaziv.Text = auto.ModelAutomobila;
            tbRegistarski.Text = auto.RegistarskiBroj;
            tbGodina.Text = auto.GodinaProizvodnje.ToString();
            tbCena.Text = auto.CenaRentiranja.ToString();
            List<Proizvodjac> listapom = new List<Proizvodjac>();
            listapom.Add(auto.Proizvodjac);
            cbProizvodjaci.DataSource = listapom;
        }

        public void SrediFormuKlijenti(Button btnIzmeni, Button btnObrisi, Button btnIzaberi)
        {
            btnIzmeni.Visible = false;
            btnObrisi.Visible = false;
            btnIzaberi.Visible = true;
        }

        public void PostaviIzborUTextbox(DataGridView dgvRezultati, ComboBox cb)
        {
            OpstiDomenskiObjekat odo = dgvRezultati.CurrentRow.DataBoundItem as OpstiDomenskiObjekat;
            List<OpstiDomenskiObjekat> listapom = new List<OpstiDomenskiObjekat>();
            listapom.Add(odo);
            cb.DataSource = listapom;
            cb.DisplayMember = odo.ToString();
        }

        public void SrediFormuPrikazAutomobila(Button btnDetalji, Button btnIzadji)
        {
            btnDetalji.Visible = false;
            btnIzadji.Visible = true;
        }

        public void PostaviZaposlenog(ComboBox cb)
        {
            List<OpstiDomenskiObjekat> listapom = new List<OpstiDomenskiObjekat>();
            listapom.Add(tekuciZaposleni);
            cb.DataSource = listapom;
        }

        public void SrediFormu(DateTimePicker dtpDatumRazduzenja, CheckBox ckbStornirano)
        {
            ckbStornirano.Visible = false;
            dtpDatumRazduzenja.Text = "";
        }

        public void PostaviCenu(ComboBox cb, TextBox tbCena)
        {
            Automobil m = cb.SelectedItem as Automobil;
            tbCena.Text = m.CenaRentiranja.ToString();
        }

        public void SrediFormu(bool vrednost, DateTimePicker dtpDatumRazduzenja, ComboBox cbRazduzio, CheckBox ckbStornirano)
        {
            dtpDatumRazduzenja.Enabled = vrednost;
            cbRazduzio.Enabled = vrednost;
            PostaviZaposlenog(cbRazduzio);
            ckbStornirano.Visible = false;
            if (vrednost == false) { cbRazduzio.DataSource = null; }
        }

        public void IzracunajCenu(DateTimePicker dtpDatumRazduzenja, DateTimePicker dtpDatumZaduzenja, TextBox tbCena, TextBox tbUkupnaCena)
        {
            if (!tbCena.Text.Equals("") && dtpDatumRazduzenja.Enabled == true)
            {
                int brojDana = Convert.ToInt32((dtpDatumRazduzenja.Value - dtpDatumZaduzenja.Value).TotalDays);
                double ukcena = Convert.ToDouble(tbCena.Text) * brojDana;
                tbUkupnaCena.Text = ukcena.ToString();
            }
            else
            {
                tbUkupnaCena.Text = "";
            }
        }

        public int SacuvajNovoRentiranje(TextBox tbRentiranjeID, DateTimePicker dtpDatumZaduzenja, DateTimePicker dtpDatumRazduzenja, TextBox tbUkupnaCena, CheckBox ckbRazduzeno, CheckBox ckbStornirano, ComboBox cbKlijent, ComboBox cbAutomobil, ComboBox cbZaduzio, ComboBox cbRazduzio)
        {
            if (cbKlijent.SelectedItem == null || cbAutomobil.SelectedItem == null)
            {
                MessageBox.Show("Proverite da li ste uneli sva polja!");
                return 0;
            }
            List<Rentiranje> Listarentiranja = new List<Rentiranje>();
            Listarentiranja = komunikacija.VratiSvaRenitranja();
            Klijent k = cbKlijent.SelectedItem as Klijent;
            int a = 0;
            string datum = Convert.ToString(dtpDatumZaduzenja.Value);
            DateTime danasnji = DateTime.Now.Date;
            DateTime d = dtpDatumZaduzenja.Value.Date;
            foreach (Rentiranje rent in Listarentiranja)
            {
                if (rent.Klijent.KlijentID == k.KlijentID && d == danasnji && rent.Automobil.AutomobilID==((Automobil)cbAutomobil.SelectedItem).AutomobilID)
                {
                    a++;
                }
            }


            Rentiranje r = new Rentiranje();
            r.RentiranjeID = tbRentiranjeID.Text;

            r.DatumZaduzenja = dtpDatumZaduzenja.Value;
            r.DatumRazduzenja = null;
            r.UkupnaCena = 0;
            r.Stornirano = ckbStornirano.Checked;
            r.Razduzeno = ckbRazduzeno.Checked;
            r.Klijent = cbKlijent.SelectedItem as Klijent;
            r.Automobil = cbAutomobil.SelectedItem as Automobil;
            r.ZaduzioID = cbZaduzio.SelectedItem as Zaposleni;
            r.RazduzioID = new Zaposleni();
            r.RazduzioID.ZaposleniID = string.Empty;

            if (ckbRazduzeno.Checked)
            {
                r.DatumRazduzenja = dtpDatumRazduzenja.Value;
                r.UkupnaCena = Convert.ToDouble(tbUkupnaCena.Text);
                r.Razduzeno = ckbRazduzeno.Checked;
                r.RazduzioID = cbZaduzio.SelectedItem as Zaposleni;
            }

            if (a == 0)
            {
                try
                {
                    int rezultat = komunikacija.Unesi(r);
                    if (rezultat > 0)
                    {
                        MessageBox.Show("Sistem je zapamtio rentiranje!");
                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da zapamti rentiranje!");
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da zapamti rentiranje!" + ex.Message);
                    return 0;
                }

            }
            else
            {
                MessageBox.Show("Vec postoji to rentiranje u bazi!" );
                return 0;
            }
        }

        public void PronadjiRentiranje(ComboBox cbKriterijum, DataGridView dgvRentiranja)
        {
            Klijent kriterijum = cbKriterijum.SelectedItem as Klijent;


            if ((!kriterijum.Equals("")))
            {
                List<Rentiranje> rezultati = komunikacija.PronadjiRentiranja(kriterijum);

                if (rezultati.Count > 0)
                {
                    dgvRentiranja.DataSource = rezultati;

                    MessageBox.Show("Sistem je pronasao rentiranja po zadatoj vrednosti");
                }
                else
                {
                    MessageBox.Show("Sistem ne može da nađe rentiranja po zadatim vrednostima!");
                    dgvRentiranja.DataSource = null;
                }
            }
        }

        public void VratiSveKlijente(ComboBox cbKlijent)
        {
            cbKlijent.DataSource = komunikacija.VratiSveKlijente();
        }

        public void VratiSveAutomobile(DataGridView dgvAutomobili)
        {
            dgvAutomobili.DataSource = komunikacija.VratiSveAutomobile();
        }

        public void VratiSveAutomobile(ComboBox cbAutomobili)
        {
            cbAutomobili.DataSource = komunikacija.VratiSveAutomobile();
        }

        public void PrikaziSveKlijente(DataGridView dgvRezultati)
        {
            dgvRezultati.DataSource = komunikacija.VratiSveKlijente();
        }

        public void VratiSvaRentiranja(DataGridView dgvRentiranja)
        {

            dgvRentiranja.DataSource = komunikacija.VratiSvaRenitranja();
        }

        public void PopuniZaIzmenuRentiranja(DataGridView dgvRentiranja, TextBox tbRentiranjeID, DateTimePicker dtpDatumZaduzenja, DateTimePicker dtpDatumRazduzenja, CheckBox ckbRazduzeno, CheckBox ckbStornirano, ComboBox cbKlijent, ComboBox cbAutomobili, ComboBox cbZaduzio, ComboBox cbRazduzio, TextBox tbCena, TextBox tbUkupnaCena)
        {
            Rentiranje r = dgvRentiranja.CurrentRow.DataBoundItem as Rentiranje;
            tbRentiranjeID.Text = r.RentiranjeID;
            dtpDatumZaduzenja.Value = r.DatumZaduzenja;
            if (r.DatumRazduzenja != null)
            {
                dtpDatumRazduzenja.Value = r.DatumRazduzenja.GetValueOrDefault();
            }
            else
            {
                dtpDatumRazduzenja.Enabled = false;
            }


            ckbRazduzeno.Checked = r.Razduzeno;

            ckbStornirano.Checked = r.Stornirano;

            TextBox tb = new TextBox();
            tb.Visible = false;
            tb.Text = r.Klijent.KlijentID;
            PronadjiKlijenta(tb, null, cbKlijent);
            VratiSveAutomobile(cbAutomobili);
            cbAutomobili.SelectedIndex = Convert.ToInt32(r.Automobil.AutomobilID)-1;
            Automobil a = cbAutomobili.SelectedItem as Automobil;
            tbCena.Text = a.CenaRentiranja.ToString();

            PronadjiZaposlenog(r.ZaduzioID.ZaposleniID, cbZaduzio);
            PronadjiZaposlenog(r.RazduzioID.ZaposleniID, cbRazduzio);

            tbUkupnaCena.Text = r.UkupnaCena.ToString();
            if (r.Stornirano == true)
            {
                ckbStornirano.Visible = true;
                dtpDatumZaduzenja.Enabled = false;
                dtpDatumRazduzenja.Enabled = false;
                ckbRazduzeno.Enabled = false;
                cbKlijent.Enabled = false;
                cbAutomobili.Enabled = false;
                cbZaduzio.Enabled = false;
                cbRazduzio.Enabled = false;
                tbUkupnaCena.Enabled = false;
            }
        }

        private void PronadjiZaposlenog(string kriterijum, ComboBox cbZaposleni)
        {
            if (!kriterijum.Equals(""))
            {
                List<Zaposleni> rezultati = komunikacija.PronadjiZaposlenog(kriterijum);

                if (rezultati.Count > 0)
                {
                    cbZaposleni.DataSource = rezultati;
                }
                else
                {
                    MessageBox.Show("Sistem ne može da nađe zaposlenog po zadatim vrednostima!");
                    cbZaposleni.DataSource = null;
                }
            }
        }

        public int IzmeniRentiranje(TextBox tbRentiranjeID, DateTimePicker dtpDatumZaduzenja, DateTimePicker dtpDatumRazduzenja, TextBox tbUkupnaCena, CheckBox ckbRazduzeno, CheckBox ckbStornirano, ComboBox cbKlijent, ComboBox cbAutomobili, ComboBox cbZaduzio, ComboBox cbRazduzio)
        {
            if (cbKlijent.SelectedItem == null || cbAutomobili.SelectedItem == null)
            {
                MessageBox.Show("Proverite da li ste uneli sva polja!");
                return 0;
            }
            Rentiranje r = new Rentiranje();
            r.RentiranjeID = tbRentiranjeID.Text;

            r.DatumZaduzenja = dtpDatumZaduzenja.Value;
            r.DatumRazduzenja = null;
            r.UkupnaCena = 0;
            r.Stornirano = ckbStornirano.Checked;
            r.Razduzeno = ckbRazduzeno.Checked;
            r.Klijent = cbKlijent.SelectedItem as Klijent;
            r.Automobil = cbAutomobili.SelectedItem as Automobil;
            r.ZaduzioID = cbZaduzio.SelectedItem as Zaposleni;
            r.RazduzioID = new Zaposleni();
            r.RazduzioID.ZaposleniID = string.Empty;

            if (ckbRazduzeno.Checked)
            {
                r.DatumRazduzenja = dtpDatumRazduzenja.Value;
                r.UkupnaCena = Convert.ToDouble(tbUkupnaCena.Text);
                r.Razduzeno = ckbRazduzeno.Checked;
                r.RazduzioID = cbZaduzio.SelectedItem as Zaposleni;
            }

            try
            {
                int rezultat = komunikacija.AzurirajRentiranje(r);
                if (rezultat > 0)
                {
                    MessageBox.Show("Sistem je zapamtio rentiranje");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Sistem je zapamtio rentiranje");
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemi sa bazom, pokusajte ponovo!" + ex.Message);
                return 0;
            }
        }

        public void StornirajRentiranje(DataGridView dgvRentiranja)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da stornirate rentiranje?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Rentiranje r = dgvRentiranja.CurrentRow.DataBoundItem as Rentiranje;

                int rezultat = komunikacija.StornirajRentiranje(r);
                if ((rezultat) > 0)
                {
                    MessageBox.Show("Sistem je stornirao rentiranje");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da stornira rentiranje");
                }
            }
            else if (dr == DialogResult.Cancel) { }
        }
    }
}

