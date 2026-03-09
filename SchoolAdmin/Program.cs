using System.Runtime.CompilerServices;
using Library;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   | School Admin Project  |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*");
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
                Console.WriteLine("\t   1- Demonstreer studenten uitvoeren");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- Demonstreer cursussen uitvoeren");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- Student uit tekstformaat inlezen");
                Thread.Sleep(50);
                Console.WriteLine("\t   4- DemonstreerStudieProgramma uitvoeren");
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
                        DemoStudents();
                        break;
                    case 2:
                        Console.Clear();
                        DemoCourses();
                        break;
                    case 3:
                        Console.Clear();
                        ReadTextFormatStudent();
                        break;
                    case 4:
                        Console.Clear();
                        StudyProgram.DemoStudyProgram();
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

        public static void DemoStudents()
        {
            // List<Student> studentList = new List<Student>();
            Course communicatie = new Course("Communicatie");
            Course programmeren = new Course("Programmeren");
            Course webtechnologie = new Course("Webtechnologie");
            Course databanken = new Course("Databanken");

            Student said = new Student("Said Aziz", new DateTime(2000, 6, 1));
            said.RegisterCourseResult(communicatie, 12);
            said.RegisterCourseResult(programmeren, null);
            said.RegisterCourseResult(webtechnologie, 13);
            said.ShowOverview();

            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 1, 1));
            mieke.RegisterCourseResult(communicatie, 13);
            mieke.RegisterCourseResult(programmeren, 16);
            mieke.RegisterCourseResult(databanken, 14);
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
            Student said = new Student("Said Aziz", new DateTime(2000, 6, 1));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 1, 1));
            List<Student> saidAndMieke = new List<Student>();
            saidAndMieke.Add(said);
            saidAndMieke.Add(mieke);

            Course communicatie = new Course("Communicatie", saidAndMieke, 6);
            Course programmeren = new Course("Programmeren", saidAndMieke);
            Course webtechnologie = new Course("Webtechnologie");
            Course databanken = new Course("Databanken");

            webtechnologie.Students.Add(said);
            databanken.Students.Add(mieke);

            said.RegisterCourseResult(communicatie, 12);
            said.RegisterCourseResult(programmeren, null);
            said.RegisterCourseResult(webtechnologie, 13);

            mieke.RegisterCourseResult(communicatie, 13);
            mieke.RegisterCourseResult(programmeren, 16);
            mieke.RegisterCourseResult(databanken, 14);

            communicatie.ShowOverview();
            programmeren.ShowOverview();
            webtechnologie.ShowOverview();
            databanken.ShowOverview();

            Library.ConsoleMethods.Continue();
        }

        public static void ReadTextFormatStudent()
        {
            Console.WriteLine("Geef de tekstvoorstelling van 1 student in csv-formaat:");
            
            string input = Console.ReadLine();
            // Bart Van Steen;04;03;1998;Boekhouden;14;Macro-economie;8;Frans, deel 2;18
            File.WriteAllText("students.csv", input);

            string[] info = input.Split(';');
            string name = info[0];
            DateTime birthDate = new DateTime(
                Convert.ToInt32(info[3]),
                Convert.ToInt32(info[2]),
                Convert.ToInt32(info[1])
            );

            Student newStudent = new Student(info[0], new DateTime());
            for (int i = 4; i < info.Length; i += 2)
            {
                int subjectID = Convert.ToInt32(info[i]);
                Course subject = Course.SearchCourseById(subjectID);
                if (!(subject is null))
                {
                    byte result = Convert.ToByte(info[i + 1]);
                    newStudent.RegisterCourseResult(subject, result);
                }
            }

            Console.WriteLine();
            newStudent.ShowOverview();
            
            Library.ConsoleMethods.Continue();
        }
    }
}
