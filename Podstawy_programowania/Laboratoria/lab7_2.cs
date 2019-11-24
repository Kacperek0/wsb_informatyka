using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab7_2
    {
        public lab7_2()
        {
            int x = 5;
            Console.WriteLine("Zmienna x przed wywołaniem funkcji {0}", x);
            Increment(ref x); //przy wywołaniu funkcji też trzeba wywołać ref'a
            Increment(ref x);
        }

        static void Increment(ref int x) //ref odwołuje się bezpośrednio do miejsca w pamięci.
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji wynosi: {0}", x);
        }
    }

}
