using System;
namespace Podstawy_programowania.Laboratoria
{
    public class lab6_3
    {
        public lab6_3()
        {
            //Utwórz tablicę, (Użytkownik podaje wielkość tablicy) wyświetl użytkownikowi a następnie zadaj pytanie jaki jest ostatni index tablicy.
            //Wyświetl ten element na ekranie w formacie.
            //Ostatni element: ...
            //Zabezpiecz program przed możliwymi wyjątkami. Użytkownk podaje wiek tablicy członków rodziny.
            //Wyświetl również średni wiek rodziny.

            string arrayLengthInput;
            uint arrayLength = 0;

            while (true) //Setting array length.
            {
                Console.ResetColor();
                try
                {
                    Console.WriteLine("Please tell me how many family members do you have?");
                    arrayLengthInput = Console.ReadLine();
                    arrayLength = ushort.Parse(arrayLengthInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only use a number here.");
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Are you sure, that you have that many family members?");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That space can't be blank. Sorry.");
                }

            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You have set successfully array's length as: {0}", arrayLength);
            Console.ResetColor();

            uint[] familyMembersAge = new uint[arrayLength]; //Creating array

            for (int i = 0; i < familyMembersAge.Length; i++)
            {
                while (true) //Parsing and checking inputs.
                {
                    Console.ResetColor();
                    try
                    {
                        Console.WriteLine("Please input {0} family's member age: ", i + 1);
                        familyMembersAge[i] = uint.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can only use a number here.");
                    }
                    catch (OverflowException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Are you sure, that your family member is that age?");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That space can't be blank. Sorry.");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't do that. Sorry. Please input something");
                    }
                }
            }

            //For - working - Printing all array
            Console.WriteLine("Family members age is: ");
            for (int i = 0; i < familyMembersAge.Length; i++)
            {
                Console.Write("{0}\t", familyMembersAge[i]);
            }
            Console.WriteLine();

            //Foreach - not working - WHY ?
            //Console.WriteLine("Family members age is: ");
            //foreach (var items in familyMembersAge)
            //{
            //    Console.Write("{0}\t", familyMembersAge[items]);
            //}
            //Console.WriteLine();
           
            string lastIndexValueInput;
            uint lastIndexValue = 0;


            while (true) //Checking if output is ok.
            {
                Console.ResetColor();
                Console.WriteLine("Please tell me how old was {0} member of your family?", (familyMembersAge.Length));
                lastIndexValueInput = Console.ReadLine();

                try
                {
                    lastIndexValue = uint.Parse(lastIndexValueInput);

                    if (lastIndexValue == familyMembersAge[arrayLength - 1])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("That's right! Thanks!");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Numbers does not match :(\nPlease try again.");

                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only use a number here.");
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Are you sure, that your family member is that age?");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That space can't be blank. Sorry.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't do that. Sorry. Please input something");
                }
            }

            //Couting average

            float ageSum = 0;
            float ageAverage;

            Console.WriteLine("Btw. in the meantime I've counted your family's age average.");

            foreach (var item in familyMembersAge)
            {
                ageSum += item;
            }

            ageAverage = ageSum / arrayLength;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("It equals {0}", ageAverage);
            Console.ResetColor();
        }
    }
}
