using System;
namespace Podstawy_programowania.w3resource_tasks.Basic_Exercises
{
    public class Day1
    {
        public Day1()
        {
            /* 1.Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
            *Expected Output : 
            Hello: Alexandra Abramov
            */

            Console.WriteLine("What's your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hello: {0}", username);

            Console.Clear();
            /* 2. Write a C# Sharp program to print the sum of two numbers.
             */

            Console.WriteLine("Please input the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            int result1 = number1 + number2;
            Console.WriteLine("Sum of your numbers equal: {0}.", result1);


            //3.Write a C# Sharp program to print the result of dividing two numbers.

            int number3, number4, result2;
            Console.WriteLine("Please input the first number: ");number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number: ");number4 = int.Parse(Console.ReadLine());
            if (number4 == 0)
            {
                Console.WriteLine("Dividing by 0 is impossible, please try with another number.");
                return;
            }

            result2 = number3 / number4;
            Console.WriteLine("Result of division is {0}", result2);

        }
    }
}
