using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
{
    internal abstract class Person
    {
        private uint id;
        public uint Id
        {
            get { return id; }
        }

        private static uint maxId = 1;

        private DateTime birthDay;

        public DateTime BirthDay
        {
            get { return birthDay; }
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int years = now.Year - this.birthDay.Year;
                if (now.Month < this.BirthDay.Month || now.Month == this.BirthDay.Month && now.Day == this.BirthDay.Day)
                {
                    years--;
                }
                return years;
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private static List<Person> allPersons = new List<Person>();
        public static ImmutableList<Person> AllPersons
        {
            get { return allPersons.ToImmutableList<Person>();  }
        }

        public Person(string name, DateTime birthDay)
        {
            this.id = maxId;
            maxId++;
            this.Name = name;
            this.birthDay = birthDay;
            allPersons.Add(this);
        }
        public abstract double DetermineWorkload();
        public abstract string GenerateNameCard();

    }
}
