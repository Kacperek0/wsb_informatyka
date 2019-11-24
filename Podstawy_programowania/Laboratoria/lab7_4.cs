using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab7_4
    {
        public lab7_4()
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;

            Console.WriteLine("Wartości przed wywołaniem funkcji: {0} {1}", tab[0], tab[1]);
            Tab(tab);
            Console.WriteLine("Wartości po wywołaniu funkcji: {0} {1}", tab[0], tab[1]);


        }

        static void Tab(int[] tab)
        {
            tab[0] = 50;
            tab[1] = 100;

            Console.WriteLine("Wartości wewnątrz funkcji: {0} {1}", tab[0], tab[1]);
        }
    }
}
