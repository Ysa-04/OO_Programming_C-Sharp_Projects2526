using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SchoolAdmin2
{
    internal class CourseRegistration
    {
        private Course course;
        public Course Course
        {
            get { return course; }
            private set 
            { 
                if(value is null)
                {
                    throw new ArgumentException("Cursus mag niet ontbreken");
                }
                course = value; 
            }
        }
        private byte? result;
        public byte? Result
        {
            get
            {
                return result;
            }
            set
            {
                if (!(value is null) && !(value > 20))
                {
                    result = value;
                }
            }
        }

        private static List<CourseRegistration> allCourseRegistrations = new List<CourseRegistration>();
        public static ImmutableList<CourseRegistration> AllCourseRegistrations
        {
            get { return allCourseRegistrations.ToImmutableList(); }
        }

        private Student student;
        public Student Student
        {
            get { return student; }
            private set
            {
                if(value is null)
                {
                    throw new ArgumentException("Student mag niet ontbreken");
                }
                student = value;
            }
        }

        public CourseRegistration(Student student, Course course, byte? result)
        {
            this.Course = course;
            this.Result = result;
            this.student = student;
            allCourseRegistrations.Add(this);
        }

        public static void AddCourseRegistration()
        {
            if(Student.AllStudents.Count < 1 || Course.AllCourses.Count < 1)
            {
                Console.WriteLine("Er moet minstens 1 student en minstens 1 cursus in het systeem zitten.");
            }
            else
            {
                Console.WriteLine("Welke student?");
                for (int i = 0; i < Student.AllStudents.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {Student.AllStudents[i].Name}");
                }
                Student student = Student.AllStudents[Convert.ToInt32(Console.ReadLine()) - 1];
                Console.WriteLine("Welke cursus?");
                for (int i = 0; i < Course.AllCourses.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {Course.AllCourses[i].Title}");
                }
                Course course = Course.AllCourses[Convert.ToInt32(Console.ReadLine()) - 1];
                byte? result = null;
                Console.Write("Wil je een resultaat toekennen? (ja/nee): ");
                string answer = Console.ReadLine();
                if (answer.ToLower().Trim() == "ja")
                {
                    Console.Write("Geef het resultaat in: ");
                    result = Convert.ToByte(Console.ReadLine());
                }
                try
                {
                    new CourseRegistration(student, course, result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Vakinschrijving succesvol togevoegd.");
            }
        }
        public static void ShowCourseRegistrations()
        {
            foreach (var item in CourseRegistration.AllCourseRegistrations)
            {
                Console.WriteLine($"{item.Student.Name} ingeschreven voor {item.Course.Title}");
            }
        }
    }
}
