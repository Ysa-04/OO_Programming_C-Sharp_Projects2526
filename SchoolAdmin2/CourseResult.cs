using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmin2
{
    internal class CourseResult
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int result;

        public int Result
        {
            get { return result; }
            set 
            { 
                if(value > 20)
                {
                    Console.WriteLine("Foutief cijfer!");
                }
                else
                {
                    result = value;
                }
            }
        }

    }
}
