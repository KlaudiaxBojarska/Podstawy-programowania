using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._1
{
    class Program
    {
        /*
         Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
         liczba parzysta, czy też nieparzysta.
        */
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj lizbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Liczba {0} jest parzysta.", a);
            else
                Console.WriteLine("Liczba {0} jest nieparzysta.", a);
            Console.ReadKey(true); //pauza
        }
    }
}
