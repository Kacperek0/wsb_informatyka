using System;
namespace Podstawy_programowania.Training.Functions
{
    public class Menu
    {
        public Menu()
        {
        }

        public int StartingMenu(int a)
        {
            while (true)
            {
                if (a == 1)
                {
                    return 1;
                }
                else if (a == 2)
                {
                    return 2;
                }
            }

        }
    }
}
