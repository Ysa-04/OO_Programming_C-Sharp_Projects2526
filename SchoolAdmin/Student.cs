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
        public int StudentNumber;
        private List<CourseResult> courseResults = new List<CourseResult>();
        public static int StudentCounter = 1;
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

        public string GenerateNamecard()
        {
            return $"{this.Name} (STUDENT)";
        }

        public int DetermineWorkload()
        {
            int workload = 0;
            foreach (CourseResult course in courseResults)
            {
                workload += 10;
            }
            return workload;
        }

        public void RegisterCourseResult(string course, byte result)
        {
            if (result > 20)
            {
                Console.WriteLine("Ongeldig cijfer!");
            }
            else
            {
                CourseResult newCourseresult = new CourseResult();
                newCourseresult.Name = course;
                newCourseresult.Result = result;
                courseResults.Add(newCourseresult);
            }
        }
        public double Average()
        {
            double totaal = 0;
            foreach (CourseResult item in courseResults)
            {
                totaal += item.Result;
            }
            return totaal / courseResults.Count;
        }
        public void ShowOverview()
        {
            Console.WriteLine($"{this.Name} ({Age} jaar)");
            Console.WriteLine($"Werkbelasting: {DetermineWorkload()} uren");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*-*-*-*-*-*-*");
            foreach (CourseResult item in courseResults)
            {
                Console.WriteLine($"{item.Name}:\t{item.Result}");
            }
            Console.WriteLine($"Gemiddelde:\t{this.Average():F1}\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine();
        }
    }
}
