using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
{
    internal class Lecturer : Employee
    {
        public Dictionary<Course, double> Courses = new Dictionary<Course, double>();
        private static List<Lecturer> allLecturers = new List<Lecturer>();
        public static ImmutableList<Lecturer> AllLecturers
        {
            get { return allLecturers.ToImmutableList<Lecturer>(); }
        }

        public Lecturer(string name, DateTime birthDay, Dictionary<string,byte> tasks) : base(name, birthDay, tasks)
        {
            allLecturers.Add(this);
        }

        public override double DetermineWorkload()
        {
            double total = 0;
            foreach (var item in Courses)
            {
                total += item.Value;
            }
            return total;
        }

        public override uint CalculateSalary()
        {
            double basic = 2200 + (Seniority/4 * 120);
            double breuk = this.DetermineWorkload() / 40;
            return (uint)(basic * breuk);

        }

        public override string GenerateNameCard()
        {
            string info = $"{this.Name}\t(LECTOR)\nLector voor:";
            foreach (Course course in Courses.Keys)
            {
                info += $"\n\t- {course.Title}";
            }
            return info;
        }
        public override string ToString()
        {
            return base.ToString() + "\nLector";
        }
    }
}
