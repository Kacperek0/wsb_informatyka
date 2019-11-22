using System;
namespace Podstawy_programowania.Training
{
    public class minusOne
    {
        public minusOne()
        {
            int userInput;
            //int i = 0;
            //int[] array;

            try
            {
                do
                {
                    Console.WriteLine("Please enter a number");
                    userInput = int.Parse(Console.ReadLine());
                    

                } while (userInput != -1);

                //foreach (var item in array)
                //{
                //    Console.Write("{0}\t", item);
                //}

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null ref.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Use number only");
            }
            catch (OverflowException)
            {
                Console.WriteLine("You have used to big number.");
            }


        }
    }
}
