using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Komentarz

            Console.WriteLine("Imię: Janusz "); //Wyświetli imię
            Console.WriteLine("Nazwisko: "); 
            /* komentarz
             * w wielu liniach
             *
             */
            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");

            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Anna";

            Console.WriteLine("\nMasz na imię: " + name);

            Console.WriteLine("Masz na imię: {0}", name);
            

            int age = 20;

            Console.WriteLine("Masz na imię {0}, i masz {1} lat.",name,age);

            sbyte age1 = 20; 
            Console.WriteLine("Wiek: {0}", age1);

            /* Użytkownik podaje z klawiatury długość boku, oblicz pole kwadratu
             */

            Console.WriteLine("\nPodaj bok a:");
            string a = Console.ReadLine();

            Console.WriteLine("a = {0}", a);

            /* decimal (128b) jest wolniejsze niż double(64b)  */

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi {0} j2", result);

            //Oblicz pole trójkąta, daje podaje użytkownik z klawiatury

            Console.WriteLine("\n Podaj wysokość trójkąta:");
            string h = Console.ReadLine();
            Console.WriteLine("Podaj długość podstawy trójkąta:");
            string b = Console.ReadLine();

            double solve = double.Parse(h) * double.Parse(b) / 2;
            Console.WriteLine("Pole trójkąta wynosi {0}.", solve);


            Console.ReadKey();
        }
    }
}
