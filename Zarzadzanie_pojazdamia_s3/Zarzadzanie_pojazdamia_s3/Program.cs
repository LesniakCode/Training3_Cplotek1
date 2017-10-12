using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_pojazdamia_s3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            char opcja;
            List<Object> MyList = new List<Object>
            {
                new Czolg(),
                new Amfibia(),
                new Ambulans(),
                new Zaglowka(),
                new Niszczyciel(),
                new Puszczyk(),
                new OpanWozBoj()
            };

            Testing Test = new Testing();

            while(running)
            {
                Console.WriteLine("Rozpoczynamy Panowie. W tym Centrum Dowodzenia mozesz zarzadzac swoim oddzialem.\n" +
                    "1. Meldunki.\n2.Przemieszczanie naziemnych sil.\n3.Przemieszczanie powietrznych sil.\n" +
                    "4.Przemieszczanie marynarki.\n5. Prezentuj dostepna bron.\n6.Salwa!!!\n7. Zakoncz.\nWybierz akcje:");
                opcja = Console.ReadKey().KeyChar;
                switch(opcja)
                {
                    case '1':
                        Console.Clear();
                        Test.Meldunki(MyList);
                        break;
                    case '2':
                        Console.Clear();
                        Test.Jedziemy(MyList);
                        break;
                    case '3':
                        Console.Clear();
                        Test.Lecimy(MyList);
                        break;
                    case '4':
                        Console.Clear();
                        Test.Plyniemy(MyList);
                        break;
                    case '5':
                        Console.Clear();
                        Test.PrezentujBron(MyList);
                        break;
                    case '6':
                        Console.Clear();
                        Test.Strzelamy(MyList);
                        break;
                    case '7':
                        Console.Clear();
                        running = false;
                        break;
                }
            }
        }
    }
}

class Testing
{
    public Testing()
    {

    }

    public void Meldunki(List<Object> lst)
    {
        foreach (IPojMelduj item in lst)
        {
            item.Melduj();
        }

    }

    public void Jedziemy(List<Object> lst)
    {
        foreach (Object item in lst)
        {
            if (typeof(IPojJedz).IsAssignableFrom(item.GetType()))
            {
                IPojJedz temp = (IPojJedz)item;
                temp.Jedz();
            }
        }
    }

    public void Lecimy(List<Object> lst)
    {
        foreach (Object item in lst)
        {
            if (typeof(IPojLec).IsAssignableFrom(item.GetType()))
            {
                IPojLec temp = (IPojLec)item;
                temp.Lec();
            }
        }
    }

    public void Plyniemy(List<Object> lst)
    {
        foreach (Object item in lst)
        {
            if (typeof(IPojPlyn).IsAssignableFrom(item.GetType()))
            {
                IPojPlyn temp = (IPojPlyn)item;
                temp.Plyn();
            }
        }
    }

    public void PrezentujBron(List<Object> lst)
    {
        foreach (Object item in lst)
        {
            if (typeof(IPojWoj).IsAssignableFrom(item.GetType()))
            {
                IPojWoj temp = (IPojWoj)item;
                temp.Prezentuj();
            }
        }
    }

    public void Strzelamy(List<Object> lst)
    {
        foreach (Object item in lst)
        {
            if (typeof(IPojWoj).IsAssignableFrom(item.GetType()))
            {
                IPojWoj temp = (IPojWoj)item;
                temp.Ognia();
            }
        }
    }
}

interface IPojMelduj
{
    void Melduj();
}

interface IPojJedz
{
    void Jedz();
}

interface IPojPlyn
{
    void Plyn();
}

interface IPojLec
{
    void Lec();
}

interface IPojWoj
{
    void Ognia();

    void Prezentuj();
}

/*
 * Napisz aplikacje umożliwiająca zarzadzanie pojazdami wojskowymi.
Aplikacja powinna uwzględnić następujące wymagania:
-Trzy rodzaje obiektów: powietrzne, wodne, lądowe
W szczególności program powinien moc obsłużyć prawidłowo obiekty typu
-opancerzony wóz bojowy: nazwa kodowa, ilość kol, liczba załogantów, kaliber zamontowanego działa.
-czołg: nazwa kodowa, liczba załogantów, kaliber zamontowanego działa, maksymalna prędkość.
-amfibia: nazwa kodowa, liczba kol, liczba załogantów, kaliber zamontowanego działa, maksymalna 
prędkość morska, maksymalna prędkość lądowa.
 -niszczyciel: nazwa kodowa, liczba załogantów, kaliber zamontowanego działa, maksymalna prędkość morska.
-helikopter bojowy puszczyk: nazwa kodowa,  liczba załogantów, kaliber zamontowanego działa, 
maksymalna prędkość powietrzna.
-ambulans: nazwa kodowa, ilość kol, liczba załogantów.
-zagłówka: nazwa kodowa, liczba załogantów, maksymalna prędkość morska
 
Każdy z obiektów powinien mieć zaimplementowana funkcje która wyświetli informacje o 
podstawowych atrybutach danego obiektu.
obiekty lądowe powinny mieć funkcje odpowiedzialne za poruszanie się po ladzie.
Obiekty wodne powinny mieć funkcje odpowiedzialne za poruszanie się po wodzie.
Obiekty powietrzne powinny mieć funkcje odpowiedzialne za wbicie się w powietrze.
obiekty wojskowe posiadające bron powinny mieć funkcje wykonujące strzał oraz osobna funkcje wyświetlająca 
dane o zamontowanym dziale.
 
Zaimplementuj odpowiednie hierarchie miedzy obiektami(klasy bazowe i interfejsy) tak aby możliwe było
zaimplementowanie funkcji testujących:
-Funkcja wyświetlająca dane bazowe wszystkich typów pojazdów
-Funkcja, która będzie w stanie uruchomić wszystkie obiekty lądowe
-Funkcja, która będzie w stanie uruchomić wszystkie obiekty wodne
-Funkcja, która będzie w stanie uruchomić wszystkie obiekty powietrzne
-Funkcja, która będzie w stanie oddać strzał z dowolnego obiektu wojskowego
 
*/
