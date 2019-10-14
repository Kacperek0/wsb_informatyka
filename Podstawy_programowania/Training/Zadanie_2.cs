using System;
namespace Podstawy_programowania
{
    public class Zadanie_2
    {
        public Zadanie_2()
        {
            //Wykorzystując zmienne typu double obliczyć wartość wyrażenia wynoszącą:
            //a^2 +b dla c > 0
            //a - b^2 dla c < 0
            //1/a-b dla c = 0
            //Sprawdzić wykonalność obliczenia.

            Console.WriteLine("Ten kalkulator wykona dla Ciebie kilka prostych obliczeń:" +
                "\na*2 +b dla c > 0" +
                "\na - b^2 dla c < 0" +
                "\n1/a-b dla c = 0");

            Console.WriteLine("\nPodaj liczbę a:");
            string a = Console.ReadLine();
            Console.Write("Podaj liczbę b:\n");
            string b = Console.ReadLine();
            Console.WriteLine("Podaj liczbę c:");
            string c = Console.ReadLine();

            float a1;
            float b1;
            float c1;


            //sprawdź czy: a,b,c jest liczbą
            if (float.TryParse(a, out a1) == false)
            {
                Console.WriteLine("Możesz podać jedynie liczbę");
            }
            if (float.TryParse(b, out b1) == false)
            {
                Console.WriteLine("Możesz podać jedynie liczbę");
            }
            if (float.TryParse(c, out c1) == false)
            {
                Console.WriteLine("Możesz podać jedynie liczbę");
            }

            float zero_chk = a1 - b1;

            if (c1 > 0) //c większe od 0
            {
                float result_1 = (a1 * a1) + b1;
                Console.WriteLine("Twój wynik to {0}", result_1);
            }
            else if (c1 < 0) //c mniejsze od 0
            {
                float result_2 = a1 - (b1 * b1);
                Console.WriteLine("Twój wynik to {0}", result_2);
            }
            else
            {
                if (zero_chk == 0) //c równe zero
                {
                    Console.WriteLine("Nie można dzielić przez 0 :(");
                }
                else
                {
                    float result_3 = 1 / zero_chk;
                    Console.WriteLine("Twój wynik to {0}", result_3);
                }
            }
        }

    }
}