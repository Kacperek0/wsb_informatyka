using System;
namespace Podstawy_programowania.w3resource_tasks.Loops
{
    public class Day1
    {
        public Day1()
        {
            //1.Write a program in C# Sharp to display the first 10 natural numbers.

            for (int i = 1; i < 11; i++)
            {
                if (i == 10)
                {
                    Console.Write("{0}.", i);
                }
                else
                {
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine();
            //2.Write a C# Sharp program to find the sum of first 10 natural numbers.
            /* there is easier way
            int number_of_items, sum = 0;

            Console.WriteLine("For how many natural numbers you'd like to check the sum?");
            number_of_items = int.Parse(Console.ReadLine()) + 1;


            int[] array = new int[number_of_items];
            for (int i = 1; i < array.Length; i++)
            {
                array[i] += i;
            }
            foreach (var item in array)
            {
                sum += item;
            }
            Console.WriteLine("Total sum equals: {0}", sum);
            */

            int j, sum = 0;
            Console.WriteLine("Please input how many numbers you'd like to sum up:");
            j = int.Parse(Console.ReadLine());

            for (int i = 1; i <= j; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum of {0} numbers equals {1}", j, sum);


        }
    }
}
