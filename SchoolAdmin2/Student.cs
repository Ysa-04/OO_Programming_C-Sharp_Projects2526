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
        private List<CourseRegistration> courseRegistrations = new List<CourseRegistration>();
        public static uint StudentCounter = 1;

        public int Age
        {
            get 
            {
                DateTime now = DateTime.Now;
                int years = now.Year - this.BirthDay.Year;
                if (now.Month < this.BirthDay.Month || now.Month == this.BirthDay.Month && now.Day < this.BirthDay.Day)
                {
                    years--;
                }
                return years; 
            }
        }

        public Student(string name, DateTime birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            StudentNumber = StudentCounter;
            Student.StudentCounter++;
        }


        public byte DetermineWorkload()
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

        public void RegisterCourseResult(string course, byte? result)
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
            int total = 0;
            
            foreach (CourseRegistration item in courseRegistrations)
            {
                if(item.Result is not null)
                {
                    total += (byte)item.Result;
                }
                
            }
            return total / courseRegistrations.Count;
        }

        public void ShowOverview()
        {
            Console.WriteLine($"\nNaam: {this.Name}\t(STUDENT)");
            Console.WriteLine($"Leeftijd: {this.Age} jaar");
            Console.WriteLine($"Werkbelasting: {this.DetermineWorkload()} uren");
            Console.WriteLine($"\nCijferrapport:");
            foreach (CourseRegistration item in courseRegistrations)
            {
                Console.WriteLine($"{item.Name}:\t{item.Result}");
            }

        }


    }
}
