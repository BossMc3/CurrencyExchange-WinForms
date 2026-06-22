using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPaw_CasaDeSchimbValutar.Modele
{
    [Serializable]
    public class Tranzacite
    {
        public int idTranzacite { get; set; }
        public CursValutar CursAplicat { get; set; }
        public double SumaIncasata { get; set; }
        public string TipTranzactie { get; set; } // Cumparare sau Vanzare


        public Tranzacite()
        {

        }

        public Tranzacite(int id, CursValutar curs, double suma, string tip)
        {
            idTranzacite = id;
            CursAplicat = curs;
            SumaIncasata = suma;
            TipTranzactie = tip;
        }


        public double CalculeazaSumaEliberata()
        {
            double rezultat = 0;

            if (TipTranzactie == "Cumparare")
                rezultat = SumaIncasata * CursAplicat.ValoareCumparare;

            else if (TipTranzactie == "Vanzare")
                rezultat = SumaIncasata / CursAplicat.ValoareVanzare;

            return rezultat;  
        }
    }
}
