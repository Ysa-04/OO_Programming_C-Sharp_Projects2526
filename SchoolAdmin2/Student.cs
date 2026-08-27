using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SchoolAdmin2
{
    internal class Student : Person
    {
        public ImmutableList<CourseRegistration> CourseRegistrations
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<CourseRegistration>();
                foreach(var registration in CourseRegistration.AllCourseRegistrations)
                {
                    if(this == registration.Student)
                    {
                        builder.Add(registration);
                    }
                }
                return builder.ToImmutable();
            }
        }

        public ImmutableList<Course> Courses
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<Course>();
                foreach(var registration in this.CourseRegistrations)
                {
                    builder.Add(registration.Course);
                }
                return builder.ToImmutable();
            }
        }
     
        public static ImmutableList<Student> AllStudents
        {
            get 
            {
                var builder = ImmutableList.CreateBuilder<Student>();
                foreach (Person pers in AllPersons)
                {
                    if(pers is Student)
                    {
                        builder.Add((Student)pers);
                    }
                }
                return builder.ToImmutable(); 
            }
        }


        private Dictionary<DateTime, string> studentFile = new Dictionary<DateTime, string>();
        public ImmutableDictionary<DateTime, string> StudentFile
        {
            get { return studentFile.ToImmutableDictionary<DateTime, string>(); }
        }

        public Student(string name, DateTime birthDay) :base(name, birthDay)
        {
           
        }

        public override string GenerateNameCard()
        {
            return $"{this.Name}\t(STUDENT)";
            
        }


        public override double DetermineWorkload()
        {
            byte total = 0;
            foreach (CourseRegistration course in CourseRegistrations)
            {
                if(course is not null)
                {
                    total += 10; total += 10;
                }
            }
            return total;
        }

        public void RegisterCourseResult(Course course, byte? result)
        {
            if(result > 20)
            {
                Console.WriteLine("Ongeldig cijfer!");
            }
            else
            {
                new CourseRegistration(this, course, result);
            }
            
        }

        public double Average()
        {
            double totaal = 0;
            int counter = 0;
            foreach (CourseRegistration item in CourseRegistrations)
            {
                if (!(item.Result is null))
                {
                    totaal += (byte)item.Result;
                    counter++;
                }
            }
            return totaal / counter;
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudent";
        }

        public static void AddStudent()
        {
            Console.Write("Naam van de student: ");
            string name = Console.ReadLine();
            Console.Write("Geboortedatum (yyyy/mm/dd): ");
            DateTime birthDay = Convert.ToDateTime(Console.ReadLine());
            new Student(name, birthDay);
            Console.WriteLine("\nStudent succesvol aangemaakt.");
        }

        public void ShowOverview()
        {
            Console.WriteLine($"\nNaam: {this.Name}\t(STUDENT)");
            Console.WriteLine($"Leeftijd: {this.Age} jaar");
            Console.WriteLine($"Werkbelasting: {this.DetermineWorkload()} uren");
            Console.WriteLine($"\nCijferrapport:");
            foreach (CourseRegistration item in CourseRegistrations)
            {
                Console.WriteLine($"{item.Course.Title}:\t{item.Result}");
            }
            Console.WriteLine($"Gemiddelde:\t{this.Average():F1}");

        }

        

    }
}
