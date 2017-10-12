using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_pojazdamia_s3
{
    class Puszczyk : IPojMelduj, IPojLec, IPojWoj
    {
        #region Puszczyk - pola
        private string n_kodowa;
        private int l_zaloga;
        private double kaliber;
        private int maks_v;
        #endregion

        public Puszczyk()
        {
            this.n_kodowa = "Puszczyk";
            this.l_zaloga = 2;
            this.kaliber = 12;
            this.maks_v = 140;
        }

        public void Melduj()
        {
            Console.WriteLine("\nKod: {0}\nZaloga: {1}\nMaks_V: {2}", n_kodowa, l_zaloga, maks_v);
        }

        public void Lec()
        {
            Console.Write("{0} leci.\n", n_kodowa);
        }

        public void Prezentuj()
        {
            Console.WriteLine("Dzialo o kalibrze: {0}.", kaliber);
        }

        public void Ognia()
        {
            Console.WriteLine("Ognia!!! {0} po strzale", n_kodowa);
        }
    }

}
