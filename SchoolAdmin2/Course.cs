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
        public int Id
        {
            get { return id; }
        }

        private static int maxId = 1;

        public static List<Course> allCourses = new List<Course>();

        public Course(string title, List<Student> students, byte creditPoints)
        {
            this.Title = title;
            this.Students = students;
            this.CreditPoints = creditPoints;
            this.id = Course.maxId;
            Course.maxId++;

            Course.allCourses.Add(this);
        }

        public Course(string title, List<Student> students) : this(title, students, 3)
        {

        }
        public Course(string title): this(title, new List<Student>())
        {

        }

        public void ShowOverview()
        {
            Console.WriteLine($"{this.Title} ({this.id})\t({this.CreditPoints} stp):");
            foreach (Student student in Students)
            {
                Console.WriteLine($"\t- {student.Name}");
            }
        }

    }
}
