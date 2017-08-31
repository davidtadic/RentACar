using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class TransferKlasa
    {
        private Object transferObjekat;
        private int operacija;
        private int signal;

        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }

        public int Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }

        public int Signal
        {
            get { return signal; }
            set { signal = value; }
        }

    }

    public enum Operacije
    {
        VratiImenaZaposlenih = 1, PrijaviZaposlenog, Unesi, VratiNoviID, VratiMesta, PronadjiKlijente, ObrisiKlijenta, AzurirajKlijenta, VratiProizvodjace, PronadjiAutomobile, PronadjiRentiranja, VratiKlijente, PronadjiZaposlenog, AzurirajRentiranje, StornirajRentiranje, VratiAutomobile, VratiRentiranja, KRAJ
    }
}
