using System;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, let's count your BMI!\n");
            Console.WriteLine("Enter your height in centimeters: ");
            string height = Console.ReadLine();
            Console.WriteLine("So you are {0} cm high", height);
            Console.WriteLine("Now please enter your weight in kilograms: ");
            string weight = Console.ReadLine();
            Console.WriteLine("So weight {0} kilograms", weight);
            Console.WriteLine("Now we will check your BMI");
            int h = int.Parse(height)/100;
            int w = int.Parse(weight);
            int bmi = w / (h * h);  //obliczanie BMI
            Console.WriteLine("Your BMI is equal to {0}", bmi);

            //Wniosek po obliczeniu BMI

            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweighted.");
            }
            if (bmi < 25 && bmi > 18.5)
                Console.WriteLine("You are in prerfect weight!");
            if (bmi > 25 && bmi < 30)
            {
                Console.WriteLine("You are slightly overweighted :(.");
            }
            else
            {
                Console.WriteLine("You are overweighted");
            }
          

            Console.ReadKey();


            }
        }
    }
;
