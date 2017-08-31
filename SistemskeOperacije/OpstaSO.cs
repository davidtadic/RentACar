using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using Sesija;


namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        Broker broker;

        public OpstaSO()
        {
            broker = Broker.DajBrokera();
        }

        public object IzvrsiSO(OpstiDomenskiObjekat odo)
        {
            object rezultat = null;

            broker.OtvoriKonekciju();
            broker.ZapocniTransakciju();

            try
            {
                rezultat = Izvrsi(odo, broker);
                broker.PotvrdiTransakciju();
            }
            catch (Exception ex)
            {
                broker.PonistiTransakciju();
                throw ex;
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }

            return rezultat;
        }

        public virtual object Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
        {
            return null;
        }

    }
}
