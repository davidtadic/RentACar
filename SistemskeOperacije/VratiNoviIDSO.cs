using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sesija;
using Domen;

namespace SistemskeOperacije
{
    public class VratiNoviIDSO: OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
        {
            return broker.vratiMaxID(odo);
        }
    }
}
