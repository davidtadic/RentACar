using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zaposleni : OpstiDomenskiObjekat
    {
        string zaposleniID;

        public string ZaposleniID
        {
            get { return zaposleniID; }
            set { zaposleniID = value; }
        }

        string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        string korisnickoIme;

        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }

        string korisnickaSifra;

        public string KorisnickaSifra
        {
            get { return korisnickaSifra; }
            set { korisnickaSifra = value; }
        }

        public override string ToString()
        {
            if (!(ime == null))
            {
                return ime + " " + prezime;
            }
            return zaposleniID;
        }




        public string VratiImeTabele()
        {
            return "tbZaposleni";
        }

        public string VratiVrednostiZaInsert()
        {
            return "('" + zaposleniID + "','" + ime + "','" + prezime + "','" + korisnickoIme + "','" + korisnickaSifra + "')";
        }

        public string VratiKljucniAtribut()
        {
            return "ZaposleniID=" + zaposleniID;
        }

        public List<OpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> listaZaposlenih = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Zaposleni zaposleni = new Zaposleni();
                zaposleni.ZaposleniID = citac.GetString(0);
                zaposleni.Ime = citac.GetString(1);
                zaposleni.Prezime = citac.GetString(2);
                zaposleni.korisnickoIme = citac.GetString(3);
                zaposleni.korisnickaSifra = citac.GetString(4);

                listaZaposlenih.Add(zaposleni);
            }
            return listaZaposlenih;
        }

        public OpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            Zaposleni zap = null;
            if (citac.Read())
            {
                zap = new Zaposleni();
                zap.ZaposleniID = citac.GetString(0);
                zap.Ime = citac.GetString(1);
                zap.Prezime = citac.GetString(2);
                zap.korisnickoIme = citac.GetString(3);
                zap.korisnickaSifra = citac.GetString(4);

            }
            return zap;
        }

        public string VratiUslovZaObjekat()
        {
            if (zaposleniID != null) return "ZaposleniID = '" + zaposleniID + "'";
            return "KorisnickoIme ='" + korisnickoIme + "' AND KorisnickaSifra ='" + korisnickaSifra + "'";
        }


        public string VratiTabeluZaUnos()
        {
            return "tbZaposleni";
        }


        public string VratiNazivKljucnogAtributa()
        {
            return "ZaposleniID";
        }


        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException();
        }


        public string VratiVrednostiZaStorniranje()
        {
            throw new NotImplementedException();
        }
    }
}
