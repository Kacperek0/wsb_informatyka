using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab1_lab2
    {
        public lab1_lab2()
        {
            //komentarz
            Console.Write("Imię: "); //wyświetli imię
            Console.WriteLine("Janusz");

            /* Komentarz
             * w wielu
             * liniach
             */

            /*
             *  #
             *  ##
             *  ###
             *  ####
             */

            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Kasia";

            // + konkatenacja
            Console.WriteLine("\nMasz na imię: " + name);

            Console.WriteLine("Masz na imię: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek: {1} lat", name, age);

            sbyte age1 = 20;
            Console.WriteLine("Wiek: {0}", age1);

            /*
             * Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */

            Console.Write("\nPodaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("a = {0}",a);

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            /*
             * oblicz pole trójkąta
             * dane podaje użytkownik z klawiatury
             */

            Console.Clear();
            Console.Write("\nPodaj podstawę trójkąta:");
            string podstawa = Console.ReadLine();

            Console.Write("\nPodaj wysokość trójkąta:");
            string wysokosc = Console.ReadLine();

            result = 0.5 * double.Parse(podstawa) * double.Parse(wysokosc);

            Console.WriteLine("Pole trójkąta: {0}", result);
            Console.Clear();

            //#################################################

            string str;
            int liczba;

            Console.Write("Podaj liczbę całkowitą:");
            str = Console.ReadLine();

            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
                Console.WriteLine("Zły format liczby!");
            else
                Console.WriteLine("Liczba wynosi: {0}", liczba);

            /*
             * Sprawdź czy dane podane z klawiatury są
             * liczbą całkowitą dodatnią
             * następnie sprawdź czy jest nieparzysta
             */

            Console.WriteLine("\nPodaj liczbę całkowitą: ");
            string number = Console.ReadLine();
            uint numberUint;

            if (uint.TryParse(number, out numberUint) == true)
            {
                if (numberUint % 2 != 0)
                    Console.WriteLine("Liczba {0} nie jest parzysta", numberUint);
                else
                    Console.WriteLine("Liczba {0} jest parzysta", numberUint);
            }
            else
                Console.WriteLine("Podane dane z klawiatury są błędne!");

            /*
            * Użytkownik podaje z klawiatury dane dwóch boków
            * Oblicz pole prostokąta i obwód
            * 
            * Wyświetl w formacie:
            * Pole prostokąta wynosi: ...
            * Obwód prostokąta wynosi: ...
            * 
            * Sprawdź czy dane z klawiatury są poprawne
            * W przypadku błędnych danych wyświetl na ekranie komunikat:
            * "Podałeś błędne dane"
            */

            age = 18;

            if (age == 18)
                Console.WriteLine("Masz 18 lat");
            else if (age < 18)
                Console.WriteLine("Masz mniej niż 18 lat");
            else
                Console.WriteLine("Masz więcej niż 18 lat");

            //switch

            liczba = 11;

            switch (liczba)
            {
                case 5:
                    Console.WriteLine("\nLiczba = 5");
                    break;
                case 10:
                    Console.WriteLine("\nLiczba = 10");
                    break;
                case 15:
                    Console.WriteLine("\nLiczba = 15");
                    break;
                default:
                    Console.WriteLine("Liczba posiada inną wartością");
                    break;
            }

            Console.Clear();
            /*
             * Użytkownik podaje narodowość
             * wykorzystaj switch do wyświetlenia pochodzenia  
             * polska, usa, hiszpania
             */

            string kraj;
            Console.Write("Podaj kraj pochodzenia:");
            kraj = Console.ReadLine();
            //kraj = kraj.ToLower();
            switch (kraj.ToLower())
            {
                case "polska":
                    Console.WriteLine("\nKraj pochodzenia: Polska");
                    break;
                case "niemcy":
                    Console.WriteLine("\nKraj pochodzenia: Niemcy");
                    break;
                case "hiszpania":
                    Console.WriteLine("\nKraj pochodzenia: Hiszpania");
                    break;
                default:
                    Console.WriteLine("\nInny kraj pochodzenia");
                    break;
            }

            int i = 1;

            for (i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }


            Console.ReadKey();
        }
    }
}
