using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Mesto : OpstiDomenskiObjekat
    {
        int pttBroj;

        public int PttBroj
        {
            get { return pttBroj; }
            set { pttBroj = value; }
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
            return "tbMesto";
        }

        public string VratiVrednostiZaInsert()
        {
            return "(" + pttBroj + ",'" + naziv + ")";
        }

        public string VratiKljucniAtribut()
        {
            return "PttBroj";
        }


        public List<OpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> mesta = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Mesto mesto = new Mesto();
                mesto.PttBroj = Convert.ToInt32(citac["PttBroj"]);
                mesto.Naziv = citac.GetString(1);
                mesta.Add(mesto);
            }
            return mesta;
        }


        public string VratiUslovZaObjekat()
        {
            throw new NotImplementedException();
        }


        public OpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }


        public string VratiTabeluZaUnos()
        {
            return "tbMesto";
        }


        public string VratiNazivKljucnogAtributa()
        {
            return "PttBroj";
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
