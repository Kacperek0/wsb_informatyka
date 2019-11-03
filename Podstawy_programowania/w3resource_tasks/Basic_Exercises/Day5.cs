using System;
namespace Podstawy_programowania.w3resource_tasks.Basic_Exercises
{
    public class Day5
    {
        public Day5()
        {

            //Draw christmas tree
            int xMasTreeSize;
            Console.WriteLine("This programe will draw x-mas tree for you");
            while (true)
            {
                Console.WriteLine("Please enter Christmas Tree height: \t");
                string userInput_TreeSize = Console.ReadLine();
                if (int.TryParse(userInput_TreeSize, out xMasTreeSize))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You can only input a number. Please try again.");
                    Console.WriteLine();
                }
            }

            int asterix = 1;
            int x = xMasTreeSize;

            for (int i = 0; i < xMasTreeSize; i++) //Drawing a tree
            {
                for (int j = 0; j < x; j++) //Adding as many spacebars as needed
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++) //Drawing stars
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                x--;
            }

            for (int i = 0; i < (xMasTreeSize); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");

            Console.WriteLine();
        }
    }
}
