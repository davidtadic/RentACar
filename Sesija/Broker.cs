using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Configuration;

namespace Sesija
{
    public class Broker
    {
        OleDbConnection konekcija;
        OleDbCommand komanda;
        OleDbTransaction transakcija;
        static Broker broker;
        public static Broker DajBrokera()
        {
            if (broker == null)
            {
                broker = new Broker();
            }
            return broker;
        }
        private Broker()
        {
            string connString = @ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            konekcija = new OleDbConnection(@connString);
            
        }
        public void OtvoriKonekciju()
        {
            try
            {
                konekcija.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ZatvoriKonekciju()
        {
            konekcija.Close();
        }
        public void ZapocniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
        }
        public void PotvrdiTransakciju()
        {
            transakcija.Commit();
        }
        public void PonistiTransakciju()
        {
            transakcija.Rollback();
        }
        public bool Unesi(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "INSERT INTO " + odo.VratiTabeluZaUnos() + " VALUES " + odo.VratiVrednostiZaInsert();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<OpstiDomenskiObjekat> VratiSveObjekte(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT * FROM " + odo.VratiImeTabele();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                return odo.VratiListu(citac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int vratiMaxID(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select Max(" + odo.VratiNazivKljucnogAtributa() + ") as MaxBroj from " + odo.VratiTabeluZaUnos();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                if (citac.Read())
                {
                    try
                    {
                        int rezultat = Convert.ToInt32(citac["MaxBroj"]);
                        return rezultat + 1;
                    }
                    catch
                    {
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public OpstiDomenskiObjekat VratiObjekatPoUslovu(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT * FROM " + odo.VratiImeTabele() + " WHERE " + odo.VratiUslovZaObjekat();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                return odo.VratiObjekat(citac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<OpstiDomenskiObjekat> VratiSveObjektePoUslovu(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT * FROM " + odo.VratiImeTabele() + " WHERE " + odo.VratiUslovZaObjekat();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                return odo.VratiListu(citac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Obrisi(OpstiDomenskiObjekat odo)
        {
            try
            {

                string upit = "DELETE  FROM " + odo.VratiTabeluZaUnos() + " WHERE " + odo.VratiKljucniAtribut();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Azuriraj(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "UPDATE " + odo.VratiTabeluZaUnos() + " SET " + odo.VratiVrednostiZaAzuriranje() + " WHERE " + odo.VratiKljucniAtribut();
                OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Storniraj(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "UPDATE " + odo.VratiTabeluZaUnos() + " SET " + odo.VratiVrednostiZaStorniranje() + " WHERE " + odo.VratiKljucniAtribut();
                OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
