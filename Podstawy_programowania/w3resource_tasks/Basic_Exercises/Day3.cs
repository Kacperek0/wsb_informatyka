using System;
namespace Podstawy_programowania.w3resource_tasks.Basic_Exercises
{
    public class Day3
    {
        public Day3()
        {
            //9.Write a C# Sharp program that takes four numbers as input to calculate and print the average.

            Console.WriteLine("Hi, this program will count average form any given numbers:");
            Console.WriteLine("Please let me know from how many numbers you'd like to count average?");
            string lng = Console.ReadLine();
          
            if ((int.TryParse(lng, out int length) == false)) //Input data type check
            {
                Console.WriteLine("You can input only a number");
                return;
            }

            int[] array = new int[length];
            int counter = 1;

            for (int i = 0; i < array.Length; i++) //inputing any number of items
            {
                Console.WriteLine("Please input {0} number:", counter);
                array[i] = int.Parse(Console.ReadLine());
                counter++;
            }

            int sum = 0;

            foreach (var items in array) //adding up all the items
            {
                sum += items;
            }

            int avg;

            avg = sum / array.Length;

            Console.WriteLine("Average of given numbers equals {0}", avg);

            //Write a C# Sharp program to that takes three numbers(x,y,z)
            //as input and print the output of (x+y)*z and x*y + y*z

            int[] mylist = new int[3];
            Console.WriteLine("Input 3 numbers and you will be able to see some funny stuff xD");

            for (int i = 0; i < mylist.Length; i++)
            {
                Console.WriteLine("Please input {0} number", (i + 1));
                mylist[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("(x+y)*z equals: {0}", ((mylist[0] + mylist[1])*mylist[2]));
            Console.WriteLine("x*y + y*z equals: {0}", ((mylist[0] * mylist[1]) + (mylist[1] * mylist[2])));
        }
    }
}
