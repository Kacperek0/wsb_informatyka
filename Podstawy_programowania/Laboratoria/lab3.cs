using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab3
    {
        public lab3()
        {
            Console.WriteLine("Podaj x:");
            string x = Console.ReadLine();
            //uint x1 = uint.Parse(x);

            if (uint.TryParse(x, out uint x1) == false) //jak sprawdzić czy użytkownik podał prawidłowe dane
            {
                Console.WriteLine("Błędne dane");
            }
            else
            {
                if (x1 % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest parzysta.", x1);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest nieparzysta.", x1);
                }
            }

            //switch

            string kraj;
            Console.WriteLine("podaj kraj pochodzenia");
            kraj = Console.ReadLine();

            switch (kraj.ToLower())
            {
                case "polska":
                    Console.WriteLine("Kraj pochodzenia: Polska");
                    break; //bez break'a nie zadziała
                case "hiszpania":
                    Console.WriteLine("Kraj pochodzenia: Hiszpania");
                    break;
                default:
                    Console.WriteLine("Inny kraj pochodzenia: {0}", kraj);
                    break;
            }

            //pętle
            //program, który sumuje liczby nieparzyste z przedziału od 1 do 10
            int lab1 = 0;

            for (int lab2 = 1; lab2 < 10; lab2++)
            {
                if (lab2 % 2 != 0)
                {
                    lab1 += lab2;
                }

            }
            Console.WriteLine("Suma wynosi {0}", lab1);


            //wypisz duże litery od A do Z.
            //wypisz duże litery od Z do A.

            //\n jest charem, char występuje pomiędzy 'x'
            char znak = 'A';

            for (; znak <= 'Z'; znak++) //a-z
            {
                if (znak == 'Z')
                {
                    Console.Write("{0}. ", znak);
                }
                else
                {
                    Console.Write("{0},", znak);
                }
            }

            znak--;
            Console.WriteLine();
            for (; znak >= 'A'; znak--) //z-a
            {
                if (znak == 'A')
                {
                    Console.Write("{0}. ", znak);
                }
                else
                {
                    Console.Write("{0},", znak);
                }
            }


            //napisz program, który za pomocą pętli while dla danych wartości x zmieniających się w przedziale od 0 do 10
            //oblicza wartość funkcji y = 3x

            Console.Clear();
            int petla1 = 0;
            int petla2 = 0;

            while (petla1 <= 10) //TU nie ma średnika
            {
                petla2 = 3 * petla1;
                Console.WriteLine("x = {0},\ty = {1}", petla1, petla2);
                petla1 ++;
            }

            //napisz program, który za pomocą instrukcji while dla danych wartości x zmieniających się w przedziale od 1 do 50
            //obliczy ich sumę

            int suma = 0;
            int suma2 = 0;

            while (suma <= 50)
            {
                suma2 += suma;
                suma++;
            }
            Console.WriteLine(suma2);

            /* Użytkownik podaje z klawiatury swój wiek, z przedziału od 1 do 120.
             * Wykorzystaj instrukcję do while do prawidłowego podania danych (wykona się przynajmniej raz)
             */

            int age;

            do
            {
                Console.WriteLine("Podaj swój wiek");
                age = int.Parse(Console.ReadLine());   
            } while (age < 1 || age > 120);

            Console.WriteLine("Wiek wynosi {0}", age);
        }
    }
}