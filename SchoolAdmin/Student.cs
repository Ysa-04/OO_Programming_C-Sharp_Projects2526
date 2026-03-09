using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Student
    {
        public string Name;
        public DateTime Birthdate;
        public uint StudentNumber;
        private List<CourseRegistration> courseRegistrations = new List<CourseRegistration>();
        public static uint StudentCounter = 1;
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int numberOfYears = now.Year - this.Birthdate.Year;
                if (now.Month < this.Birthdate.Month || now.Month == this.Birthdate.Month && now.Day < this.Birthdate.Day)
                {
                    numberOfYears--;
                }
                return numberOfYears;
            }
        }

        public Student(string name, DateTime birthDate)
        {
            this.Name = name;
            this.Birthdate = birthDate;
            this.StudentNumber = StudentCounter;
            Student.StudentCounter++;
        }
        public string GenerateNameCard()
        {
            return $"{this.Name} (STUDENT)";
        }

        public byte DetermineWorkload()
        {
            byte total = 0;
            foreach (CourseRegistration course in courseRegistrations)
            {
                if (course is not null)
                {
                    total += 10;
                }
            }
            return total;
        }

        public void RegisterCourseResult(Course course, byte? result)
        {
            if (result > 20)
            {
                Console.WriteLine("Ongeldig cijfer!");
            }
            else
            {
                CourseRegistration newCourseresult = new CourseRegistration(course, result);
                courseRegistrations.Add(newCourseresult);
            }
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
        public void ShowOverview()
        {
            Console.WriteLine($"{this.Name} ({Age} jaar)");
            Console.WriteLine($"Werkbelasting: {DetermineWorkload()} uren");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*-*-*-*-*-*-*");
            foreach (CourseRegistration item in courseRegistrations)
            {
                Console.WriteLine($"{item.Course.Title}:\t{item.Result}");
            }
            Console.WriteLine($"Gemiddelde:\t{this.Average():F1}\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine();
        }
    }
}
