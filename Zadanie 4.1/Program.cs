using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._1
{
    internal class Program
    {
        /*
        Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z
        przedziału [a,b]. Użyj pętli while.
        */
        static void Main(string[] args)
        {
            int a, b, i;
            Console.Write("Podaj a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b = ");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            {
                if (i % 2 == 0) Console.Write("{0}, ", i);
                i++;
            } //while
            Console.ReadKey(true);//pauza
                {
                    
                }
            }
        }
    }

