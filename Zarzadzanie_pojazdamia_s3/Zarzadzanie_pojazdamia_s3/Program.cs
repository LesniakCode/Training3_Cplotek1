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
        }
    }
}
/*
 * Napisz aplikacje umożliwiająca zarzadzanie pojazdami wojskowymi.
Aplikacja powinna uwzględnić następujące wymagania:
-Trzy rodzaje obiektów: powietrzne, wodne, lądowe
W szczególności program powinien moc obsłużyć prawidłowo obiekty typu
-opancerzony wóz bojowy: nazwa kodowa, ilość kol, liczba załogantów, kaliber zamontowanego działa.
-czołg: nazwa kodowa, liczba załogantów, kaliber zamontowanego działa, maksymalna prędkość.
-amfibia: nazwa kodowa, liczba kol, liczba załogantów, kaliber zamontowanego działa, maksymalna prędkość morska, maksymalna prędkość lądowa.
 -niszczyciel: nazwa kodowa, liczba załogantów, kaliber zamontowanego działa, maksymalna prędkość morska.
-helikopter bojowy puszczyk: nazwa kodowa,  liczba załogantów, kaliber zamontowanego działa, maksymalna prędkość powietrzna.
-ambulans: nazwa kodowa, ilość kol, liczba załogantów.
-zagłówka: nazwa kodowa, liczba załogantów, maksymalna prędkość morska
 
Każdy z obiektów powinien mieć zaimplementowana funkcje która wyświetli informacje o podstawowych atrybutach danego obiektu.
obiekty lądowe powinny mieć funkcje odpowiedzialne za poruszanie się po ladzie.
Obiekty wodne powinny mieć funkcje odpowiedzialne za poruszanie się po wodzie.
Obiekty powietrzne powinny mieć funkcje odpowiedzialne za wbicie się w powietrze.
obiekty wojskowe posiadające bron powinny mieć funkcje wykonujące strzał oraz osobna funkcje wyświetlająca dane o zamontowanym dziale.
 
Zaimplementuj odpowiednie hierarchie miedzy obiektami(klasy bazowe i interfejsy) tak aby możliwe było
zaimplementowanie funkcji testujących:
-Funkcja wyświetlająca dane bazowe wszystkich typów pojazdów
-Funkcja, która będzie w stanie uruchomić wszystkie obiekty lądowe
-Funkcja, która będzie w stanie uruchomić wszystkie obiekty wodne
-Funkcja, która będzie w stanie uruchomić wszystkie obiekty powietrzne
-Funkcja, która będzie w stanie oddać strzał z dowolnego obiektu wojskowego
 
*/
