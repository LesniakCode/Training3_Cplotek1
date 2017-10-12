using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_pojazdamia_s3
{
    class Ambulans : IPojMelduj, IPojJedz
    {
        #region Ambulans - pola
        private string n_kodowa;
        private int l_zaloga;
        private int l_kol;
        #endregion

        public Ambulans()
        {
            this.n_kodowa = "Karetka";
            this.l_zaloga = 3;
            this.l_kol = 4;
        }

        public void Melduj()
        {
            Console.WriteLine("\nKod: {0}\nZaloga: {1}\nKol: {2}", n_kodowa, l_zaloga, l_kol);
        }

        public void Jedz()
        {
            Console.Write("{0} jedzie.\n", n_kodowa);
        }

    }

}
