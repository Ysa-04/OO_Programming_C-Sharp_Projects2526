using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmin2
{
    internal class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();
        private byte creditPoints;

        public byte CreditPoints
        {
            get { return creditPoints; }
            private set { creditPoints = value; }
        }

        private int id;

        public int ID
        {
            get { return maxId; }
        }

        private static int maxId = 1;

        public static List<Course> allCourses = new List<Course>();

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
