using Domen;
using KontorlerAplikacioneLogike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerForma
{
    public class ObradaZahtevaKlijenta
    {
        NetworkStream tok;
        BinaryFormatter formater;
        KontrolerAL kal;


        public ObradaZahtevaKlijenta(NetworkStream tok)
        {
            formater = new BinaryFormatter();
            this.tok = tok;
            kal = new KontrolerAL();

            ThreadStart ts = obradaPodataka;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        private void obradaPodataka()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)(Operacije.KRAJ))
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    operacija = transfer.Operacija;
                    switch (operacija)
                    {
                        case (int)Operacije.VratiImenaZaposlenih:
                            transfer.TransferObjekat = kal.VratiImenaZaposlenih();
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.PrijaviZaposlenog:
                            transfer.TransferObjekat = kal.PrijaviZaposlenog(transfer.TransferObjekat as Zaposleni);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.Unesi:
                            transfer.TransferObjekat = kal.Unesi(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.VratiNoviID:
                            transfer.TransferObjekat = kal.VratiNoviID(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.VratiMesta:
                            transfer.TransferObjekat = kal.VratiSvaMesta();
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.PronadjiKlijente:
                            transfer.TransferObjekat = kal.PronadjiKlijente(transfer.TransferObjekat as String);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.ObrisiKlijenta:
                            transfer.TransferObjekat = kal.ObrisiKlijenta(transfer.TransferObjekat as Klijent);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.AzurirajKlijenta:
                            transfer.TransferObjekat = kal.AzurirajKlijenta(transfer.TransferObjekat as Klijent);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.VratiProizvodjace:
                            transfer.TransferObjekat = kal.VratiSveProizvodjace();
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.PronadjiAutomobile:
                            transfer.TransferObjekat = kal.PronadjiAutomobil(transfer.TransferObjekat as String);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.PronadjiRentiranja:
                            transfer.TransferObjekat = kal.PronadjiRentiranja(transfer.TransferObjekat as Klijent);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.VratiKlijente:
                            transfer.TransferObjekat = kal.VratiSveKlijente();
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.PronadjiZaposlenog:
                            transfer.TransferObjekat = kal.PronadjiZaposlenog(transfer.TransferObjekat as String);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.AzurirajRentiranje:
                            transfer.TransferObjekat = kal.AzurirajRentiranje(transfer.TransferObjekat as Rentiranje);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.StornirajRentiranje:
                            transfer.TransferObjekat = kal.StornirajRentiranje(transfer.TransferObjekat as Rentiranje);
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.VratiAutomobile:
                            transfer.TransferObjekat = kal.VratiAutomobile();
                            formater.Serialize(tok, transfer);
                            break;
                        case (int)Operacije.VratiRentiranja:
                            transfer.TransferObjekat = kal.VratiSvaRentiranja();
                            formater.Serialize(tok, transfer);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nit je prekinuta:" + ex.Message);
            }
        }
    }
}
