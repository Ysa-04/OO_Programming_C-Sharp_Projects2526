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
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    DemoStudents();
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
            //said.RegisterForCourse("Programmeren");
            //said.RegisterForCourse("Databanken");

            Student mieke = new Student();
            mieke.Name = "Mieke Vermeulen";
            mieke.BirthDay = new DateTime(1998, 1, 1);
            mieke.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            //mieke.RegisterForCourse("Communicatie");

            Console.WriteLine(said.GenerateNamecard());
            Console.WriteLine(said.DetermineWorkload());
            Console.WriteLine(mieke.GenerateNamecard());
            Console.WriteLine(mieke.DetermineWorkload());
        }
    }
}
