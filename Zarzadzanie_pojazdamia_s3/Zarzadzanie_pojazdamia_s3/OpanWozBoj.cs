using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_pojazdamia_s3
{
    class OpanWozBoj : IPojMelduj, IPojJedz, IPojWoj
    {
        #region OpanWozBoj - pola
        private string n_kodowa;
        private int l_kol;
        private int l_zaloga;
        private double kaliber;
        #endregion

        public OpanWozBoj()
        {
            this.n_kodowa = "OpanWozBoj";
            this.l_zaloga = 5;
            this.kaliber = 14;
            this.l_kol = 8;
        }

        public void Melduj()
        {
            Console.WriteLine("\nKod: {0}\nZaloga: {1}\nKol: {2}", n_kodowa, l_zaloga, l_kol);
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
