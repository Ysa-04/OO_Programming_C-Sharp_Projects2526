using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmin2
{
    internal class CourseRegistration
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }

        private byte? result;

        public byte? Result
        {
            get { return result; }
            set 
            { 
                if(value is null || value > 20)
                {
                    Console.WriteLine("Ongeldig cijfer!");
                }
                else
                {
                    result = value;
                }
            }
        }

        public CourseRegistration(string name, byte? result)
        {
            this.Name = name;
            this.Result = result;
        }

    }
}
