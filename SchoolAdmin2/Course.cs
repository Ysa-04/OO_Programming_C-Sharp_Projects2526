using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmin2
{
    internal class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();

        public void ShowOverview()
        {
            Console.WriteLine($"{this.Title}:");
            foreach (Student student in Students)
            {
                Console.WriteLine($"\t- {student.Name}");
            }
        }

    }
}
