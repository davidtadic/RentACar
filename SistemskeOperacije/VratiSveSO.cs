using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class VratiSveSO:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
        {
            return broker.VratiSveObjekte(odo);
        }
    }
}
