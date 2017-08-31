using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Klijent : OpstiDomenskiObjekat
    {
        string klijentID;

        public string KlijentID
        {
            get { return klijentID; }
            set { klijentID = value; }
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

        string jmbg;

        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        string kontaktTel;

        public string KontaktTel
        {
            get { return kontaktTel; }
            set { kontaktTel = value; }
        }

        string brLicneKarte;

        public string BrLicneKarte
        {
            get { return brLicneKarte; }
            set { brLicneKarte = value; }
        }



        Mesto mesto;

        public Mesto Mesto
        {
            get { return mesto; }
            set { mesto = value; }
        }

        public override string ToString()
        {
            if (!(ime == null))
            {
                return ime + " " + prezime;
            }
            return klijentID;

        }

        public string VratiImeTabele()
        {
            return "tbKlijent INNER JOIN tbMesto ON tbKlijent.PttBroj = tbMesto.PttBroj";
        }

        public string VratiVrednostiZaInsert()
        {
            return "('" + klijentID + "','" + ime + "','" + prezime + "','" + jmbg + "','" + kontaktTel + "','" + brLicneKarte + "'," + mesto.PttBroj + ")";
        }

        public string VratiKljucniAtribut()
        {
            return "KlijentID='" + klijentID + "'";
        }


        public List<OpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> klijenti = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Klijent klijent = new Klijent();
                Mesto mesto = new Mesto();

                klijent.KlijentID = citac.GetString(0);
                klijent.Ime = citac.GetString(1);
                klijent.Prezime = citac.GetString(2);
                klijent.Jmbg = citac.GetString(3);
                klijent.KontaktTel = citac.GetString(4);
                klijent.BrLicneKarte = citac.GetString(5);

                mesto.PttBroj = Convert.ToInt32(citac["tbKlijent.PttBroj"]);
                mesto.Naziv = citac.GetString(8);
                klijent.Mesto = mesto;
                klijenti.Add(klijent);
            }
            return klijenti;
        }


        public string VratiUslovZaObjekat()
        {
            return "(((tbKlijent.KlijentID)='" + klijentID + "') OR ((tbKlijent.Ime)='" + ime + "') OR ((tbKlijent.Prezime)='" + prezime + "') OR ((tbKlijent.JMBG)='" + jmbg + "'))";
        }


        public OpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }


        public string VratiTabeluZaUnos()
        {
            return "tbKlijent";
        }


        public string VratiNazivKljucnogAtributa()
        {
            return "KlijentID";
        }


        public string VratiVrednostiZaAzuriranje()
        {
            return "KlijentID='" + klijentID + "', Ime='" + ime + "', Prezime='" + prezime + "', JMBG='" + jmbg + "', KontaktTel='" + kontaktTel + "',BrLicneKarte='" + brLicneKarte + "', PttBroj=" + mesto.PttBroj + "";
        }


        public string VratiVrednostiZaStorniranje()
        {
            throw new NotImplementedException();
        }

    }
}