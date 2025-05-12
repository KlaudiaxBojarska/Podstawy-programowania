using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._6
{
    /*
    Napisać procedurę (czyli funkcję, która nie zwraca żadnej wartości) posiadającą trzy
parametry: a-długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2-znak
będący wypełnieniem kwadratu. Procedura ma rysować na ekranie kwadrat o zadanych
argumentach. Przetestuj działanie utworzonej procedury.
    */
    internal class Program
    {
        //prodecuda rysująca kwadrat (procedura= funkcja nie zwracająca wartości)
        static void kwadrat(int a, char znak1, char znak2)
        {
            int i, j; //liczniki pętli
            for (i = 1; i <= a; i++) Console.Write(znak1); //pierwsza linia kwadratu
            Console.WriteLine(""); //wypisuje enter
            for (i = 2; i <= a - 1; i++) //środek kwadratu
            {
                Console.Write(znak1); //początek linii
                for (j = 2; j <= a - 1; j++) Console.Write(znak2);
                Console.Write(znak1); //koniec linii
                Console.WriteLine(""); //wypisuję enter
            }
            for (i = 1; i <= a; i++) Console.Write(znak1); //ostatnia linia kwadratu
        }
        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            kwadrat(6, '#', '*');
            Console.ReadKey(true); //pauza
        }
    }
}
