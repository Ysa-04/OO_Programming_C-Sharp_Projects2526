using Library;
using System.Diagnostics.Metrics;
namespace Overerving
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
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   |  H4. Overerving |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*");
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
                Console.WriteLine("\t   1- Post Office");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- ");
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
                        DemoPostOffice();
                        break;
                    case 2:
                        Console.Clear();
                        
                        break;
                    case 3:
                        Console.Clear();
                        
                        break;
                    case 4:
                        Console.Clear();
                        
                        break;
                    case 5:
                        Console.Clear();
                        
                        break;
                    case 6:
                        Console.Clear();
                       
                        break;
                    case 7:
                        Console.Clear();
                        
                        break;
                    case 8:
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

        public static void DemoPostOffice()
        {
            
                bool go = true;
                List<RegisteredLetter> letters = new List<RegisteredLetter>();

                while (go)
                {
                    Console.WriteLine("Wat voor brief wil je toevoegen?");
                    Console.WriteLine("1. Standaard\n2. Internationaal\n3. Hoge prioriteit\n4. Stop");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hoe ver moet deze brief gaan?");
                            double distance1 = Convert.ToDouble(Console.ReadLine());
                            RegisteredLetter newRegisteredLetter = new RegisteredLetter();
                            newRegisteredLetter.Distance = distance1;
                            letters.Add(newRegisteredLetter);
                            break;
                        case 2:
                            Console.WriteLine("Hoe ver moet deze brief gaan?");
                            double distance2 = Convert.ToDouble(Console.ReadLine());
                            InternationalRegisteredLetter newInternationalLetter = new InternationalRegisteredLetter();
                            newInternationalLetter.Distance = distance2;
                            letters.Add(newInternationalLetter);
                            break;
                        case 3:
                            Console.WriteLine("Hoe ver moet deze brief gaan?");
                            double distance3 = Convert.ToDouble(Console.ReadLine());
                            HighPriorityRegisteredLetter newHighPriority = new HighPriorityRegisteredLetter();
                            newHighPriority.Distance = distance3;
                            letters.Add(newHighPriority);
                            break;
                        case 4:
                            go = false;
                            break;
                        default:
                            Console.WriteLine("Ongeldige keuze.");
                            break;
                    }
                }

                for (int i = 0; i < letters.Count; i++)
                {
                    RegisteredLetter letter = letters[i];
                    Console.WriteLine($"Brief {i + 1}: {letter.Distance}km, reistijd {letter.Duration} dagen, kostprijs {letter.Price} euro");
                }

            Library.ConsoleMethods.Continue();
      
        }
    }
}
