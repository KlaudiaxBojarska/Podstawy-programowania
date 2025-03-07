using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        /*
         Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
         iloraz.
        */
        static void Main(string[] args)
        {
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b; //może nastąpić dzielenie przez zero!
            Console.WriteLine("{0}+{1}={2}", a, b, suma);
            Console.WriteLine("{0}-{1}={2}", a, b, roznica);
            Console.WriteLine("{0}*{1}={2}", a, b, iloczyn);
            Console.WriteLine("{O}/{1}={2}", a, b, iloraz);

            Console.ReadKey(true); //pauza

        }
    }
}
