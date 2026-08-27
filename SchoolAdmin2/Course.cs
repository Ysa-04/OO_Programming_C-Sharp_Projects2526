using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
{
    internal class Course
    {
        public string Title;
        public ImmutableList<Student> Students
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<Student>();
                foreach(var registration in this.CourseRegistrations)
                {
                    builder.Add(registration.Student);
                }
                return builder.ToImmutable();
            }
        }

        public ImmutableList<CourseRegistration> CourseRegistrations
        {
            get
            {
                var builder = ImmutableList.CreateBuilder<CourseRegistration>();
                foreach(var registration in CourseRegistration.AllCourseRegistrations)
                {
                    if (registration.Course == this)
                    {
                        builder.Add(registration);
                    }
                }
                return builder.ToImmutable();
            }


        }

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
        private static List<Course> allCourses = new List<Course>();
        public static ImmutableList<Course> AllCourses
        {
            get { return allCourses.ToImmutableList<Course>(); }
        }

        public Course(string title, byte creditPoints)
        {
            this.Title = title;
            this.id = Course.maxId;
            Course.maxId++;
            this.CreditPoints = creditPoints;
            Course.AllCourses.Add(this);
        }
        public Course(string title) : this(title, 3)
        {
        }

        public static void AddCourse()
        {
            Console.Write("Titel van de cursus: ");
            string title = Console.ReadLine();
            Console.Write("Aantal studiepunten: ");
            byte creditPoints = Convert.ToByte(Console.ReadLine());
            new Course(title, creditPoints);
            Console.WriteLine("\nCursus succesvol aangemaakt.");
        }

        public void ShowOverview()
        {
            Console.WriteLine($"{this.Title} ({this.Id}) ({this.CreditPoints}stp)");
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}");
            }
            Console.WriteLine();
        }
        public static Course SearchCourseById(int id)
        {
            foreach (Course course in AllCourses)
            {
                if (id == course.Id)
                {
                    return course;
                }
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            if(obj is null)
            {
                return false;
            }
            else if(!(obj is Course))
            {
                return false;
            }
            else
            {
                return ((Course)obj).Id == this.Id;
            }
        }

        public override int GetHashCode()
        {
            return (int)this.Id;
        }
    }
}
