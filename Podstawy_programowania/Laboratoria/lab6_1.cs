using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab6_1
    {
        public lab6_1()
        {
            uint number;
            string str;

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Podaj liczbę całkowitą");
                str = Console.ReadLine();

                try
                {
                    number = uint.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wprowadź liczbę w poprawnym formacie.");
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem.");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wartość nie może być pusta.");
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Poprawna wartość {0}", number);
            Console.ResetColor();


        }
    }
}
