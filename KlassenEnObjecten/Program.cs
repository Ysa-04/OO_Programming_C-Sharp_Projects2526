using Library;
using System.Globalization;
namespace KlassenEnObjecten
{
    public class Program
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
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   |  H1. Klassen en objecten  |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
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
                Console.WriteLine("\t   1- Clock");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- Birthday");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- DayOfTheWeek");
                Thread.Sleep(50);
                Console.WriteLine("\t   4- ");
                Thread.Sleep(50);
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
                        Clock();
                        break;
                    case 2:
                        Console.Clear();
                        Birthday();
                        break;
                    case 3:
                        Console.Clear();
                        DayOfTheWeek();
                        break;
                    case 4:
                        Console.Clear();
                        TicksSince2000();
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
        public static void Clock()
        {
            while (true)
            {
                Console.Clear();
                DateTime time = DateTime.Now;
                Console.WriteLine(time.ToString("T"));
                System.Threading.Thread.Sleep(1000);
            }
        }

        public static void Birthday()
        {
            Console.Write("Wanneer is je verjaardag? (DD/MM) ");
            DateTime userBirthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;

            DateTime birthdayThisYear = new DateTime(today.Year, userBirthday.Month, userBirthday.Day);
            TimeSpan diff = birthdayThisYear - today;

            if (diff.Days == 0)
            {
                Console.WriteLine("Vandaag is je verjaardag! Gefeliciteerd!");
            }
            else if (diff.Days == 1)
            {
                Console.WriteLine("Je bent morgen jarig!");
            }
            else if (diff.Days == -1)
            {
                Console.WriteLine("Je was gisteren jarig, proficiat nog!");
            }
            else
            {
                if (diff.Days < 0)
                {
                    birthdayThisYear = birthdayThisYear.AddYears(1);
                    diff = birthdayThisYear - today;
                }

                Console.WriteLine($"Nog {diff.TotalDays} dagen tot je verjaardag!");
            }
        }
        public static void DayOfTheWeek()
        {
            Console.WriteLine("Welke dag?");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welke maand?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welk jaar?");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            CultureInfo belgianCI = new CultureInfo("nl-BE");

            Console.WriteLine($"{date.ToString("d MMMM yyyy", belgianCI)} is een {date.ToString("dddd")}"); // geen DayOfWeek gebruiken
        }
        public static void TicksSince2000()
        {

        }

    }
}
