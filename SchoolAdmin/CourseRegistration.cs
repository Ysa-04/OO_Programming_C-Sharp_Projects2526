using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CourseRegistration
    {
        private Course course;
        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
        private byte? result;
        public byte? Result
        {
            get
            {
                return result;
            }
            set
            {
                if (!(value is null) && !(value > 20))
                {
                    result = value;
                }
            }
        }

        public CourseRegistration(Course course, byte? result)
        {
            this.Course = course;
            this.Result = result;
        }
    }
}
