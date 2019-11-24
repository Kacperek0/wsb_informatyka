using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab7
    {
        public lab7()
        {
            Add(2, 3); //typ zmiennych jest już zdefiniowany
            Add(1, 2, 3);
            Console.WriteLine("Pole kwadratu : {0}", SquareArea(4));
            Console.WriteLine("Suma: {0}", Add(1));//8
            //Console.WriteLine("Suma: {0}", Add(1,2));//Nie zadziała bo próbuje zrobić cw w cw.
            Console.WriteLine("Suma: {0}", Add(1, d:2));//9 - d: nadpisało d z funkcji. Musi być w tej kolejności.
            Data("Adi", age:30);

        }

        static void Add(int a, int b) //nazwy funkcji wielką literą - name convention - void nie zwraca
        {
            Console.WriteLine("Wynik dodawania: {0}", a + b);
        }

        static void Add(int a, int b, int c) //dodanie 3ciego argumentu powoduje przeciążenie.
        {
            Console.WriteLine("Wynik dodawania: {0}", a + b + c);

        }

        static int SquareArea(int a) //zwraca
        {
            return a * a; //funkcja musi zwróić na zewnątrz
        }

        static int Add(int a, int b = 4, int c = 2, int d = 1) //argumenty z przypisaną wartością muszą być podane na końcu!
        {
            return a + b + c + d;
        }

        static void Data(string name, string surname = "Nowak", int age = 20)
        {
            Console.WriteLine("Imię: {0}\tNazwisko: {1}\tWiek: {2}", name, surname, age);
        }
    }
}
