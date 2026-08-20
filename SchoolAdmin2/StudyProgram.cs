using System;
using System.Collections.Generic;
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

		public List<Course> Courses = new List<Course>();

		public StudyProgram(string name)
		{
			this.name = name;
		}

        public void ShowOverview()
        {
            Console.WriteLine($"Programma: {Name}\n");
            foreach (Course course in Courses)
            {
                course.ShowOverview();
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
            //nieuwe cursus
            Course scripting = new Course("programmeren");
            List<Course> coursesProgrammeren = new List<Course>() { communicatie, programmeren, databanken };
            //aanpassing met scripting
            List<Course> coursesSNB = new List<Course>() { communicatie, scripting, databanken };
            StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            programmerenProgram.Courses = coursesProgrammeren;
            snbProgram.Courses = coursesSNB;
            snbProgram.Courses.Remove(databanken);
            snbProgram.Courses[1].Title = "Scripting";
            programmerenProgram.ShowOverview();
            snbProgram.ShowOverview();
        }

    }
}
