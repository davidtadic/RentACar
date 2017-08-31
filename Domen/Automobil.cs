using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Automobil : OpstiDomenskiObjekat
    {
        string automobilID;

        public string AutomobilID
        {
            get { return automobilID; }
            set { automobilID = value; }
        }

        string modelAutomobila;

        public string ModelAutomobila
        {
            get { return modelAutomobila; }
            set { modelAutomobila = value; }
        }


        int godinaProizvodnje;

        public int GodinaProizvodnje
        {
            get { return godinaProizvodnje; }
            set { godinaProizvodnje = value; }
        }

        string registarskiBroj;

        public string RegistarskiBroj
        {
            get { return registarskiBroj; }
            set { registarskiBroj = value; }
        }

        double cenaRentiranja;

        public double CenaRentiranja
        {
            get { return cenaRentiranja; }
            set { cenaRentiranja = value; }
        }

        Proizvodjac proizvodjac;

        public Proizvodjac Proizvodjac
        {
            get { return proizvodjac; }
            set { proizvodjac = value; }
        }


        public override string ToString()
        {
            if (!(modelAutomobila == null))
            {
                return modelAutomobila + " " + proizvodjac.Naziv;
            }
            else return automobilID;

        }

        public string VratiImeTabele()
        {
            return "tbAutomobil INNER JOIN tbProizvodjac ON tbAutomobil.ProizvodjacID = tbProizvodjac.ProizvodjacID";
        }

        public string VratiTabeluZaUnos()
        {
            return "tbAutomobil";
        }

        public string VratiVrednostiZaInsert()
        {
            return "('" + automobilID + "','" + modelAutomobila + "'," + godinaProizvodnje + ",'" + registarskiBroj + "'," + cenaRentiranja + ",'" + proizvodjac.ProzvodjacID + "')";
        }

        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException();
        }

        public string VratiKljucniAtribut()
        {
            return "AutomobilID='" + automobilID + "'";
        }

        public string VratiNazivKljucnogAtributa()
        {
            return "AutomobilID";
        }

        public string VratiUslovZaObjekat()
        {
            return "(((tbAutomobil.AutomobilID)='" + automobilID + "') OR ((tbAutomobil.ModelAutomobila)='" + modelAutomobila + "') OR ((tbAutomobil.RegistarskiBroj)='" + registarskiBroj + "') OR ((tbProizvodjac.Naziv)='" + proizvodjac.Naziv + "'))";
        }

        public OpstiDomenskiObjekat VratiObjekat(System.Data.OleDb.OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public List<OpstiDomenskiObjekat> VratiListu(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> automobili = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Automobil a = new Automobil();
                Proizvodjac p = new Proizvodjac();

                a.automobilID = citac.GetString(0);
                a.modelAutomobila = citac.GetString(1);
                a.GodinaProizvodnje = Convert.ToInt32(citac["GodinaProizvodnje"]);
                a.registarskiBroj = citac.GetString(3);
                a.cenaRentiranja = Convert.ToDouble(citac["CenaRentiranja"]);

                p.ProzvodjacID = citac.GetString(5);
                p.Naziv = citac.GetString(7);
                a.proizvodjac = p;
                automobili.Add(a);
            }
            return automobili;
        }


        public string VratiVrednostiZaStorniranje()
        {
            throw new NotImplementedException();
        }

    }
}
