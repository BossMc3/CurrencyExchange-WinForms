using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPaw_CasaDeSchimbValutar.Modele
{
    [Serializable]
    public class CursValutar
    {
        public Valuta Valuta { get; set; }
        public DateTime Data { get; set; }
        public double ValoareCumparare { get; set; }
        public double ValoareVanzare { get; set; }

        public CursValutar()
        {

        }

        public CursValutar(Valuta valuta, DateTime data, double valoareCumparare, double valoareVanzare)
        {
            this.Valuta = valuta;
            this.Data = data;
            this.ValoareCumparare = valoareCumparare;
            this.ValoareVanzare = valoareVanzare;
        }
    }
}
