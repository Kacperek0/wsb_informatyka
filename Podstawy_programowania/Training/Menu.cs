using System;
namespace Podstawy_programowania.Training
{
    public class Menu
    {
        public Menu()
        {
            
            string[] loginList = new string[] {"admin", "kacper", "tata"};
            string[] passwordList = new string[] { "admin", "123456", "mama" };

            while (true)
            {
                Console.ResetColor();
                string userMenuSelectionInput;
                ushort userMenuSelection;
                Console.WriteLine("Welcome, to the menu. Please tell me what you'd like to do now");
                Console.WriteLine("\n1. Log in\n" + "2. Register\n" + "3. To be completed");
                Console.WriteLine();
                Console.WriteLine("Please enter the number you'd like to follow:");
                userMenuSelectionInput = Console.ReadLine();
                try
                {
                    userMenuSelection = ushort.Parse(userMenuSelectionInput);
                    if (userMenuSelection == 1)
                    {
                        string userLoginInput, userPasswordInput;
                        bool logInCheck = false;

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Welcome to the logging in screen.");
                        Console.ResetColor();
                        while (true)
                        {
                            Console.ResetColor();
                            Console.WriteLine("Please input login:");
                            userLoginInput = Console.ReadLine();
                            Console.WriteLine("Please input your password:");
                            userPasswordInput = Console.ReadLine();
                            for (int i = 0; i < loginList.Length; i++)
                            {
                                if (loginList[i] == userLoginInput && passwordList[i] == userPasswordInput)
                                {
                                    logInCheck = true;
                                }
                                
                            }
                            if (logInCheck)
                            {
                                string newUserLogin, newUserPassword;

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You have been logged in succesfully.");
                                Console.ResetColor();
                                Console.WriteLine("\nPlease enter new user login:");
                                newUserLogin = Console.ReadLine();
                                //loginList;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Login or password are incorret. Please try again.");
                            }
                        }
                        break;
                    }

                    if (userMenuSelection == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Welcome to the sign in screen.");
                        Console.ResetColor();

                        break;
                    }
                    if (userMenuSelection == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Welcome to the undefined screen.");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You could only select 1., 2., or 3.");
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
                    Console.WriteLine("You can only use a natural number here.");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That space can't be blank. Sorry.");
                }
            }

        }
    }
}
