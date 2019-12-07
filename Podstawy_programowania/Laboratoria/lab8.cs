using System;
using System.IO;
namespace Podstawy_programowania.Laboratoria
{
    public class lab8
    {
        public lab8()
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            Console.WriteLine(wsbDir.FullName);

            DirectoryInfo studentDir = new DirectoryInfo(@"/Users/Kacper"); // @ - operator ignorowania błędów

            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);

            DirectoryInfo newDirectory = new DirectoryInfo(@"/Users/Kacper/c#files");

            string[] customers =
            {
                "Anna Kowalska",
                "Twoja Stara",
                "Twoj Stary",

            };

            string path = @"/Users/Kacper/c#files";

            if (Directory.Exists(path))
            {
                Console.WriteLine("\n\nKatalog istnieje");
            }
            else
            {
                Directory.CreateDirectory(@"/Users/Kacper/c#files");
                string textFilePath = @"/Users/Kacper/c#files/text.txt";

                File.WriteAllLines(textFilePath, customers);
            }








        }
    }
}
