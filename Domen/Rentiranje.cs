using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Rentiranje : OpstiDomenskiObjekat
    {
        string rentiranjeID;

        public string RentiranjeID
        {
            get { return rentiranjeID; }
            set { rentiranjeID = value; }
        }

        DateTime datumZaduzenja;

        public DateTime DatumZaduzenja
        {
            get { return datumZaduzenja; }
            set { datumZaduzenja = value; }
        }

        DateTime? datumRazduzenja;

        public DateTime? DatumRazduzenja
        {
            get { return datumRazduzenja; }
            set { datumRazduzenja = value; }
        }

        double ukupnaCena;

        public double UkupnaCena
        {
            get { return ukupnaCena; }
            set { ukupnaCena = value; }
        }

        bool razduzeno;

        public bool Razduzeno
        {
            get { return razduzeno; }
            set { razduzeno = value; }
        }

        bool stornirano;

        public bool Stornirano
        {
            get { return stornirano; }
            set { stornirano = value; }
        }

        Klijent klijent;

        public Klijent Klijent
        {
            get { return klijent; }
            set { klijent = value; }
        }


        Automobil automobil;

        public Automobil Automobil
        {
            get { return automobil; }
            set { automobil = value; }
        }

        Zaposleni zaduzioID;

        public Zaposleni ZaduzioID
        {
            get { return zaduzioID; }
            set { zaduzioID = value; }
        }

        Zaposleni razduzioID;

        public Zaposleni RazduzioID
        {
            get { return razduzioID; }
            set { razduzioID = value; }
        }

        public string VratiImeTabele()
        {
            return "tbRentiranje";
        }

        public string VratiTabeluZaUnos()
        {
            return "tbRentiranje";
        }

        public string VratiVrednostiZaInsert()
        {
            string pomRazd = (datumRazduzenja == null) ? "NULL" : "'" + datumRazduzenja.Value.ToString("yyyy-MM-dd") + "'";
            return "('" + rentiranjeID + "','" + automobil.AutomobilID + "','" + klijent.KlijentID + "'," + datumZaduzenja.ToString("yyyy-MM-dd") + "," + pomRazd + "," + ukupnaCena + "," + razduzeno + "," + stornirano + ",'" + zaduzioID.ZaposleniID + "','" + razduzioID.ZaposleniID + "')";
        }

        public string VratiVrednostiZaAzuriranje()
        {
            string pomRazd = (datumRazduzenja == null) ? "NULL" : "'" + datumRazduzenja.Value.ToString("yyyy-MM-dd") + "'";
            return "RentiranjeID='" + rentiranjeID + "', DatumZaduzenja='" + datumZaduzenja.ToString("yyyy-MM-dd") + "', DatumRazduzenja=" + pomRazd + ", UkupnaCena=" + ukupnaCena + ", Razduzeno=" + razduzeno + ",Stornirano=" + stornirano + ", KlijentID='" + klijent.KlijentID + "', AutomobilID='" + automobil.AutomobilID + "', ZaduzioID='" + zaduzioID.ZaposleniID + "', RazduzioID='" + razduzioID.ZaposleniID + "'";
        }

        public string VratiKljucniAtribut()
        {
            return "RentiranjeID='" + rentiranjeID + "'";
        }

        public string VratiNazivKljucnogAtributa()
        {
            return "RentiranjeID";
        }

        public string VratiUslovZaObjekat()
        {
            return "(((tbRentiranje.KlijentID)='" + klijent.KlijentID + "'))";
        }

        public OpstiDomenskiObjekat VratiObjekat(System.Data.OleDb.OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public List<OpstiDomenskiObjekat> VratiListu(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> rentiranja = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Rentiranje rent = new Rentiranje();
                Klijent k = new Klijent();
                Automobil a = new Automobil();
                Zaposleni zz = new Zaposleni();
                Zaposleni zr = new Zaposleni();

                rent.rentiranjeID = citac.GetString(0);
                a.AutomobilID = citac.GetString(1);
                k.KlijentID = citac.GetString(2);
                rent.datumZaduzenja = citac.GetDateTime(3);
                if (!citac.IsDBNull(4))
                {
                    rent.datumRazduzenja = citac.GetDateTime(4);
                }
                
                rent.ukupnaCena = Convert.ToDouble(citac["UkupnaCena"]);
                rent.razduzeno = citac.GetBoolean(6);
                rent.stornirano = citac.GetBoolean(7);
                
                zz.ZaposleniID = citac.GetString(8);
                if (!citac.IsDBNull(9))
                {
                    zr.ZaposleniID = citac.GetString(9);
                }
                else { zr.ZaposleniID = "/"; }


                rent.klijent = k;
                rent.automobil = a;
                rent.zaduzioID = zz;
                rent.razduzioID = zr;

                rentiranja.Add(rent);
            }
            return rentiranja;
        }


        public string VratiVrednostiZaStorniranje()
        {
            return "Stornirano = true";
        }
    }
}
