using System;
namespace Podstawy_programowania.w3resource_tasks.Basic_Exercises
{
    public class Day2
    {
        public Day2()
        {
            /* 4.Write a C# Sharp program to print the result of the specified operations. Go to the editor
               Test data:

                 -1 + 4 * 6
                 (35 + 5) % 7
                 14 + -4 * 6 / 11
                 2 + 15 / 6 * 1 - 7 % 2

                 Expected Output:
                 23
                 5
                 12
                 3
             */

            int res1 = -1 + 4 * 6;
            int res2 = (35 + 5) % 7;
            int res3 = 14 + -4 * 6 / 11;
            int res4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", res1, res2, res3, res4);

            /*
                5. Write a C# Sharp program to swap two numbers.
                Test Data:
                Input the First Number : 5
                Input the Second Number : 6
                Expected Output: 
                After Swapping :
                First Number : 6 
                Second Number : 5
            */

            Console.WriteLine("Please input first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered [{0},{1}]", num1, num2);
            Console.WriteLine("SWAP! [{1},{0}]", num1, num2);

            /*
                Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
                Test Data:
                Input the first number to multiply: 2
                Input the second number to multiply: 3
                Input the third number to multiply: 6
                Expected Output:
                2 x 3 x 6 = 36
            */

            Console.WriteLine("This simple calculator will multiply 3 inputed numbers for you.");
            Console.WriteLine("Please input first number: ");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input second number: ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input thirs number: ");
            int numC = int.Parse(Console.ReadLine());
            int resultA = numA * numB * numC;
            Console.WriteLine("Your result equals {0}", resultA);

            /*
             7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
                Test Data:
                Input the first number: 25
                Input the second number: 4
                Expected Output:
                25 + 4 = 29
                25 - 4 = 21
                25 x 4 = 100 
                25 / 4 = 6
                25 mod 4 = 1
            */

            Console.WriteLine("This program will do some simple mathematics for you. " +
                "Adding, substracting, multiplying and dividing of two given numbers.");

            Console.WriteLine("Please input first number: ");
            float num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please input second number: ");
            float num4 = float.Parse(Console.ReadLine());

            //adding
            float adding = num3 + num4;
            Console.WriteLine("{0} + {1} = {2}", num3, num4, adding);
            //substacting
            float substracting = num3 - num4;
            Console.WriteLine("{0} - {1} = {2}", num3, num4, substracting);
            //multiplying
            float multiplying = num3 * num4;
            Console.WriteLine("{0} * {1} = {2}", num3, num4, multiplying);
            //dividing
            if (num4 != 0) //avoid dividing by 0
            {
                float dividing = num3 / num4;
                Console.WriteLine("{0} / {1} = {2}", num3, num4, dividing);
            }
            else
            {
                Console.WriteLine("It's impossible to divide by 0.");
            }
            //modulo 
            if (num4 != 0) //avoid NaN with % 0
            {
                float modulo = num3 % num4;
                Console.WriteLine("{0} mod {1} = {2}", num3, num4, modulo);
            }
            else
            {
                Console.WriteLine("{0} mod {1} = 0", num3, num4);
            }

            Console.Clear();

            /*8. Write a C# Sharp program that takes a number as input and print its multiplication table. */
            Console.WriteLine("Please input a number. Program will show you multiplication table for your number");
            int num_multiply = int.Parse(Console.ReadLine());
            //int i = 0;

           /* while (i < 11) //using while loop
            {
                Console.WriteLine("{0} * {1} = {2}",num_multiply, i, (num_multiply * i));
                i++;
            }
            */
            //using for loop
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num_multiply, i, (num_multiply * i));
            }
        }
    }
}
