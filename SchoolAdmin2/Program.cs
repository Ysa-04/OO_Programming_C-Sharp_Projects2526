namespace SchoolAdmin2
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchoolAdminDemo();
        }
        public static void SchoolAdminDemo()
        {
            Console.WriteLine("Maak een keuze:");
            Console.WriteLine("1. DemonstreerStudenten uitvoeren");
            Console.WriteLine("2. DemonstreerCursussen uitvoeren");
            Console.WriteLine("3. Student uit csv inlezen");
            Console.WriteLine("4. DemonstreerStudieProgramma uitvoeren");
            Console.WriteLine("5. DemonstreerAdministratiefPersoneel uitvoeren");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DemoStudents();
                    break;
                case 2:
                    Console.WriteLine();
                    DemoCourses();
                    break;
                case 3:
                    Console.WriteLine();
                    ReadTextFormatStudent();
                    break;
                case 4:
                    Console.WriteLine();
                    StudyProgram.DemoStudyProgram();
                    break;
                case 5:
                    Console.WriteLine();
                    DemoAdministrativePersonnel();
                    break;
                default:
                    break;
            }

            

        }

        public static void DemoStudents()
        {
            Course programmeren = new Course("Programmeren");
            Course databanken = new Course("Databanken");
            Course communicaite = new Course("Communicatie");
            Course webtechnologie = new Course("Webtechnologie");

            Student said = new Student("Said Aziz", new DateTime(2000, 6, 1));
            said.RegisterCourseResult(programmeren, 15);
            said.RegisterCourseResult(webtechnologie,null);
            said.RegisterCourseResult(communicaite,12);

            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 1, 1));
            mieke.RegisterCourseResult(communicaite,13);
            mieke.RegisterCourseResult(programmeren, 16);
            mieke.RegisterCourseResult(databanken,14);

            said.ShowOverview();
            mieke.ShowOverview(); 
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
        }

        public static void ReadTextFormatStudent()
        {
            Console.WriteLine("Geef de tekstvoorstelling van 1 student in csv-formaat:");
            string csv = Console.ReadLine();
            string[] data = csv.Split(";");
            int day = Convert.ToInt32(data[1]);
            int month = Convert.ToInt32(data[2]);
            int year = Convert.ToInt32(data[3]);
            Student newStudent = new Student(data[0], new DateTime(year, month, day));
            for (int i = 4; i < data.Length; i += 2)
            {
                int subjectID = Convert.ToInt32(data[i]);
                Course subject = Course.SearchCourseById(subjectID);
                if (!(subject is null))
                {
                    byte result = Convert.ToByte(data[i + 1]);
                    newStudent.RegisterCourseResult(subject, result);
                }
            }
            newStudent.ShowOverview();
            // Bart Van Steen;04;03;1998;Boekhouden;14;Macro-economie;8;Frans, deel 2;18
         }

        public static void DemoAdministrativePersonnel()
        {
            var tasksAndre = new Dictionary<string, byte>();
            tasksAndre.Add("roostering", 10);
            tasksAndre.Add("correspondentie", 10);
            tasksAndre.Add("animatie", 10);
            AdministrativePersonnel andre = new AdministrativePersonnel("Andre Mosselmans", new DateTime(1988,02,4), tasksAndre);

            var tasksMilena = new Dictionary<string, byte>();
            tasksMilena.Add("roostering", 15);
            tasksMilena.Add("animatie", 4);
            tasksMilena.Add("mails", 11);
            tasksMilena.Add("kloosterinschrijvingen", 5);
            AdministrativePersonnel milena = new AdministrativePersonnel("Milena Van Looy", new DateTime(2005, 05, 11), tasksMilena);

            foreach (AdministrativePersonnel lid in AdministrativePersonnel.AllAdministrativePersonnel)
            {
                Console.WriteLine($"\n{lid.GenerateNameCard()}");
                Console.WriteLine($"Werkbelasting: {lid.DetermineWorkload()} uren");
                Console.WriteLine($"Salaris: {lid.CalculateSalary():F2} EUR");
            }
           
        }
    }
}
