using System;
namespace Podstawy_programowania
{
    public class Iteracyjny_Algorytm_Euklidesa
    {
        public Iteracyjny_Algorytm_Euklidesa()
        {
            /*Napisać program obliczania największego wspólnego dzielnika dwóch dodatnich liczb całkowitych.
            * Wykorzystać algorytm Euklidesa nie używając operacji dzielenia.
            */

            Console.WriteLine("Ten program obliczy dla Ciebie NWD przy pomocy iteracyjnej formy algorytmu Euklidesa.");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());

            while (a != b) //gcd when equal
            {
                if (a > b) //for greater a than be a must be deducted by b
                {
                    a -= b; //equals a = a - b
                }
                else
                {
                    b -= a; //equals b = b - a
                }
            }

            //https://pl.wikipedia.org/wiki/Algorytm_Euklidesa - sekcja odejmowanie

            Console.WriteLine("Największy wspólny dzielnik (NWD) to: {0} ", a);
        }
    }
}
