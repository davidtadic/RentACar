using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string VratiImeTabele();

        string VratiTabeluZaUnos();

        string VratiVrednostiZaInsert();

        string VratiVrednostiZaAzuriranje();

        string VratiKljucniAtribut();

        string VratiNazivKljucnogAtributa();

        string VratiUslovZaObjekat();

        string VratiVrednostiZaStorniranje();

        OpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac);

        List<OpstiDomenskiObjekat> VratiListu(OleDbDataReader citac);
    }
}
