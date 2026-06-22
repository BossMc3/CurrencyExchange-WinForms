using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPaw_CasaDeSchimbValutar.Modele
{
    [Serializable]
    public class Valuta
    {
        public string Cod { get; set; } // ex: EURO, USD, GBP
        public string Denumire { get; set; } //ex : Euro , Dolar American

        public Valuta()
        {

        }

        public Valuta(string cod, string denumire)
        {
            this.Cod = cod;
            this.Denumire = denumire;
        }
    }
}
