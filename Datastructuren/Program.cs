using Library;
using System.Security.Cryptography.X509Certificates;
namespace Datastructuren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            bool go = true;
            while (go)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Library.Program.ShowLogo();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   |  H3. Datastructuren |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string title = "MENU";
                string border = "*-*-*-*-*-*-*-*-*";
                ConsoleMethods.CharByChar(title);
                Console.WriteLine();
                ConsoleMethods.CharByChar(border);
                Console.WriteLine();
                Console.WriteLine("\t   0- EXIT");
                Thread.Sleep(50);
                Console.WriteLine("\t   1- PhoneBookNameNumber");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- PhoneBookCityNameNumber");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- ");
                Thread.Sleep(50);
                Console.WriteLine("\t   4- ");
                Thread.Sleep(50);
                Console.WriteLine("\t   5- ");
                Thread.Sleep(50);
                Console.WriteLine("\t   6- ");
                Thread.Sleep(50);
                Console.WriteLine("\t   7- ");
                Thread.Sleep(50);
                Console.WriteLine("\t   8- ");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                string message = "Maak je keuze: ";
                ConsoleMethods.CharByChar(message);
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();

                switch (choice)
                {
                    case 0:
                        Library.ConsoleMethods.ExitProgram();
                        Console.WriteLine();
                        Library.ConsoleMethods.BackToMainMenu();
                        go = false;
                        break;
                    case 1:
                        Console.Clear();
                        PhoneBookNameNumber();
                        break;
                    case 2:
                        Console.Clear();
                        PhoneBookCityNameNumber();
                        break;
                    default:
                        Library.Messages.ErrorMessage("Invalid input value");
                        Thread.Sleep(500);
                        Library.Messages.InfoMessage("Press <ENTER> to reload menu");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public static void PhoneBookNameNumber()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            Console.WriteLine("Wil je een naam en nummer toevoegen? (ja/nee)");
            string answer = Console.ReadLine();
            bool go = false;
            if (answer.Trim().ToLower() == "ja")
            {
                go = true;
            }

            while (go)
            {
                Console.Write("Naam?: ");
                string name = Console.ReadLine();
                Console.Write("Nummer?: ");
                string number = Console.ReadLine();
                phonebook.Add(name, number);
                Console.WriteLine("Wil je nog een naam en nummer toevoegen? (ja/nee)");
                answer = Console.ReadLine();
                if (answer.Trim().ToLower() == "nee")
                {
                    go = false;
                }
            }

            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key}:\t{item.Value}");
            }

            Library.ConsoleMethods.Continue();
            
        }

        public static void PhoneBookCityNameNumber()
        {
            Dictionary<string, Dictionary<string, string>> phoneBook = new Dictionary<string, Dictionary<string, string>>();
            Console.WriteLine("Wil je een gemeente, naam en nummer inlezen?");
            string go = Console.ReadLine();
            while (go.ToLower() == "ja")
            {
                Console.WriteLine("Gemeente?");
                string city = Console.ReadLine();
                if (!phoneBook.ContainsKey(city))
                {
                    phoneBook.Add(city, new Dictionary<string, string>());
                }
                Console.WriteLine("Naam?");
                string name = Console.ReadLine();
                Console.WriteLine("Nummer?");
                string number = Console.ReadLine();
                phoneBook[city][name] = number;
                Console.WriteLine("Wil je nog een gemeente, naam en nummer inlezen?");
                go = Console.ReadLine();
            }
            foreach (var city in phoneBook)
            {
                Console.WriteLine($"Gemeente: {city.Key}");
                foreach (var nameNumber in city.Value)
                {
                    Console.WriteLine($"{nameNumber.Key}: {nameNumber.Value}");
                }
            }
        }

        
    }
}
