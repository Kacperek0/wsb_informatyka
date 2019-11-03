using System;

namespace Podstawy_programowania.w3resource_tasks.Basic_Exercises
{
    public class Day4
    {
        public Day4()
        {
            /*
            12.Write a C# program to that takes a number as input and display it four times in a row
            (separated by blank spaces), and then four times in the next row, with no separation.
            You should do it two times: Use Console. Write and then use {0}.
            */
            string c, times1;
            int c1, times;

            do
            {
                Console.WriteLine("Please input any number: ");
                c = Console.ReadLine();
                if (int.TryParse(c, out c1) == false)
                {
                    Console.WriteLine("You can use number only.");
                    Console.WriteLine("Please try again.");
                }
                else
                {
                    break;
                }
            } while (true);

            
            do
            {
                Console.WriteLine("Let me know how many times you'd like to multiply a display.");
                times1 = Console.ReadLine();
                if (int.TryParse(times1, out times) == false)
                {
                    Console.WriteLine("You can use a number only.");
                    Console.WriteLine("Please try again");
                }
                else
                {
                    break;
                }

            } while (true);

            for (int i = 0; i < times; i++)
            {
                Console.Write("{0}", c1);
            }

            Console.WriteLine();
            for (int i = 0; i < times; i++)
            {
                Console.Write("{0} ", c1);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            //14.Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

            double temp, temp_k, temp_f, absolute_zero;

            absolute_zero = -273.15;
            Console.WriteLine("Please input temperature in Celsius you'd like to have converted: ");
            temp = Convert.ToDouble(Console.ReadLine());
            temp_f = temp * 1.8 + 32;
            temp_k = temp + 273.15;

            if (temp_k < 0)
            {
                Console.WriteLine("{0} is {1} degrees below absolute zero. It exists only in theory.", temp, (absolute_zero - temp));
            }
            else
            {
                Console.WriteLine("Given temp. equals {0} F and {1} K.", temp_f, temp_k);
            }
            /* 15.Write a C# program remove specified a character from a non-empty
            string using index of a character. */

            Console.WriteLine("Please input any word you'd like: ");
            string user_input = Console.ReadLine();

            Console.WriteLine(user_input.Remove(1,3));
            Console.WriteLine(user_input.Remove(5));
            Console.WriteLine(user_input.Remove(0,1));


        }
    }
}
