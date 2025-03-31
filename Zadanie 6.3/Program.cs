using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._3
{
    /*
    Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
    wypisujący posortowane liczby na ekranie.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i, j; //i, j- liczniki pętli
            int n, tmp; //n- ilość elementów tablicy, tmp- zmienna pomocnicza
            //wczytuję n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            //wczytuję n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            //sortujemy elementy tablicy
            for (i= 0; i < n; i++)
                for (j = i+1; j < n; j++)
                    if (tab[i] > tab[j]) //zamiana kolejności elem tab
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }
            //wyświetlamy elementy tablicy na ekranie
            Console.Write("Elementy tablicy: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true); //pauza
        }
    }
}
