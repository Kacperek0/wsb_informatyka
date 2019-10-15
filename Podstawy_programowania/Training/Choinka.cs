using System;
namespace Podstawy_programowania.Training
{
    public class Choinka
    {
        public Choinka()
        {
            /*
             * Napisać program drukujący choinkę składającą się z gwiazdek według zadanej wysokości.
             * Choinka ma rozpoczynać się od pojedynczej gwiazdki i zwiększać szerokość o 2 gwiazdki z każdym wierszem.
             * Choinka ma mieć pień o wysokości dwóch znaków. Od początku wiersza figurę należy uzupełnić spacjami.
             */

            Console.WriteLine("Hi, this app will draw a Christmas Tree for you:\n" +
                "Please let me know how high tree you'd like to have?:");
            int height = int.Parse(Console.ReadLine());
            int i = 0;
            if (height < 0)
            {
                Console.WriteLine("Lol, x-mas tree can't be zero or negative. Please try again");
                Console.Clear();
                return;
            }

            while (height != i)
            {
                Console.WriteLine("*"); //Teraz wystarczy tylko pomnożyć przez i xD i będzie działao ale nie umiem
                i += 1;
            }

            //pień :D
            Console.WriteLine("|");
            Console.WriteLine("|");
        }
    }
}
