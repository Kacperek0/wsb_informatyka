using System;
namespace Podstawy_programowania.w3resource_tasks.Loops
{
    public class Day2
    {
        public Day2()
        {
            //3.Write a program in C# Sharp to display n terms of natural number and their sum.

            Console.WriteLine("Please enter the last number of a sum you'd like to know");
            string userInput = Console.ReadLine();
            float sum = 0;
            float lastNumber;

            while (true)
            {
                if (float.TryParse(userInput, out lastNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You can input only a number. Please try again.");
                }
            }
            for (int i = 0; i <= lastNumber; i++)
            {
                sum += i;
            }

            float average = sum / lastNumber;

            Console.WriteLine("Sum from 1 to {0} equals: {1}", lastNumber, sum);
            Console.WriteLine("Average of all numbers equals: {0}", average);

            //4.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            Console.WriteLine("Please input for how many numbers you'd like to count sum and average:");
            string userInput_givenNumbersCount = Console.ReadLine();
            int givenNumbersCount;

            while (true)
            {
                if (int.TryParse(userInput_givenNumbersCount, out givenNumbersCount))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You can only input a number. Please try again.");
                }
            }

            float[] userInputsArray = new float[givenNumbersCount];

            for (int i = 0; i < givenNumbersCount; i++)
            {
                Console.WriteLine("Please input {0} of {1} numbers", (i + 1), givenNumbersCount);
                userInputsArray[i] = float.Parse(Console.ReadLine());
            }

            float forLoopSum = 0;

            foreach (var item in userInputsArray)
            {
                forLoopSum += item;
            }

            float task4Average = forLoopSum / givenNumbersCount;

            Console.WriteLine("Sum of given numbers equals {0}.\n Average is {1}", forLoopSum, task4Average);
        }
    }
}
