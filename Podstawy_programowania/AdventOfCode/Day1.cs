using System;

namespace Podstawy_programowania.AdventOfCode
{
    public class Day1
    {
        public Day1()
        {
            
            string[] lines = System.IO.File.ReadAllLines(@"/Users/Kacper/Documents/WSB_Informatyka/Podstawy_programowania/Podstawy_programowania/AdventOfCode");
            int[] input = new int[lines.Length];
            int i = 0;
            int sum = 0;

            foreach (var item in lines) //Change all strings from text file to ints in array input
            {
                input[i] = int.Parse(item);
                i++;
            }

            foreach (var item in input)
            {
                sum += SantasFuellCalculate(item);
            }

            Console.WriteLine(sum);
        }

        public int SantasFuellCalculate(int mass)
        {
            int fuellNeeded;

            fuellNeeded = mass / 3;
            fuellNeeded -= 2;

            return fuellNeeded;
        }
    }
}
