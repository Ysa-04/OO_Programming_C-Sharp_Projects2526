using Library;
using System.Globalization;
namespace KlassenEnObjecten
{
    public class Program
    {
        public static void Main(string[] args)
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
                Console.WriteLine("\t   4- TicksSince2000");
                Thread.Sleep(50);
                Console.WriteLine("\t   5- LeapYearCount");
                Thread.Sleep(50);
                Console.WriteLine("\t   6- CodeTiming");
                Thread.Sleep(50);
                Console.WriteLine("\t   7- DemoCombinationOf2Numbers");
                Thread.Sleep(50);
                Console.WriteLine("\t   8- Figures");
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
                    case 5:
                        Console.Clear();
                        LeapYearCount();
                        break;
                    case 6:
                        Console.Clear();
                        CodeTiming();
                        break;
                    case 7:
                        Console.Clear();
                        DemoCombinationOf2Numbers();
                        break;
                    case 8:
                        //TODO: nog eens hermaken als herhaling!
                        Console.Clear();
                        Figures();
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
            Library.ConsoleMethods.Continue();
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
            Library.ConsoleMethods.Continue();
        }
        public static void TicksSince2000()
        {
            //TODO: herhalingsoef
            Library.ConsoleMethods.Continue();
        }
        public static void LeapYearCount()
        {
            //TODO: herhalingsoef
            Library.ConsoleMethods.Continue();
        }
        public static void CodeTiming()
        {
            //TODO: herhalingsoef
            Library.ConsoleMethods.Continue();
        }
        public static void DemoCombinationOf2Numbers()
        {
            CombinationOf2Numbers pair = new CombinationOf2Numbers(12,34);
            //pair.Number1 = 12;
            //pair.Number2 = 34;
            Console.WriteLine("Paar:" + pair.Number1 + ", " + pair.Number2);
            Console.WriteLine("Som = " + pair.Sum());
            Console.WriteLine("Verschil = " + pair.Difference());
            Console.WriteLine("Product = " + pair.Product());
            Console.WriteLine("Quotient = " + pair.Quotient());
            Library.ConsoleMethods.Continue();
        }

        public static void Figures() 
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Width = -1;
            rectangle1.Height = 0;
            rectangle1.Width = 2.2;
            rectangle1.Height = 1.5;
            Rectangle rectangle2 = new Rectangle();
            rectangle2.Width = 3;
            rectangle2.Height = 1;
            Triangle triangle1 = new Triangle();
            triangle1.Base = 3;
            triangle1.Height = 1;
            Triangle triangle2 = new Triangle();
            triangle2.Base = 2;
            triangle2.Height = 2;
            Console.WriteLine($"Een rechthoek met een breedte van {rectangle1.Width}m en een hoogte van {rectangle1.Height}m heeft een oppervlakte van {rectangle1.Area:F1}m²");
            Console.WriteLine($"Een rechthoek met een breedte van {rectangle2.Width}m en een hoogte van {rectangle2.Height}m heeft een oppervlakte van {rectangle2.Area:F1}m²");
            Console.WriteLine($"Een driehoek met een basis van {triangle1.Base}m en een hoogte van {triangle1.Height}m heeft een oppervlakte van {triangle1.Area:F1}m²");
            Console.WriteLine($"Een driehoek met een basis van {triangle2.Base}m en een hoogte van {triangle2.Height}m heeft een oppervlakte van {triangle2.Area:F1}m²");
            Library.ConsoleMethods.Continue();
        }


    }
}
