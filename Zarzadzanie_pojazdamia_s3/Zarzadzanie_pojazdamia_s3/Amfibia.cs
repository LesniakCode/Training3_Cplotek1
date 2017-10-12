using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_pojazdamia_s3
{
    class Amfibia : IPojMelduj, IPojPlyn, IPojJedz, IPojWoj
    {
        #region Amfibia - pola
        private string n_kodowa;
        private int l_kol;
        private int l_zaloga;
        private double kaliber;
        private int maks_v_lad;
        private int maks_v_mor;
        #endregion

        public Amfibia()
        {
            this.n_kodowa = "Amfibia";
            this.l_kol = 6;
            this.l_zaloga = 5;
            this.kaliber = 30;
            this.maks_v_lad = 60;
            this.maks_v_mor = 30;
        }

        public void Melduj()
        {
            Console.WriteLine("\nKod: {0}\nZaloga: {1}\nMaks_V_lad: {2}\nKol: {3}" +
                "\nMaks_V_wod: {4}", n_kodowa, l_zaloga, maks_v_lad,l_kol,maks_v_mor);
        }

        public void Jedz()
        {
            Console.Write("{0} jedzie.\n", n_kodowa);
        }

        public void Plyn()
        {
            Console.Write("{0} plynie.\n", n_kodowa);
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
