using System;
namespace Podstawy_programowania.Training
{
    public class Menu
    {
        public Menu()
        {
            
            string[] loginList = {"admin", "kacper", "tata"};
            string[] passwordList = {"admin", "123456", "mama"};
            string[] newLoginList = new string[loginList.Length + 1];
            string[] newPasswordList = new string[passwordList.Length + 1];
            loginList.CopyTo(newLoginList, 0);
            passwordList.CopyTo(newPasswordList, 0);

            while (true)
            {
                Console.ResetColor();
                string userMenuSelectionInput;
                ushort userMenuSelection;
                Console.WriteLine("\nWelcome, to the menu. Please tell me what you'd like to do now");
                Console.WriteLine("\n1. Log in\n" + "2. Register\n" + "3. To be completed\n" + "0. To exit.");
                Console.WriteLine("Please enter the number you'd like to follow:");
                userMenuSelectionInput = Console.ReadLine();
                while (true)
                {
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
                                //userLoginInput = null;
                                Console.WriteLine("Please input your password:");
                                userPasswordInput = Console.ReadLine();
                                //userPasswordInput = null;
                                for (int i = 0; i < newLoginList.Length; i++)
                                {

                                    if (newLoginList[i] == userLoginInput && newPasswordList[i] == userPasswordInput && newLoginList[i] != null)
                                    {
                                        logInCheck = true;
                                    }

                                }
                                if (logInCheck)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("You have been logged in succesfully.");
                                    Console.ResetColor();
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

                        else if (userMenuSelection == 2)
                        {
                            string newUserLogin, newUserPassword;

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Welcome to the sign in screen.");
                            Console.ResetColor();

                            Console.WriteLine("\nPlease enter new user login:");
                            newUserLogin = Console.ReadLine();
                            newLoginList[^1] = newUserLogin;

                            Console.WriteLine("\nPlease enter new password:");
                            newUserPassword = Console.ReadLine();
                            newLoginList[^1] = newUserLogin;

                            break;
                        }
                        else if (userMenuSelection == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Welcome to the undefined screen.");
                            Console.ResetColor();
                            break;
                        }
                        else if (userMenuSelection == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have exit successfully.");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You could only select 1., 2., 3. or 0. to exit.");
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
}
