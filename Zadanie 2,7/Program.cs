using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_7
{
   
  
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbe arabska od 1 do 3999: ");
            a = Convert.ToInt32(Console.ReadLine());
            //tysiace
            if (a >= 3000) { a -= 3000; Console.WriteLine("MMM"); }
            else if (a >= 2000) { a -= 2000; Console.WriteLine("MM"); }
            else if (a >= 1000) { a -= 1000; Console.WriteLine("M"); }
            //setki
            if (a >= 900) { a -= 900; Console.WriteLine("CM"); }
            else if (a >= 800) { a -= 800; Console.WriteLine("DCCC"); }
            else if (a >= 700) { a -= 700; Console.WriteLine("DCC"); }
            else if (a >= 600) { a -= 600; Console.WriteLine("DC"); }
            else if (a >= 500) { a -= 500; Console.WriteLine("D"); }
            else if (a >= 400) { a -= 400; Console.WriteLine("CD"); }
            else if (a >= 300) { a -= 300; Console.WriteLine("CCC"); }
            else if (a >= 200) { a -= 200; Console.WriteLine("CC"); }
            else if (a >= 100) { a -= 100; Console.WriteLine("C"); }
            //dziesiatki
            if (a >= 90) { a -= 90; Console.WriteLine("CX"); }
            else if (a >= 80) { a -= 80; Console.WriteLine("LXXX"); }
            else if (a >= 70) { a -= 70; Console.WriteLine("LXX"); }
            else if (a >= 60) { a -= 60; Console.WriteLine("LX"); }
            else if (a >= 50) { a -= 50; Console.WriteLine("L"); }
            else if (a >= 40) { a -= 40; Console.WriteLine("XL"); }
            else if (a >= 30) { a -= 30; Console.WriteLine("XXX"); }
            else if (a >= 20) { a -= 20; Console.WriteLine("XX"); }
            else if (a >= 10) { a -= 10; Console.WriteLine("X"); }
            //jednosci
            switch (a)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
                default: Console.Write(""); break;

            }
            Console.ReadKey(true); //pauza
        }
    }
}
