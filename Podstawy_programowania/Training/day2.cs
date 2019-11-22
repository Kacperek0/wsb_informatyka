using System;
namespace Podstawy_programowania.Training
{
    public class day2
    {
        public day2()
        {
            while (true)
            {
                ushort menuInput;

                Console.WriteLine("Welcome to the main menu. Please let me know what you'd like to do.\n" +
                    "1. Display multiplication table to desired size.\n" +
                    "2. Sum value of main diagonaly of given matrix.\n" +
                    "3. TBD.\n\n" +
                    "Press 0 to quit."
                    );
                try
                {
                    menuInput = ushort.Parse(Console.ReadLine());
                    if (menuInput == 1)
                    {
                        while (true)
                        {

                            uint multiTableSize;

                            Console.WriteLine("Please let me know how big multiplication table you'd like to see?");
                            try
                            {
                                multiTableSize = uint.Parse(Console.ReadLine());
                                for (int i = 1; i < multiTableSize + 1; i++)
                                {
                                    for (int j = 1; j < multiTableSize + 1; j++)
                                    {
                                        Console.Write("{0}\t", (i * j));
                                    }
                                    Console.WriteLine();
                                }
                                break;
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("You don't want input null, trust me.");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("You can't do that here.");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("You can use only number here.");
                            }
                        }
                    }
                    else if (menuInput == 2)
                    {
                        while (true)
                        {
                            ushort matrixSize;
                            try
                            {
                                

                                Console.WriteLine("Please input matrix square size you'd like to have.");
                                matrixSize = ushort.Parse(Console.ReadLine());
                                uint[,] matrix = new uint[matrixSize, matrixSize];

                                for (int i = 0; i < matrixSize; i++) //filling matrix
                                {
                                    for (int j = 0; j < matrixSize; j++)
                                    {
                                        try
                                        {
                                            Console.Write("Please input item number [{0},{1}]: ", i, j);
                                            matrix[i, j] = uint.Parse(Console.ReadLine());
                                        }
                                        catch (NullReferenceException)
                                        {
                                            Console.WriteLine("You don't want input null, trust me. Please try again.");
                                            break;
                                        }
                                        catch (OverflowException)
                                        {
                                            Console.WriteLine("You can't do that here. Plese try again.");
                                            break;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("You can use only number here. Please try again.");
                                            break;
                                        }

                                    }
                                }
                                uint diagonalySum = 0;

                                for (int i = 0; i < matrixSize; i++) //drawing matrix
                                {
                                    for (int j = 0; j < matrixSize; j++)
                                    {
                                        Console.Write("{0}\t", matrix[i, j]);
                                    }
                                    Console.WriteLine();

                                    for (int k = 0; k < matrixSize; k++)
                                    {
                                        if (i == k)
                                        {
                                            diagonalySum += matrix[i, k];
                                        }
                                    }
                                }

                                Console.WriteLine("Diagonaly sum of your matrix equals {0}", diagonalySum);
                                break;

                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("You don't want input null, trust me.");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("You can't do that here.");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("You can use only number here.");
                            }
                        }
                    }
                    else if (menuInput == 3)
                    {
                        break;
                    }
                    else if (menuInput == 0)
                    {
                        Console.WriteLine("Thank you. Good bye.");
                        break;   
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("You don't want input null, trust me.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You can't do that here.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You can use only number here.");
                }
            }
        }
    }
}
