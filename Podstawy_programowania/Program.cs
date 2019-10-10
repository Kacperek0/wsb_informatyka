using System;

namespace Podstawy_programowania
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Napisać program obliczania największego wspólnego dzielnika dwóch dodatnich liczb całkowitych.
             * Wykorzystać algorytm Euklidesa nie używając operacji dzielenia.
             */

            int a, b;

            Console.WriteLine("Podaj a.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b.");
            b = int.Parse(Console.ReadLine());

            //https://pl.wikipedia.org/wiki/Algorytm_Euklidesa - sekcja odejmowanie

            Console.WriteLine("Największy wspólny dzielnik (NWD) to: " + a);
        }
    }
}