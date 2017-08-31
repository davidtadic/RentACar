using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class IzmeniSO:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
        {
            return broker.Azuriraj(odo);
        }
    }
}
