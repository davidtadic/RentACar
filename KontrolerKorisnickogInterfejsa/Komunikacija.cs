using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Domen;
using KontorlerAplikacioneLogike;

namespace KontrolerKorisnickogInterfejsa
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;


        public bool PoveziSeSaServerom()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 50000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<String> VratiImenaZaposlenih()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = (int)Operacije.VratiImenaZaposlenih;
                formater.Serialize(tok, transfer);
                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<String>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Zaposleni PrijaviZaposlenog(Zaposleni z)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = z;
                transfer.Operacija = (int)Operacije.PrijaviZaposlenog;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as Zaposleni;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<Mesto> VratiSvaMesta()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = (int)Operacije.VratiMesta;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Mesto>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int VratiNoviID(OpstiDomenskiObjekat odo)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = odo;
                transfer.Operacija = (int)Operacije.VratiNoviID;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Unesi(OpstiDomenskiObjekat odo)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = odo;
                transfer.Operacija = (int)Operacije.Unesi;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Klijent> PronadjiKlijente(String kriterijum)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = kriterijum;
                transfer.Operacija = (int)Operacije.PronadjiKlijente;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Klijent>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Klijent> PronadjiKlijente()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = (int)Operacije.PronadjiKlijente;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Klijent>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ObrisiKlijenta(Klijent k)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = k;
                transfer.Operacija = (int)Operacije.ObrisiKlijenta;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AzurirajKlijenta(Klijent k)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = k;
                transfer.Operacija = (int)Operacije.AzurirajKlijenta;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Proizvodjac> VratiSveProizvodjace()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = (int)Operacije.VratiProizvodjace;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Proizvodjac>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Automobil> PronadjiAutomobil(String kriterijum)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = kriterijum;
                transfer.Operacija = (int)Operacije.PronadjiAutomobile;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Automobil>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Rentiranje> PronadjiRentiranja(Klijent kriterijum)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = kriterijum;
                transfer.Operacija = (int)Operacije.PronadjiRentiranja;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Rentiranje>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<Klijent> VratiSveKlijente()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = (int)Operacije.VratiKlijente;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Klijent>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<Automobil> VratiSveAutomobile()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = (int)Operacije.VratiAutomobile;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Automobil>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<Rentiranje> VratiSvaRenitranja()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = (int)Operacije.VratiRentiranja;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Rentiranje>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Zaposleni> PronadjiZaposlenog(string kriterijum)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = kriterijum;
                transfer.Operacija = (int)Operacije.PronadjiZaposlenog;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Zaposleni>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AzurirajRentiranje(Rentiranje r)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = r;
                transfer.Operacija = (int)Operacije.AzurirajRentiranje;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int StornirajRentiranje(Rentiranje r)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = r;
                transfer.Operacija = (int)Operacije.StornirajRentiranje;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
