using System;
namespace Podstawy_programowania.Training
{
    public class S_C_R_D
    {
        public S_C_R_D()
        {

            // Napisać program obliczania sumy cyfr rozwinięcia dziesiętnego dla zadanej liczby naturalnej.

            //Description \/
            Console.WriteLine("Ten program obliczy dla Ciebie sumę cyfr rozwinięcia dziesiętnego dla dowolnej liczby naturalnej");
            Console.WriteLine("Podaj dowolną liczbę naturalną ");
            string number = Console.ReadLine();
            int i = int.Parse(number);
            //int result;
            int.Parse(number);

            //for() //spróbuj to zapakować w for loopa, na pewno się da

            //while (i != 0)
            //{
            //   result = number[i] + number[i - 1];
            //   i -= 1;
            //   Console.WriteLine(result);
            //}

            //Console.WriteLine(result); - jak wyciągnąć wynik z pamiętci pętli?

        }
    }
}
