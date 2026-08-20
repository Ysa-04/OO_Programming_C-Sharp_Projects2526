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
                    Console.WriteLine();
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
            Student said = new Student();
            said.Name = "Said Aziz";
            said.BirthDay = new DateTime(2000, 6, 1);
            said.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            said.RegisterForCourse("Programmeren");
            said.RegisterForCourse("Webtechnologie");
            said.RegisterForCourse("Communicatie");

            Student mieke = new Student();
            mieke.Name = "Mieke Vermeulen";
            mieke.BirthDay = new DateTime(1998, 1, 1);
            mieke.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            mieke.RegisterForCourse("Communicatie");
            mieke.RegisterForCourse("Programmeren");
            mieke.RegisterForCourse("Databanken");

            Console.WriteLine(said.GenerateNamecard());
            Console.WriteLine(said.DetermineWorkload());
            Console.WriteLine(mieke.GenerateNamecard());
            Console.WriteLine(mieke.DetermineWorkload());
        }

        public static void DemoCourses()
        {
            Student said = new Student();
            said.Name = "Said Aziz";
            said.BirthDay = new DateTime(2000, 6, 1);
            said.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            said.RegisterForCourse("Programmeren");
            said.RegisterForCourse("Webtechnologie");
            said.RegisterForCourse("Communicatie");

            Student mieke = new Student();
            mieke.Name = "Mieke Vermeulen";
            mieke.BirthDay = new DateTime(1998, 1, 1);
            mieke.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            mieke.RegisterForCourse("Communicatie");
            mieke.RegisterForCourse("Programmeren");
            mieke.RegisterForCourse("Databanken");

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
