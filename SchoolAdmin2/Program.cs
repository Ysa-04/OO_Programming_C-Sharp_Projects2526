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
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("1. DemonstreerStudenten uitvoeren");
            Console.WriteLine("2. DemonstreerCursussen uitvoeren");
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
                default:
                    break;
            }

            

        }

        public static void DemoStudents()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 6, 1));
            said.RegisterCourseResult("Programmeren", 15);
            said.RegisterCourseResult("Webtechnologie",13);
            said.RegisterCourseResult("Communicatie",12);

            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 1, 1));
            mieke.RegisterCourseResult("Communicatie",13);
            mieke.RegisterCourseResult("Programmeren", 16);
            mieke.RegisterCourseResult("Databanken",14);

            said.ShowOverview();
            mieke.ShowOverview(); 
        }

        
        public static void DemoCourses()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 6, 1));
            said.RegisterCourseResult("Programmeren", 15);
            said.RegisterCourseResult("Webtechnologie", 13);
            said.RegisterCourseResult("Communicatie", 12);

            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 1, 1));
            mieke.RegisterCourseResult("Communicatie", 13);
            mieke.RegisterCourseResult("Programmeren", 16);
            mieke.RegisterCourseResult("Databanken", 14);

            Course programmeren = new Course();
            programmeren.Title = "Programmeren";
            programmeren.Students.Add(said);
            programmeren.Students.Add(mieke);

            Course databanken = new Course();
            databanken.Title = "Databanken";
            databanken.Students.Add(mieke);

            Course communicatie = new Course();
            communicatie.Title = "Communicatie";
            communicatie.Students.Add(said);
            communicatie.Students.Add(mieke);

            Course webtechnologie = new Course();
            webtechnologie.Title = "Webtechnologie";
            webtechnologie.Students.Add(said);

            programmeren.ShowOverview();
            databanken.ShowOverview();
            communicatie.ShowOverview();
            webtechnologie.ShowOverview();
        }

        

    }
}
