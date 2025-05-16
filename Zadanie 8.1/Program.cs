using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8._1
{
    /*
     Napisz funkcję , która oblicza wartość silni z zadanej przez argument wywołania funkcji
     wartości liczby naturalnej. Utwórz wersję rekurencyjną tej funkcji.
     Napisz program testowy wykorzystujący napisaną funkcję.
    */
    class Program
    {
        //definicja funkcji rekurencyjnej
        static long silnia(int n)
        {
            if (n == 0) return 1;
            else return n * silnia(n - 1);
        }
        //przykładowe użycie funkcji rekurencyjnej

        static void Main(string[] args)
        {
            Console.Write("Podaj n=");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Błędny argument!");
            else Console.WriteLine("{0}!={1}", n, silnia(n));
            Console.ReadKey(true); //pauza
        }
    }
}
