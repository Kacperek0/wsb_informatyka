using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab4
    {
        public lab4()
        {

            //tabliczka mnożenia
            int w = 1, k;

            do
            {
                k = 1;
                do
                {
                    Console.Write("{0}, \t", (w * k));
                    k++;
                } while (k <= 10);
                Console.WriteLine();

                w++;
            } while (w <= 10);

            //tablice pętla foreach

            int count = 1;
            int[] array = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            foreach (var value in array)
            {
                Console.WriteLine("Wartość {0}; {1}", count, value);
                count++;
            }

            Console.Clear();

            //break

            for (int i = 1; ; i++)
            {
                Console.WriteLine("i wynosi {0}", i);
                if (i == 8)
                {
                    break;
                }
            }

            Console.Clear();
            //continue

            int j = 0;

            for (; j <= 10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(j);
                }
            }

            Console.Clear();

            //deklaracja tablicy o nazwie tab typu całkowitego o rozmiarze n = 10
            int n = 10;

            int[] tab = new int[n];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }

            //wyświetlenie zawartości tab
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("{0} ,", tab[i]);
            }

            Console.Clear();
            //zapytaj użytkownika o ulubione kolory (5) przypisz je do tablicy i wyświetl

            /* program z kolorami
            int n1 = 5;
            int cnt = 1;

            string[] colors = new string[n1];

            for (int i = 0; i < colors.Length; i++)
            {
               
                Console.WriteLine("Podaj swój {0} ulubiony kolor", cnt);
                colors[i] = Console.ReadLine();
                cnt++;

            }

            int u = 0;
            while (u < colors.Length) //wyświetlanie while'm jest lepsze
            {
                Console.WriteLine("Twój ulubiony kolor to {0}", colors[u]);
                u++;
            }
            */


            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine("Twój ulubiony kolor to {0}", colors[i]);
            //}

            //tablice prostokątne

            int[,] wartosci = new int[,]
            {
                {0, 1, 2, 3 },
                {4, 5, 6, 7 },
                {8, 9, 10, 11 },
                {12, 13, 14, 15}
            };

            Console.WriteLine("{0}", wartosci.GetLength(0)); //4

            for (int i = 0; i < wartosci.GetLength(0); i++)
            {
                for (int q = 0; q < wartosci.GetLength(1); q++)
                {
                    Console.Write("{0}\t", wartosci[i, q]);
                }
                Console.WriteLine();
            }
            Console.Clear();
            //tablicza liczb 3x3 i będzie wypełniana odpowiednią ilością

            //tablica nieregularna

            int[][] num = new int[3][]
                 {
                    new int[] {1,2},
                    new int[] {4,5,6},
                    new int[] {6}
                  };

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int l = 0; l < num[i].Length; l++)
                {
                    Console.WriteLine("numbers[{0}, {1}] = {2}", i, l, num[i][l]);
                }
                Console.WriteLine();
            }

        }
    }
}
