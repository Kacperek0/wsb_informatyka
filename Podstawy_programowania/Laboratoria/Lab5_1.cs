using System;
namespace Podstawy_programowania.Laboratoria
{
    public class Lab5_1
    {
        public Lab5_1()
        {
            //Typy referencyjne i wartościowe

            int a = 10;
            int b = a;

            a--;
            b++;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //typ referencyjny

            int[] tabA = { 1, 2, 3 };
            int[] tabB = tabA;

            tabA[1] = 80;
            tabB[2] = 8;

            foreach (var item in tabA)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            foreach (var item in tabB)
            {
                Console.Write("{0} ", item);
            }

            //Klasy, delegaty, interface'y i tablice są typami referencyjnymi
            // zmienna, której watrtością jest adres miejsca w pamięci (jeden)
        }
    }
}
