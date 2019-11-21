using System;
//using second_name; przywołanie namespace'a
[Serializable]
public class MyException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="T:MyException"/> class
    /// </summary>
    public MyException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:MyException"/> class
    /// </summary>
    /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
    public MyException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:MyException"/> class
    /// </summary>
    /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
    /// <param name="inner">The exception that is the cause of the current exception. </param>
    public MyException(string message, System.Exception inner) : base(message, inner)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:MyException"/> class
    /// </summary>
    /// <param name="context">The contextual information about the source or destination.</param>
    /// <param name="info">The object that holds the serialized object data.</param>
    protected MyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
    {
    }
}
//using Outer.Middle.Inner;

namespace Podstawy_programowania
{
    class Program
    {
        static void Main(string[] args)
        {
            //var iteracyjny_Algorytm_Euklidesa = new Iteracyjny_Algorytm_Euklidesa(); //Wywołanie programu Iteracyjny Algorytm Euklidesa

            //var zd = new Zadanie_Domowe_II_laby(); //Wywołanie zadania domowego z II labów

            //var sc = new Training.S_C_R_D(); //tbc

            //var choinka = new Training.Choinka(); //też tbc xD

            //var day2 = new w3resource_tasks.Basic_Exercises.Day2();

            //var init = new w3resource_tasks.Basic_Exercises.Day3();

            //var lab5 = new Laboratoria.Lab5_1();

            //var lab5 = new Laboratoria.lab5_2();

            //var lab6 = new Laboratoria.lab6_3();

            /* Przywoływanie namespace'a:
             
            namespace_2 p2 = new namespace_2();
            p2.method();
            Prog x = new Prog();
            Console.WriteLine("Wynik działania: {0}", x.add(2, 5));
            */

            var menu = new Training.day1();
        }

    }
}