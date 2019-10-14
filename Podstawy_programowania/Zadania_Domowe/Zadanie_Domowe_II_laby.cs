using System;
namespace Podstawy_programowania
{
    public class Zadanie_Domowe_II_laby
    {
        public Zadanie_Domowe_II_laby()
        {

            /* Użytkownik podaje z klawiatury dane dwóch boków
             * Oblicz pole prostokąta i obwód
             *
             * Wyświetl w formacie:
             * Pole prostokąta wynosi...
             * Obwód prostokąta wynosi...
             *
             * Sprawdź czy dane z klawiatury są poprawne
             * W przypadku błędnych danych wyświetl komunikat:
             * "Podałeś błędne dane"
             */

            float a1;
            float b1;

            Console.WriteLine("Podaj bok a prostokąta");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj bok b prostokąta");
            string b = Console.ReadLine();
            if (float.TryParse(a, out a1) == false) //sprawdzenie czy a jest ok
            {
                Console.WriteLine("Podałeś błędne dane.");
            }
            if (float.TryParse(b, out b1) == false) //sprawdzenie czy b jest ok
            {
                Console.WriteLine("Podałeś błędnie dane.");
            }

            if (a1 < 0 || b1 < 0)
            {
                Console.WriteLine("Wymiar prostokąta musi być liczbą dodatnią.");
                return;
            }

            float pole_prostokata = a1 * b1; //obliczenie pola prostokąta
            float obwod_prostokata = (2 * a1) + (2 * b1);

            Console.WriteLine("Pole prostokąta o bokach {0} i {1} wynosi {2}.\n" +
                "Jego obwód to {3}.", a1, b1, pole_prostokata, obwod_prostokata);

            Console.ReadKey();
        }
    }
}
