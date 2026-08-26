using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
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

        private static List<CourseRegistration> allCourseRegistrations = new List<CourseRegistration>();
        public static ImmutableList<CourseRegistration> AllCourseRegistrations
        {
            get { return allCourseRegistrations.ToImmutableList(); }
        }

        private Student student;
        public Student Student
        {
            get { return student; }
        }

        public CourseRegistration(Student student, Course course, byte? result)
        {
            this.Course = course;
            this.Result = result;
            this.student = student;
            allCourseRegistrations.Add(this);
        }

    }
}
