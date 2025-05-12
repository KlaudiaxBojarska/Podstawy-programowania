using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._1
{
    /*
     Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
całkowitymi. Napisz program wykorzystujący funkcję suma.
    */
    internal class Program
    {
        //funkcja oblicza sumę jej argumentów
        static int suma(int a, int b)
        {
            return a + b;
        }
        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine("2+5={0}", suma(2, 5));
            Console.ReadKey(true);// pauza
        }
    }
}
