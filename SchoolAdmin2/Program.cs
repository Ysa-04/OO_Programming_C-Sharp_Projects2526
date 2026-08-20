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
            Console.WriteLine("3. Student uit csv inlezen");
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
            said.RegisterCourseResult("Webtechnologie", null);
            said.RegisterCourseResult("Communicatie", 12);

            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 1, 1));
            mieke.RegisterCourseResult("Communicatie", 13);
            mieke.RegisterCourseResult("Programmeren", 16);
            mieke.RegisterCourseResult("Databanken", 14);

            List<Student> miekeAndSaid = new List<Student>();
            miekeAndSaid.Add(mieke);
            miekeAndSaid.Add(said);

            Course communicatie = new Course("Communicatie", miekeAndSaid, 6);
            Course programmeren = new Course("Programmeren", miekeAndSaid);
            Course webtechnologie = new Course("Webtechnologie");
            Course databanken = new Course("Databanken");

            webtechnologie.Students.Add(said);
            databanken.Students.Add(mieke);

            programmeren.ShowOverview();
            databanken.ShowOverview();
            communicatie.ShowOverview();
            webtechnologie.ShowOverview();
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
            for (int i = 4; i < data.Length; i+=2)
            {
                string course = data[i];
                byte result = Convert.ToByte(data[i + 1]);
                newStudent.RegisterCourseResult(course, result);
            }
            newStudent.ShowOverview();
            // Bart Van Steen;04;03;1998;Boekhouden;14;Macro-economie;8;Frans, deel 2;18
        }



    }
}
