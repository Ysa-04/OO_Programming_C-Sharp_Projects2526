using Library;
namespace ExceptionHandling
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
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   |  H5. Exception Handling |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*");
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
                Console.WriteLine("\t   1- DemonstreerFoutafhandelingWeekdagen ZonderException");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- DemonstreerFoutafhandelingWeekdagen MetException");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- DemonstreerFoutafhandelingOverflow ZonderException");
                Thread.Sleep(50);
                Console.WriteLine("\t   4- DemonstreerFoutafhandelingOverflow MetException");
                Thread.Sleep(50);
                Console.WriteLine("\t   5- DemonstreerKeuzeElement");
                Thread.Sleep(50);
                Console.WriteLine("\t   6- DemonstreerKeuzeElementExtraVoorzichtig");
                Thread.Sleep(50);
                Console.WriteLine("\t   7- Leeftijd Kat"); //
                Thread.Sleep(50);
                Console.WriteLine("\t   8- Leeftijd Katten");
                Thread.Sleep(50);
                Console.WriteLine("\t   9- File helper");
                Thread.Sleep(50);
                Console.WriteLine("\t   10- Leeftijd Kat Custom");
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
                        DemonstreerFoutafhandelingWeekdagenZonderException();
                        break;
                    case 2:
                        Console.Clear();
                        DemonstreerFoutafhandelingWeekdagenMetException();
                        break;
                    case 3:
                        Console.Clear();
                        DemonstreerFoutafhandelingOverflowZonderException();
                        break;
                    case 4:
                        Console.Clear();
                        DemonstreerFoutafhandelingOverflowMetException();
                        break;
                    case 5:
                        Console.Clear();
                        DemonstreerKeuzeElement();
                        break;
                    case 6:
                        Console.Clear();
                        DemonstreerKeuzeElementExtraVoorzichtig();
                        break;
                    case 7:
                        Console.Clear();
                        
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

        public static void DemonstreerFoutafhandelingWeekdagenZonderException()
        {

            string[] arr = new string[5];
            arr[0] = "Zondag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }

            Library.ConsoleMethods.Continue();
        }

        public static void DemonstreerFoutafhandelingWeekdagenMetException()
        {
            try
            {
                string[] arr = new string[5];
                arr[0] = "Vrijdag";
                arr[1] = "Maandag";
                arr[2] = "Dinsdag";
                arr[3] = "Woensdag";
                arr[4] = "Donderdag";

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Er is een fout opgetreden: {e.Message}");
            }
            Library.ConsoleMethods.Continue();
        }

        public static void DemonstreerFoutafhandelingOverflowZonderException()
        {
            int num1, num2;
            int resultaat;
            num1 = 30;
            num2 = 60;
            resultaat = Convert.ToInt32(num1 * num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);

            Library.ConsoleMethods.Continue();
        }

        public static void DemonstreerFoutafhandelingOverflowMetException()
        {
            try
            {
                int num1, num2;
                byte resultaat;
                num1 = 30;
                num2 = 60;
                resultaat = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);

            } 
            catch (OverflowException e)
            {
                Console.WriteLine($"Er is een fout opgetreden: {e.Message}");
            }
            Library.ConsoleMethods.Continue();

        }

        public static void DemonstreerKeuzeElement()
        {
            Random ranGen = new Random();
            int[] getallen = { ranGen.Next(1, 11), ranGen.Next(1, 11), ranGen.Next(1, 11) };
            do
            {
                Console.WriteLine("Geef de index van het getal dat je wil zien");
                try
                {
                    Console.WriteLine($"Het getal is {getallen[Convert.ToInt32(Console.ReadLine())]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Die index hebben we niet!");
                }
                Console.WriteLine("Wil je doorgaan?");
            } while (Console.ReadLine().Trim().ToLower() == "ja");
            Library.ConsoleMethods.Continue();
        }

        public static void DemonstreerKeuzeElementExtraVoorzichtig()
        {
            Random ranGen = new Random();
            int[] getallen = { ranGen.Next(1, 11), ranGen.Next(1, 11), ranGen.Next(1, 11) };
            do
            {
                Console.WriteLine("Geef de index van het getal dat je wil zien");
                try
                {
                    Console.WriteLine($"Het getal is {getallen[Convert.ToInt32(Console.ReadLine())]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Die index hebben we niet!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Daar kan ik geen getal van maken.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Dat getal is te groot om te verwerken.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Er is iets misgelopen, meer kan ik niet zeggen.");
                }
                Console.WriteLine("Wil je doorgaan?");
            } while (Console.ReadLine().Trim().ToLower() == "ja");
        }
    }
}
