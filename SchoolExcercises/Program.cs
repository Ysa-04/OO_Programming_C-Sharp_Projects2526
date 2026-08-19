using Library;
using KlassenEnObjecten;
using Objecten;
using Datastructuren;
using Overerving;
using ExceptionHandling;
using System.Runtime.ExceptionServices;

namespace SchoolExcercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
            // TODO: add all excercises & menu's per chapter
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
                Console.WriteLine("\t   | Gitbook Excercises  |");
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
                Console.WriteLine("\t   1- H1 Klassen en objecten");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- Objecten (al dan niet) aanmaken");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- Datastructuren");
                Thread.Sleep(50);
                Console.WriteLine("\t   4- Overerving");
                Thread.Sleep(50);
                Console.WriteLine("\t   5- Exception Handling");
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
                        go = false;
                        break;
                    case 1:
                        Console.Clear();
                        KlassenEnObjecten.Program.Menu();
                        break;
                    case 2:
                        Console.Clear();
                        Objecten.Program.Menu();
                        break;
                    case 3:
                        Console.Clear();
                        Datastructuren.Program.Menu();
                        break;
                    case 4:
                        Console.Clear();
                        Overerving.Program.Menu();
                        break;
                    case 5:
                        Console.Clear();
                        ExceptionHandling.Program.Menu();
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
    }
}
