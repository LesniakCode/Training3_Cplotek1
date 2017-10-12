using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_pojazdamia_s3
{
    class Zaglowka : IPojMelduj, IPojPlyn
    {
        #region Zaglowka - pola
        private string n_kodowa;
        private int l_zaloga;
        private int maks_v;
        #endregion

        public Zaglowka()
        {
            this.n_kodowa = "Zaglowka";
            this.l_zaloga = 6;
            this.maks_v = 79;
        }

        public void Melduj()
        {
            Console.WriteLine("\nKod: {0}\nZaloga: {1}\nMaks_V: {2}", n_kodowa, l_zaloga, maks_v);
        }

        public void Plyn()
        {
            Console.Write("{0} plynie.\n", n_kodowa);
        }

    }
 
}
