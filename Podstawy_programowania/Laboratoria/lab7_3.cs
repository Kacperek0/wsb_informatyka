using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab7_3
    {
        public lab7_3()
        {
            int x;
            Increment(out x); //20
            Increment(out x); //20
            Increment(out x); //20

        }

        static void Increment(out int x) //ref odwołuje się bezpośrednio do miejsca w pamięci.
        {

            x = 10;
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji wynosi: {0}", x);
        }
    }
}
