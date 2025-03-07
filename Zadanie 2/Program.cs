using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        //Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!".
        static void Main(string[] args) 
        { 
            string imie;
            Console.Write("Podaj swoje imie");
            imie = Console.ReadLine();
            Console.WriteLine("WItaj {0}!, imie");
        Console.ReadKey(true);//pauza


        
        }
    }
}
