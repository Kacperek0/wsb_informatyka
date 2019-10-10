using System;

namespace Podstawy_programowania
{
    class Program
    {
        static void Main(string[] args)
        {

            //pętle
            //wypisz liczby od <1;10>
            int i;

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadKey();

            Console.Clear();

            //wypisz wszystkie numery od 1 do 5

            int x;

            for (x = 1; x <= 5; x++)
            {
                Console.WriteLine(x + " ");
            }

            Console.Clear();

            int y;
            string input;

            Console.WriteLine("Program wypisze wszystkie liczby parzyste od 1 do podanej przez Ciebie liczby");
            Console.WriteLine("\nPodaj dowolną liczbę");
            input = Console.ReadLine();
            int.TryParse(input, out int z);

            for (y = 1; y <= z; y++)
            {
                if (y % 2 == 0)
                {
                    Console.WriteLine(y + " ");
                }
            }



            /*
             * Napisz program, który wypisuje ulubione kolory
             * Kolory przypisz do zmiennej colors
             * Użytkownik z klawiatury podaje ilość ulubionych kolorów 
             * wykorzystaj pętlę for do przypisania kolorów do zmiennej
             */


        }
    }
}
