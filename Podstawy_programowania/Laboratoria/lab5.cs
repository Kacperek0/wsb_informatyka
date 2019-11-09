using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab5
    {
        public lab5()
        {
            //Uproszczone wyrażenia inicjalizacji

            char[] vowels = { 'a', 'i', 'o', 'u', 'y' };

            Console.WriteLine(vowels[2]);

            int[,] age =
            {
                {10, 20},
                {10, 20},
                {10, 20},
            };

         Console.WriteLine(age[2, 0]);


            string[][] name =
            {
                new string[] {"Anna"},
                new string[] {"Anna", "Nowak", "30"},
                new string[] {"Krzysztof", "Malina"}
            };

            Console.WriteLine(name[2][1]);

            Console.WriteLine("Ilość wymiarów {0}", vowels.Rank); //wyświetla ilość wymiarów tablicy
            Console.WriteLine("Ilość wymiarów {0}", age.Rank); //2
            Console.WriteLine("Ilość wymiarów {0}", name.Rank); //1 bo więcej wymiarów mają tablice zagnieżdżone
            Console.WriteLine("Ilość wymiarów {0}", name[2].Rank); //2 - wymiar wskazanej tablicy w tablicy

            // Kopiowanie tablic

            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[7];

            tab.CopyTo(tabCopy, 0); //jaka tablica od którego miejsca

            foreach (var item in tabCopy)
            {
                Console.WriteLine("{0}", item);
            }

            //Drugi sposób
            Console.WriteLine();

            int[] tab1 = { 1, 2, 3, 4, 5 };
            int[] tabCopy1 = new int[7];

            Array.Copy(tab1, tabCopy1, tab.Length);
            foreach (var item in tabCopy1)
            {
                Console.Write("{0}", item);
            }



        }
    }
}
