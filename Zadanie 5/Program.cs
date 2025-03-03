using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        /*
       Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na
ekranie objętość i pole całkowite tego stożka.
        */
        static void Main(string[] args)
        {
            double r, h, l, V, Pc;
            Console.Write("Podaj r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);//tworząca
            V = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("V={0}", V);
            Console.WriteLine("Pc={0}, Pc");
            Console.ReadKey(true);//pauza
        }
    }
}
