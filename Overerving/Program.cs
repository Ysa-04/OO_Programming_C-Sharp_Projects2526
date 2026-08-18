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
                Console.WriteLine("\n\t   EXCERCISES:");
                Thread.Sleep(50);
                Console.WriteLine("\t   1- Post Office");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- Veterinarian");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- Orders-Bugfix");
                Thread.Sleep(50);
                Console.WriteLine("\t   4- Pizza");
                Thread.Sleep(50);
                Console.WriteLine("\t   5- Menu");
                Thread.Sleep(50);
                Console.WriteLine("\n\t   DEMO'S:");
                Thread.Sleep(50);
                Console.WriteLine("\t   6- Demo HashCode");
                Thread.Sleep(50);
                Console.WriteLine("\t   7- Demo Boek");
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
                        DemoVet();
                        break;
                    case 3:
                        Console.Clear();
                        //Orders
                        break;
                    case 4:
                        Console.Clear();
                        //Pizza
                        break;
                    case 5:
                        Console.Clear();
                        //Menu
                        break;
                    case 6:
                        Console.Clear();
                        DemoHashCode();
                        break;
                    case 7:
                        Console.Clear();
                        BoekDemo();
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

        public static void DemoVet()
        {
            var patients = new List<Animal>();
            var animal1 = new Dog();
            animal1.IndividualAllergies = new List<string> { "vis" };
            animal1.Chip = "ABC123";
            animal1.Gender = Genders.Female;
            animal1.Name = "Misty";
            patients.Add(animal1);
            var animal2 = new Parrot();
            animal2.Gender = Genders.Male;
            animal2.Name = "Coco";
            patients.Add(animal2);
            foreach (var animal in patients)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Gender);
                Console.WriteLine("allergieën:");
                foreach (var allergie in animal.Allergies)
                {
                    Console.WriteLine(allergie);
                }
                animal.ShowChip();
            }
            Library.ConsoleMethods.Continue();
        }

        public static void DemoHashCode()
        {
            // Maak een HashSet aan voor unieke producten
            HashSet<Product> inventaris = new HashSet<Product>();

            // Product 1: Een fles cola (gescand bij de kassa)
            Product p1 = new Product("5410013115123", "Coca-Cola 1L", 2.50m);

            // Product 2: Dezelfde fles cola, maar fysiek een ander object in het geheugen (misschien een andere prijs of omschrijving ingetypt, maar dezelfde barcode!)
            Product p2 = new Product("5410013115123", "Cola 1L", 2.60m);

            inventaris.Add(p1);
            inventaris.Add(p2); // Wordt GEWEIGERD!

            Console.WriteLine(inventaris.Count);
            // Uitvoer: 1
            Library.ConsoleMethods.Continue();
        }

        public static void BoekDemo()
        {
            // We maken twee boeken aan met exact hetzelfde ISBN (maar andere objecten in het geheugen)
            Boek boek1 = new Boek("978-90-245-6789-0", "De Hobbit", "J.R.R. Tolkien");
            Boek boek2 = new Boek("978-90-245-6789-0", "De Hobbit (Tweede druk)", "J.R.R. Tolkien");

            // ---------------------------------------------------------
            // 1. Test van ToString()
            // ---------------------------------------------------------
            Console.WriteLine(boek1);
            // Uitvoer: Boek: 'De Hobbit' van J.R.R. Tolkien (ISBN: 978-90-245-6789-0)


            // ---------------------------------------------------------
            // 2. Test van GetType()
            // ---------------------------------------------------------
            Console.WriteLine(boek1.GetType().Name);
            // Uitvoer: Boek


            // ---------------------------------------------------------
            // 3. Test van Equals() vs ==
            // ---------------------------------------------------------
            Console.WriteLine(boek1 == boek2);
            // Uitvoer: FALSE (Want het zijn fysiek twee verschillende objecten in het geheugen)

            Console.WriteLine(boek1.Equals(boek2));
            // Uitvoer: TRUE (Want onze Equals-methode kijkt naar het ISBN, en dat is hetzelfde!)


            // ---------------------------------------------------------
            // 4. Test van GetHashCode() in een HashSet (unieke lijst)
            // ---------------------------------------------------------
            HashSet<Boek> bibliotheekCollectie = new HashSet<Boek>();

            bibliotheekCollectie.Add(boek1);
            bibliotheekCollectie.Add(boek2); // Wordt geweigerd door dezelfde HashCode én Equals!

            Console.WriteLine($"Aantal unieke boeken in de collectie: {bibliotheekCollectie.Count}");
            // Uitvoer: Aantal unieke boeken in de collectie: 1
            Library.ConsoleMethods.Continue();
        }
       
    }
}
