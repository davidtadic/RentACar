using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Proizvodjac : OpstiDomenskiObjekat
    {
        string prozvodjacID;

        public string ProzvodjacID
        {
            get { return prozvodjacID; }
            set { prozvodjacID = value; }
        }

        string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public override string ToString()
        {
            return naziv;
        }

        public string VratiImeTabele()
        {
            return "tbProizvodjac";
        }

        public string VratiTabeluZaUnos()
        {
            return "tbProizvodjac";
        }

        public string VratiVrednostiZaInsert()
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException();
        }

        public string VratiKljucniAtribut()
        {
            throw new NotImplementedException();
        }

        public string VratiNazivKljucnogAtributa()
        {
            return "ProizvodjacID";
        }

        public string VratiUslovZaObjekat()
        {
            throw new NotImplementedException();
        }

        public OpstiDomenskiObjekat VratiObjekat(System.Data.OleDb.OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public List<OpstiDomenskiObjekat> VratiListu(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> proizvodjaci = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Proizvodjac p = new Proizvodjac();
                p.prozvodjacID = citac.GetString(0);
                p.Naziv = citac.GetString(1);
                proizvodjaci.Add(p);
            }
            return proizvodjaci;
        }


        public string VratiVrednostiZaStorniranje()
        {
            throw new NotImplementedException();
        }
    }
}
