using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using SistemskeOperacije;
namespace KontorlerAplikacioneLogike
{
    public class KontrolerAL
    {
        public List<String> VratiImenaZaposlenih()
        {
            VratiSveSO vratiZaposlene = new VratiSveSO();

            List<OpstiDomenskiObjekat> listaPomocna = vratiZaposlene.IzvrsiSO(new Zaposleni()) as List<OpstiDomenskiObjekat>;
            List<String> listaZaposlenih = new List<String>();

            foreach (Zaposleni z in listaPomocna)
            {
                listaZaposlenih.Add(z.KorisnickoIme);
            }
            return listaZaposlenih;
        }
        public Zaposleni PrijaviZaposlenog(Zaposleni z)
        {
            PrijaviZaposlenogSO prijavi = new PrijaviZaposlenogSO();
            Zaposleni zap = prijavi.IzvrsiSO(z) as Zaposleni;

            return zap;
        }
        public int Unesi1(OpstiDomenskiObjekat odo)
        {
            UnesiSO unesi = new UnesiSO();
            Rentiranje re = new Rentiranje();
            re.RentiranjeID = odo.VratiKljucniAtribut();

            List<Rentiranje> ListaRentiranja = new List<Rentiranje>();
            ListaRentiranja = VratiSvaRentiranja();
            foreach (Rentiranje r in ListaRentiranja)
            {
                if (r.RentiranjeID == re.RentiranjeID)
                {
                    re.DatumZaduzenja = r.DatumZaduzenja;
                    re.Klijent = r.Klijent;
                }
            }

            foreach (Rentiranje rent in ListaRentiranja)
            {
                if (rent.Klijent.KlijentID == re.Klijent.KlijentID && rent.DatumZaduzenja == DateTime.Now.Date)
                    return 0;
                else
                {
                    Convert.ToInt32(unesi.IzvrsiSO(odo));
                }

            }

            return Convert.ToInt32(unesi.IzvrsiSO(odo));
        }
        public int Unesi(OpstiDomenskiObjekat odo)
        {
            UnesiSO unesi = new UnesiSO();
            return Convert.ToInt32(unesi.IzvrsiSO(odo));
        }
        public int SacuvajRentiranje(OpstiDomenskiObjekat odo)
        {
            UnesiSO sacuvajRentiranje = new UnesiSO();
            return Convert.ToInt32(sacuvajRentiranje.IzvrsiSO(odo));
        }
        public int VratiNoviID(OpstiDomenskiObjekat odo)
        {
            VratiNoviIDSO vrati = new VratiNoviIDSO();
            return Convert.ToInt32(vrati.IzvrsiSO(odo));
        }
        public List<Mesto> VratiSvaMesta()
        {
            VratiSveSO vratiMesta = new VratiSveSO();

            List<OpstiDomenskiObjekat> listaPomocna = vratiMesta.IzvrsiSO(new Mesto()) as List<OpstiDomenskiObjekat>;
            List<Mesto> listaMesta = new List<Mesto>();

            foreach (Mesto m in listaPomocna)
            {
                listaMesta.Add(m);
            }
            return listaMesta;
        }       
        public List<Klijent> VratiSveKlijente()
        {
            VratiSveSO vratiKlijente = new VratiSveSO();

            List<OpstiDomenskiObjekat> listaPomocna = vratiKlijente.IzvrsiSO(new Klijent()) as List<OpstiDomenskiObjekat>;
            List<Klijent> listaKlijenata = new List<Klijent>();

            foreach (Klijent k in listaPomocna)
            {
                listaKlijenata.Add(k);
            }
            return listaKlijenata;
        }
        public List<Klijent> PronadjiKlijente(string kriterijum)
        {
            Klijent kpom = new Klijent();
            kpom.KlijentID = kriterijum;
            kpom.Jmbg = kriterijum;
            kpom.Ime = kriterijum;
            kpom.Prezime = kriterijum;

            PretragaSO pretraga = new PretragaSO();

            List<OpstiDomenskiObjekat> listaPom = pretraga.IzvrsiSO(kpom) as List<OpstiDomenskiObjekat>;

            List<Klijent> listaKlijenata = new List<Klijent>();

            foreach (Klijent k in listaPom)
            {
                listaKlijenata.Add(k);
            }

            if (listaKlijenata == null)
            {
                return listaKlijenata = new List<Klijent>();
            }
            else
            {
                return listaKlijenata;
            }
        }
        public List<Klijent> PronadjiKlijente()
        {
            Klijent kpom = new Klijent();

            PretragaSO pretraga = new PretragaSO();

            List<OpstiDomenskiObjekat> listaPom = pretraga.IzvrsiSO(kpom) as List<OpstiDomenskiObjekat>;

            List<Klijent> listaKlijenata = new List<Klijent>();

            foreach (Klijent k in listaPom)
            {
                listaKlijenata.Add(k);
            }

            if (listaKlijenata == null)
            {
                return listaKlijenata = new List<Klijent>();
            }
            else
            {
                return listaKlijenata;
            }
        }
        public int ObrisiKlijenta(Klijent k)
        {
            ObrisiSO obrisi = new ObrisiSO();
            return Convert.ToInt32(obrisi.IzvrsiSO(k));
        }
        public int AzurirajKlijenta(Klijent k)
        {
            IzmeniSO izmeni = new IzmeniSO();
            return Convert.ToInt32(izmeni.IzvrsiSO(k));
        }
        public List<Automobil> PronadjiAutomobil(string kriterijum)
        {
            Automobil auto = new Automobil();
            Proizvodjac p = new Proizvodjac();

            auto.AutomobilID = kriterijum;
            auto.ModelAutomobila = kriterijum;
            auto.RegistarskiBroj = kriterijum;
            p.Naziv = kriterijum;
            auto.Proizvodjac = p;

            PretragaSO pretraga = new PretragaSO();

            List<OpstiDomenskiObjekat> listaPom = pretraga.IzvrsiSO(auto) as List<OpstiDomenskiObjekat>;

            List<Automobil> listaAutomobila = new List<Automobil>();

            foreach (Automobil a in listaPom)
            {
                listaAutomobila.Add(a);
            }

            if (listaAutomobila == null)
            {
                return listaAutomobila = new List<Automobil>();
            }
            else
            {
                return listaAutomobila;
            }
        }
        public List<Rentiranje> PronadjiRentiranja(Klijent k)
        {
            Rentiranje rentiranje = new Rentiranje();
            rentiranje.Klijent = k;
            PretragaSO pretraga = new PretragaSO();

            List<OpstiDomenskiObjekat> listaPom = pretraga.IzvrsiSO(rentiranje) as List<OpstiDomenskiObjekat>;

            List<Rentiranje> listaRentiranja = new List<Rentiranje>();

            foreach (Rentiranje r in listaPom)
            {
                listaRentiranja.Add(r);
            }

            if (listaRentiranja == null)
            {
                return listaRentiranja = new List<Rentiranje>();
            }
            else
            {
                return listaRentiranja;
            }
        }
        public List<Automobil> VratiAutomobile()
        {
            VratiSveSO vratiAutomobile = new VratiSveSO();

            List<OpstiDomenskiObjekat> listaPomocna = vratiAutomobile.IzvrsiSO(new Automobil()) as List<OpstiDomenskiObjekat>;
            List<Automobil> listaAutomobila = new List<Automobil>();

            foreach (Automobil a in listaPomocna)
            {
                listaAutomobila.Add(a);
            }
            return listaAutomobila;
        }
        public List<Rentiranje> VratiSvaRentiranja()
        {
            VratiSveSO vratiRentiranje = new VratiSveSO();

            List<OpstiDomenskiObjekat> listaPomocna = vratiRentiranje.IzvrsiSO(new Rentiranje()) as List<OpstiDomenskiObjekat>;
            List<Rentiranje> listaRentiranja = new List<Rentiranje>();

            foreach (Rentiranje r in listaPomocna)
            {
                listaRentiranja.Add(r);
            }
            return listaRentiranja;
        }
        public List<Zaposleni> VratiSveZaposlene()
        {
            VratiSveSO vratiZaposlene = new VratiSveSO();

            List<OpstiDomenskiObjekat> listaPomocna = vratiZaposlene.IzvrsiSO(new Zaposleni()) as List<OpstiDomenskiObjekat>;
            List<Zaposleni> listaZaposlenih = new List<Zaposleni>();

            foreach (Zaposleni z in listaPomocna)
            {
                listaZaposlenih.Add(z);
            }
            return listaZaposlenih;
        }
        public List<Proizvodjac> VratiSveProizvodjace()
        {
            VratiSveSO vratiProizvodjace = new VratiSveSO();

            List<OpstiDomenskiObjekat> listaPomocna = vratiProizvodjace.IzvrsiSO(new Proizvodjac()) as List<OpstiDomenskiObjekat>;
            List<Proizvodjac> listaProizvodjaca = new List<Proizvodjac>();

            foreach (Proizvodjac p in listaPomocna)
            {
                listaProizvodjaca.Add(p);
            }
            return listaProizvodjaca;
        }
        public List<Zaposleni> PronadjiZaposlenog(string kriterijum)
        {
            Zaposleni zpom = new Zaposleni();
            zpom.ZaposleniID = kriterijum;

            PretragaSO pretraga = new PretragaSO();

            List<OpstiDomenskiObjekat> listaPom = pretraga.IzvrsiSO(zpom) as List<OpstiDomenskiObjekat>;

            List<Zaposleni> listaZaposlenih = new List<Zaposleni>();

            foreach (Zaposleni z in listaPom)
            {
                listaZaposlenih.Add(z);
            }

            if (listaZaposlenih == null)
            {
                return listaZaposlenih = new List<Zaposleni>();
            }
            else
            {
                return listaZaposlenih;
            }
        }
        public int AzurirajRentiranje(Rentiranje r)
        {
            IzmeniSO izmeni = new IzmeniSO();
            return Convert.ToInt32(izmeni.IzvrsiSO(r));
        }
        public int StornirajRentiranje(Rentiranje r)
        {
            StornirajSO storniraj = new StornirajSO();
            return Convert.ToInt32(storniraj.IzvrsiSO(r));
        }
    }
}
