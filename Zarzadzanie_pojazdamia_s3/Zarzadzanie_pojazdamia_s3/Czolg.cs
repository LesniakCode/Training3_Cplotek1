using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_pojazdamia_s3
{
    class Czolg : IPojMelduj, IPojJedz, IPojWoj
    {
        #region Czolg - pola
        private string n_kodowa;
        private int l_zaloga;
        private double kaliber;
        private int maks_v;
        #endregion
           
        public Czolg()
        {
            this.n_kodowa = "Tygrys";
            this.l_zaloga = 5;
            this.kaliber = 45;
            this.maks_v = 90;
        }

        public void Melduj()
        {
            Console.WriteLine("\nKod: {0}\nZaloga: {1}\nMaks_V: {2}", n_kodowa, l_zaloga, maks_v);
        }

        public void Jedz()
        {
            Console.Write("{0} jedzie.\n", n_kodowa);
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
