using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
{
    internal class StudyProgram
    {
		private string name;

		public string Name
		{
			get { return name; }
		}

        private Dictionary<Course, byte> courses = new Dictionary<Course, byte>();
        public ImmutableDictionary<Course,byte> Courses
        {
            get
            {
                return courses.ToImmutableDictionary<Course, byte>();
            }
        }

		public StudyProgram(string name)
		{
			this.name = name;
		}

        public void ShowOverview()
        {
            Console.WriteLine($"Programma: {Name}\n");
            Console.WriteLine("Semester 1:");
            bool noCourses = true;
            foreach (var item in Courses)
            {
                if(item.Value == 1)
                {
                    item.Key.ShowOverview();
                    noCourses = false;
                }
            }
            if (noCourses)
            {
                Console.WriteLine($"Er zijn geen cursussen in semester 1.");
            }
            Console.WriteLine("Semester 2:");
            noCourses = true;
            foreach(var item in Courses)
            {
                if(item.Value == 2)
                {
                    item.Key.ShowOverview();
                    noCourses = false;
                }
            }
            if (noCourses)
            {
                Console.WriteLine($"Er zijn geen cursussen in semester 2.");
            }
        }
        public static void DemoStudyProgram()
        {
            /*Course communicatie = new Course("Communicatie");
            Course programmeren = new Course("Programmeren");
            Course databanken = new Course("Databanken");
            List<Course> courses = new List<Course>() { communicatie, programmeren, databanken };
            StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            programmerenProgram.Courses = courses;
            snbProgram.Courses = courses;
            programmerenProgram.ShowOverview();
            snbProgram.ShowOverview();

            Course communicatie = new Course("Communicatie");
            Course programmeren = new Course("Programmeren");
            Course databanken = new Course("Databanken");
            List<Course> courses = new List<Course>() { communicatie, programmeren, databanken };
            StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            programmerenProgram.Courses = courses;
            snbProgram.Courses = courses;
            //we willen hieronder Databanken schrappen uit het programma SNB
            snbProgram.Courses.Remove(databanken);
            programmerenProgram.ShowOverview();
            snbProgram.ShowOverview();*/

            Course communicatie = new Course("Communicatie");
            Course programmeren = new Course("Programmeren");
            Course databanken = new Course("Databanken");
            Course scripting = new Course("programmeren");

            var coursesProgrammeren = new Dictionary<Course, byte>
            {
                {communicatie, 1},{programmeren,1},{databanken,1}
            };
            var coursesSNB = new Dictionary<Course, byte>
            {
                {communicatie,2 },{scripting,1},{databanken,1}
            };

            StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            StudyProgram snbProgram = new StudyProgram("Systeem- en Netwerkbeheer");

            programmerenProgram.courses = coursesProgrammeren;
            snbProgram.courses = coursesSNB;
            snbProgram.courses.Remove(databanken);
            foreach(var item in snbProgram.Courses)
            {
                if (item.Key.Title.ToLower() == "programmeren")
                {
                    item.Key.Title = "Scripting";
                }
            }

            programmerenProgram.ShowOverview();
            snbProgram.ShowOverview();
        }

    }
}
