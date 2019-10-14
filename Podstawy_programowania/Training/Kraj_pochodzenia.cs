using System;
namespace Podstawy_programowania
{
    public class Kraj_pochodzenia
    {
        public Kraj_pochodzenia()
        {
            /*Użytkownik podaje narodowość
             *wykorzystaj switch do wyświetlenia pochodzenia
             * polska,usa,hiszpania
             */

            Console.WriteLine("Podaj swój kraj pochodzenia:");
            string origin = Console.ReadLine().ToLower();

            switch (origin) //można dodawać wyrażenia
            {
                case "polska":
                    Console.WriteLine("\nPochodzisz z Polski");
                    break; //case zawsze musi kończyć break
                case "usa":
                    Console.WriteLine("\nPochodzisz z USA");
                    break;
                case "hiszpania":
                    Console.WriteLine("\nPochodzisz z Hiszpanii");
                    break;
                default:
                    Console.WriteLine("\nPochodzisz z innego Państwa - {0}", origin);
                    break; //default też musi kończyć break

            }
        }
    }
}