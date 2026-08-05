using KlassenEnObjecten;
using Library;
using System.ComponentModel.Design;

namespace Objecten
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
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   |  H2. Objecten (al dan niet) aanmaken  |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
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
                Console.WriteLine("\t   1- FiguresWithConstructor");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- FoodPurchase");
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
                        FiguresWithConstructor();
                        break;
                    case 2:
                        Console.Clear();
                        DemoPurchase();
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

        public static void FiguresWithConstructor()
        {
            Rectangle rectangle1 = new Rectangle(-1, 0);
            Rectangle rectangle2 = new Rectangle(2.2, 1.5);
            Triangle triangle1 = new Triangle(3, 1);
            Triangle triangle2 = new Triangle(2, 2);
            Library.ConsoleMethods.Continue();
        }

        public static void DemoPurchase()
        {
            FoodPurchase kaas = new FoodPurchase("KAAS", 2, 2.45,true);
            Console.WriteLine($"De totaalprijs van {kaas.ProductName} is {kaas.CalculateTotalPrice()}");
            Console.WriteLine($"De vervaldatum van aankoop 1 is {kaas.ExpirationDate.ToString("f")}");
            FoodPurchase boter = new FoodPurchase("BOTER", 0, 5555, true);
            Console.WriteLine($"De vervaldatum van aankoop 2 is {boter.ExpirationDate.ToString("f")}");

            Library.ConsoleMethods.Continue();
        }
    }
}
