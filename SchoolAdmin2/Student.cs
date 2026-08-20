using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmin2
{
    internal class Student
    {
        public string Name;
        public DateTime BirthDay;
        public uint StudentNumber;
        private List<CourseResult> courseResults = new List<CourseResult>();
        public static uint StudentCounter = 1;

        public byte DetermineWorkload()
        {
            byte total = 0;
            foreach (CourseResult course in courseResults)
            {
                if(course is not null)
                {
                    total += 10; total += 10;
                }
            }
            return total;
        }

        public void RegisterCourseResult(string course, byte result)
        {
            if(result > 20)
            {
                Console.WriteLine("Ongeldig cijfer!");
            }
            CourseResult courseResult = new CourseResult();
            courseResult.Name = course;
            courseResult.Result = result;

            courseResults.Add(courseResult);  
        }

        public double Average()
        {
            int total = 0;
            
            foreach (CourseResult result in courseResults)
            {
                total += result.Result;
            }
            return total / courseResults.Count;
        }

        public void ShowOverview()
        {
            Console.WriteLine($"\nNaam: {this.Name}\t(STUDENT)");
            Console.WriteLine($"Werkbelasting: {this.DetermineWorkload()}");
            Console.WriteLine($"\nCijferrapport:");
            foreach (CourseResult item in courseResults)
            {
                Console.WriteLine($"{item.Name}:\t{item.Result}");
            }

        }


    }
}
