using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._2
{
    /*
    Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n i
    wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n). Użyj pętli while.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, an, i;
            Console.Write("Podaj n = ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while (++i <= n)
            {
                an = 2 * i - 1;
                Console.WriteLine("a({0})={1}", i, an);
            }// while i
            Console.ReadKey(true); //pauza
        }
    }
}
