using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
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
        public static List<Course> AllCourses = new List<Course>();

        public Course(string title, List<Student> students, byte creditPoints)
        {
            this.Title = title;
            this.Students = students;
            this.id = Course.maxId;
            Course.maxId++;
            this.CreditPoints = creditPoints;
            Course.AllCourses.Add(this);
        }
        public Course(string title, List<Student> students) : this(title, students, 3)
        {
        }
        public Course(string title) : this(title, new List<Student>())
        {
        }

        public void ShowOverview()
        {
            Console.WriteLine($"{this.Title} ({this.Id}) - {this.CreditPoints}sp");
            Console.WriteLine("*-*-*-*-*-*-*-*");
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}");
            }
            Console.WriteLine();
        }
    }
}
