using Library;

namespace OO_Programming_C_Sharp_Projects2526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            while (go)
            {
                Console.Clear();
                Library.Program.ShowLogo();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   | Welcome to my Projects! |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\t   MENU");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   0- EXIT");
                Console.WriteLine("\t   1- LIBRARY METHODS OVERVIEW");
                Console.WriteLine("\t   2- SCHOOLADMIN");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\t   Make your choice: ");
                string input = Console.ReadLine();
                int choice = Library.InputMethods.IntCheck(input);
                Console.ResetColor();

                switch (choice)
                {
                    case 0:
                        Library.ConsoleMethods.ExitProgram();                       
                        go = false;
                        break;
                    case 1:
                        Console.Clear();
                        ConsoleMethods.LoadScreen();
                        Library.Program.Menu();
                        break;
                    case 2:
                        Console.Clear();
                        ConsoleMethods.LoadScreen();
                        SchoolAdmin.Program.Menu();
                        break;
                    default:
                        Library.Messages.ErrorMessage("Invalid input value");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

