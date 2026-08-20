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
        public List<string> Courses = new List<string>();
        public static uint StudentCounter = 1;

        
        public string GenerateNamecard()
        {
            return $"{this.Name}\t(STUDENT)";
        }
        public byte DetermineWorkload()
        {
            byte total = 0;
            foreach (string course in Courses)
            {
                total += 10;
            }
            return total;
        }



    }
}
