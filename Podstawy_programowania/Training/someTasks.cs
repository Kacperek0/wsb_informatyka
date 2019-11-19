using System;
namespace Podstawy_programowania.Training
{
    public class someTasks
    {
        public someTasks()
        {
            string userInput;
            ushort treeHeight;

            while (true)
            {
                Console.WriteLine("This program will draw a Christmas Tree for you.\nPlease input what height you'd like to have");

                userInput = Console.ReadLine();

                try
                {
                    treeHeight = ushort.Parse(userInput);
                    ushort treeWidth = treeHeight;
                    ushort star = 1;
                    for (int i = 0; i < treeHeight; i++) //Drawing tree
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < treeWidth; j++)
                        {
                            Console.Write(" ");
                        }
                        treeWidth--;
                        for (int k = 0; k < star; k++)
                        {
                            Console.Write("* ");
                        }
                        star++;
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                    for (int i = 0; i < (treeHeight); i++) //Drawing tree log.
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("|");
                    Console.ResetColor();
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Sorry, you can't input null here.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You cannot use {0} here. Try other number.", userInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You can use number only.");
                }


            }
        }
    }
}
