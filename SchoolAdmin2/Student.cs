using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SchoolAdmin2
{
    internal class Student : Person
    {
        private List<CourseRegistration> courseRegistrations = new List<CourseRegistration>();
     
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
                return builder.ToImmutableList<Student>(); 
            }
        }


        private Dictionary<DateTime, string> studentFile = new Dictionary<DateTime, string>();
        public ImmutableDictionary<DateTime, string> StudentFile
        {
            get { return studentFile.ToImmutableDictionary<DateTime, string>(); }
        }

        public Student(string name, DateTime birthDay) :base(name, birthDay)
        {
            allStudents.Add(this);
        }

        public override string GenerateNameCard()
        {
            return $"{this.Name}\t(STUDENT)";
            
        }


        public override double DetermineWorkload()
        {
            byte total = 0;
            foreach (CourseRegistration course in courseRegistrations)
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
            CourseRegistration courseResult = new CourseRegistration(course,result);
            courseRegistrations.Add(courseResult);  
        }

        public double Average()
        {
            double totaal = 0;
            int counter = 0;
            foreach (CourseRegistration item in courseRegistrations)
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

        public void ShowOverview()
        {
            Console.WriteLine($"\nNaam: {this.Name}\t(STUDENT)");
            Console.WriteLine($"Leeftijd: {this.Age} jaar");
            Console.WriteLine($"Werkbelasting: {this.DetermineWorkload()} uren");
            Console.WriteLine($"\nCijferrapport:");
            foreach (CourseRegistration item in courseRegistrations)
            {
                Console.WriteLine($"{item.Course.Title}:\t{item.Result}");
            }
            Console.WriteLine($"Gemiddelde:\t{this.Average():F1}");

        }


    }
}
