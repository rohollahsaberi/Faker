using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Professor!");
            Console.WriteLine("what is you need?");
            Console.WriteLine("1: Email");
            Console.WriteLine("2: Password");
            Console.WriteLine("3: Name");
            Console.WriteLine("4: Username");
            //Console.WriteLine("5: Password");
            Console.WriteLine();
            Console.WriteLine();





            var order = Console.ReadLine();
            switch (order)
            {
                case "1":
                    {
                        CreateFakeEmail();
                    }
                    break;
                case "2":
                    {
                        CreatePassword();
                    }
                    break;
                case "3":
                    {
                        CreateFakeName();
                    }
                    break;
                case "4":
                    {
                        CreateUsername();
                    }
                    break;
            }
        }

        private static void CreateUsername()
        {
            throw new NotImplementedException();
        }

        private static void CreateFakeName()
        {
            throw new NotImplementedException();
        }

        private static void CreatePassword()
        {
            Console.WriteLine("do you need a password? ok, lets go.");

            Console.WriteLine("can i use Lowercase char? y/n");
            var lowercase = Console.ReadLine() == "y" ? true : false;

            Console.WriteLine("can i use Uppercase char? y/n");
            var uppercase = Console.ReadLine() == "y" ? true : false;

            if (lowercase == false && uppercase == false)
            {
                Console.WriteLine("Oops! you need use charecter, then i use lowercase char.");
                lowercase = true;
            }

            Console.WriteLine("can i use Numeric char? y/n");
            var numeric = Console.ReadLine() == "y" ? true : false;

            Console.WriteLine("can i use Special char? y/n");
            var special = Console.ReadLine() == "y" ? true : false;

            Console.WriteLine("how many char you need?");
            var lenth = Convert.ToInt32(Console.ReadLine());


            // Same as above but you can set the length. Must be between 8 and 128
            // Will return a password which only contains lowercase and uppercase characters and is 21 characters long.
            PasswordGenerator pwdGen = new PasswordGenerator(includeLowercase: lowercase, includeUppercase: uppercase, includeNumeric: numeric, includeSpecial: special, passwordLength: lenth);
            string password = pwdGen.Next();
            Console.WriteLine("wow, your password is ready!");
            Console.WriteLine(password);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Main(null);

        }

        private static void CreateFakeEmail()
        {
            Console.WriteLine();
            Console.WriteLine("how many you need?");
            var count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("and server name?");
            var service = Console.ReadLine();
            if (service == "")
            {
                service = "@vc.ir";
            }

            var rnd = new Random();
            List<string> Emails = new List<string>();
            for (int i = 0; i < count; i++)
            {
                var personGenerator = new PersonNameGenerator();
                var num = rnd.Next(123, 1447852);
                var email = personGenerator.GenerateRandomFirstName() + "." + personGenerator.GenerateRandomLastName() + num + "@" + service + ":limx=" + rnd.Next(111, 222);
                Emails.Add(email);
            }

            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/email for professor.txt", Emails);
            Console.WriteLine("End");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Main(null);
        }
    }
}
