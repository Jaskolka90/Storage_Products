using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdycjaProduktów
{
    class Produkt
    {
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }
        public Uri Zdjecie { get; set; }
        public string Opis { get; set; }

        public Produkt()
        { }

        public Produkt(string sym, string naz, int lszt, string mag, Uri zdj, string opi)
        {
            Symbol = sym;
            Nazwa = naz;
            LiczbaSztuk = lszt;
            Magazyn = mag;
            Zdjecie = zdj;
            Opis = opi;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", Symbol, Nazwa, LiczbaSztuk, Magazyn, Zdjecie, Opis);
        }
    }
}
