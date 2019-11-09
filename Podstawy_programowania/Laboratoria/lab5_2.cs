using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab5_2
    {
        public lab5_2()
        {
            //modyfikacje konsoli

            Console.WriteLine("WSB");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("WSB");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("WSB");

            Console.ResetColor();

            Console.Title = "Modyfikacja konoli";

            Console.Clear();
            uint number;

            while (true)
            {

                Console.WriteLine("Wprowadź liczbę całkowitą");
                string x = Console.ReadLine();            
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    Console.WriteLine("Error!\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine("{0} is a wrong output", x);
                    
                }
                

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prawidłowe dane {0}", number);



        }
    }
}
