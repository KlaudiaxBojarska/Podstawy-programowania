using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._6
{
    /*
    Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
    foreach.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string[] dni = new string[] { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
            //wypisujemy elementy tablicy
            foreach (string elem in dni)
                Console.Write("{0}, ", elem);
            Console.ReadKey(true); //pauza
        }
    }
}
