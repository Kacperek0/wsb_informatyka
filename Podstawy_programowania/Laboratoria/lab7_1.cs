using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab7_1
    {
        public lab7_1()
        {
            /*
             * Napisz program, który sprawdza czy liczba całkowita podana przez użytkownika jest parzysta/nieparzysta.
             * Przechwyć wyjątki.*/

            //Napisz funkcję, która wyślietla sumę cyfr w liczbie


            int userInput;

            while (true)
            {
                
                try
                {
                    Console.WriteLine("Input number: ");
                    userInput = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong input.\n");
                }
                
                
            }

            //EvenOrOdd(userInput);
            Console.WriteLine(SumaCyfr(12397));



        }

        static void EvenOrOdd(int a)
        {

            if (a % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("You number is odd.");
            }
                
        }


        static int SumaCyfr(int liczba)
        {
            int suma = 0;

            do
            {
                suma +=  liczba % 10;
                liczba /= 10;

            } while (liczba != 0);

            return suma;
        }


    }
}
