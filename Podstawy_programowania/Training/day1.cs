using System;
namespace Podstawy_programowania.Training
{
    public class day1
    {
        public day1()
        {
            /*
            Dla macierzy kwadratowej wprowadzanej z klawiatury wierszami zbadać,
            czy suma elementów powyżej głównej przekątnej
            jest większa od sumy elementów poniżej tej przekątnej.
            */

            uint size;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the size of matrix you'd like to have.");
                    size = uint.Parse(Console.ReadLine());
                    uint[,] matrix = new uint[size, size];


                    for (int i = 0; i < (size); i++)
                    {
                        for (int j = 0; j < (size); j++)
                        {
                            try
                            {
                                Console.WriteLine("Please input [{0},{1}] number = ", i, j);
                                matrix[i, j] = uint.Parse(Console.ReadLine());
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("Sorry null cannot be an input here");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("You can't use that.");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("You can use a number only here.");
                            }
                        }
                    }

                    Console.WriteLine("Ok. Let's see your matrix now.\n");

                    for (int i = 0; i < size; i++) //drawing matrix
                    {
                        for (int j = 0; j < size; j++)
                        {
                            Console.Write("{0}\t", matrix[i, j]);
                        }
                        Console.WriteLine();
                    }

                    uint diagonalSum = 0;
                    uint belowDiagonalSum = 0;

                    for (int i = 0; i < size; i++) //diagonal && below diagonal sum
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i == j)
                            {
                                diagonalSum += matrix[i,j];
                            }
                            else if (j < i)
                            {
                                belowDiagonalSum += matrix[i, j];
                            }
                        }
                    }


                    Console.WriteLine("Diagonal sum equals {0} \nBelow diagonal sum equals {1}", diagonalSum, belowDiagonalSum);

                    break;

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Sorry null cannot be an input here");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You can't use that.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You can use a number only here.");
                }
            }

        }
    }
}
