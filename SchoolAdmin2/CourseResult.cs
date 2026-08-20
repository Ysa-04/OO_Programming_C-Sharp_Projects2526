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

        private byte result;

        public byte Result
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

        public CourseResult(string name, byte result)
        {
            this.Name = name;
            this.Result = result;
        }

    }
}
