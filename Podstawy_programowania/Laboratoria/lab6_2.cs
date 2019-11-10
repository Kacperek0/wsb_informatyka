using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab6_2
    {
        public lab6_2()
        {
            uint x = 10;
            string day;
            try
            {
                Console.WriteLine("Podaj dzień tygodnia (1-5)");
                day = Console.ReadLine();
                x = uint.Parse(day);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
            finally
            {
                Console.WriteLine("x = {0}", x);
            }

            switch (x)
            {
                case 1:
                    Console.WriteLine("Jest to poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Jest to wtorek");
                    break;
                case 3:
                    Console.WriteLine("Jest to środa");
                    break;
                case 4:
                    Console.WriteLine("Jest to czwartek");
                    break;
                case 5:
                    Console.WriteLine("Jest to piątek");
                    break;
                case 6:
                    throw new Exception("Masz już weekend, sobota!");
                case 7:
                    throw new Exception("Masz już weekend, niedziela!");
                default:
                    throw new ArgumentOutOfRangeException("Tydzień ma tylko 7 dni.");
                    
            }


        }
    }
}
