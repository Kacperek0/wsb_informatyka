using System;


namespace Podstawy_programowania.Laboratoria
{
    public class lab6
    {
        public lab6()
        {
            Console.WriteLine("Test");

           
        }
    }
}

namespace first_name
{
    class namespace_1
    {
        public void method()
        {
            Console.WriteLine("Wewnątrz pierwszej przestrzeni nazw");
        }
    }
}

namespace second_name
{
    class namespace_2
    {
        public void method()
        {
            Console.WriteLine("Wewnątrz pierwszej przestrzeni nazw");
        }
    }
}

//namespace Outer
//{
//    namespace Middle
//    {
//        namespace Inner
//        {
//            class Prog
//            {
//                public int x, y;
//                public int add(int x, int y)
//                {
//                    return x + y;
//                }
//            }
//        }
//    }
//}