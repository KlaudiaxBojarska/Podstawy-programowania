using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._2
{
    /*
     Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
     Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
     umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
     Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.
    */
    //definicja struktury
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uczen[] uczniowie; //deklaruję zmienną typu strukturalnego
            int ilu_uczniow, ile_ocen, i, j; //zmienne pomocnicze
            //wczytuję liczbę uczniów
            Console.Write("Podaj liczbę uczniów w klasie: ");
            ilu_uczniow = Convert.ToInt32(Console.ReadLine());
            //przydzielam pamięć dla tablicy struktur
            uczniowie = new Uczen[ilu_uczniow];
            //wczytuję dane uczniów od użytkownika
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("Podaj imię ucznia {0}: ", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podaj nazwisko ucznia {0}: ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                //wczytuję liczbę ocen ucznia
                Console.Write("Ile ocen ma {0} {1}: ", uczniowie[1].imie, uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                //przydzielam pamięć dla tablicy ocen
                uczniowie[i].oceny = new byte[ile_ocen];
                //wczytuję oceny ucznia
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.Write("Podaj ocenę numer {0}: ", j + 1);
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine(); //wypisanie pustej linii
            }
            //wypisuje dane uczniów na ekranie
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("{0}. {1} {2}: ", i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);
                //wypisuję oceny ucznia
                foreach (byte o in uczniowie[i].oceny)
                    Console.Write("{0}, ", o);
                Console.WriteLine(""); //przejście do nowego wiersza
            }
            Console.ReadKey(true); //pauza
        }
    }
}
