namespace SchoolAdmin
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
                Console.WriteLine("\t   KEUZEMENU");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   0- EXIT");
                Console.WriteLine("\t   1- Demonstreer studenten uitvoeren");
                Console.WriteLine("\t   2- Demonstreer cursussen uitvoeren");
                Console.WriteLine();
                Console.Write("\t   Maak je keuze: ");
                string input = Console.ReadLine();
                int choice = Library.InputMethods.IntCheck(input);

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
                        DemoStudents();
                        break;
                    case 2:
                        Console.Clear();
                        DemoCourses();
                        break;
                    default:
                        Library.Messages.ErrorMessage("Wrong input value");
                        break;
                }
            }

        }

        public static void DemoStudents()
        {
            // List<Student> studentList = new List<Student>();
            Student said = new Student();
            said.Name = "Said Aziz";
            said.Birthdate = new DateTime(2000, 6, 1);
            said.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            said.RegisterCourseResult("Communicatie", 12);
            said.RegisterCourseResult("Programmeren", 15);
            said.RegisterCourseResult("Webtechnologie", 13);
            said.ShowOverview();

            Student mieke = new Student();
            mieke.Name = "Mieke Vermeulen";
            mieke.Birthdate = new DateTime(1998, 1, 1);
            mieke.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            mieke.RegisterCourseResult("Communicatie", 13);
            mieke.RegisterCourseResult("Programmeren", 16);
            mieke.RegisterCourseResult("Databanken", 14);
            mieke.ShowOverview();

            Library.ConsoleMethods.Continue();

            //studentList.Add(said);
            //studentList.Add(mieke);

            /* foreach (var student in studentList)
            {
                Console.WriteLine();
                Console.WriteLine($"{student.GenerateNamecard()}\n{student.DetermineWorkload()}\n");
            } */
        }
        public static void DemoCourses()
        {
            Student said = new Student();
            said.Name = "Said Aziz";
            said.Birthdate = new DateTime(2000, 6, 1);
            said.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            said.RegisterCourseResult("Communicatie", 12);
            said.RegisterCourseResult("Programmeren", 15);
            said.RegisterCourseResult("Webtechnologie", 13);

            Student mieke = new Student();
            mieke.Name = "Mieke Vermeulen";
            mieke.Birthdate = new DateTime(1998, 1, 1);
            mieke.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            mieke.RegisterCourseResult("Communicatie", 13);
            mieke.RegisterCourseResult("Programmeren", 16);
            mieke.RegisterCourseResult("Databanken", 14);

            Course communicatie = new Course();
            communicatie.Title = "Communicatie";
            Course programmeren = new Course();
            programmeren.Title = "Programmeren";
            Course webtechnologie = new Course();
            webtechnologie.Title = "Webtechnologie";
            Course databanken = new Course();
            databanken.Title = "Databanken";

            communicatie.Students.Add(said);
            communicatie.Students.Add(mieke);
            programmeren.Students.Add(said);
            programmeren.Students.Add(mieke);
            webtechnologie.Students.Add(said);
            databanken.Students.Add(mieke);

            communicatie.ShowOverview();
            programmeren.ShowOverview();
            webtechnologie.ShowOverview();
            databanken.ShowOverview();

            Library.ConsoleMethods.Continue();
        }
    }
}
