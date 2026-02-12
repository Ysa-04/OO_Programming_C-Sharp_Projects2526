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
                string title = "MENU";
                string border = "*-*-*-*-*-*-*-*-*";
                ConsoleMethods.CharByChar(title);
                Console.WriteLine();
                ConsoleMethods.CharByChar(border);
                Thread.Sleep(50);
                Console.WriteLine();
                Console.WriteLine("\t   0- EXIT");
                Thread.Sleep(50);
                Console.WriteLine("\t   1- LIBRARY METHODS OVERVIEW");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- SCHOOLADMIN");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                string message = "Make your choice: ";
                Library.ConsoleMethods.CharByChar(message);
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
                        Thread.Sleep(500);
                        Library.Messages.InfoMessage("Press <ENTER> to reload menu");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

