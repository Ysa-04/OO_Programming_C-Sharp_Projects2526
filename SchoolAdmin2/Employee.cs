using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace SchoolAdmin2
{
    internal abstract class Employee:Person
    {
		private byte seniority;

		public byte Seniority
		{
			get { return seniority; }
			set 
			{ 
				if (value > 50)
				{
					seniority = 50;
				}
				else
				{
                    seniority = value;
                }
			}
		}

		private Dictionary<string, byte> tasks = new Dictionary<string, byte>();
		public ImmutableDictionary<string,byte> Tasks
		{
			get
			{
				return tasks.ToImmutableDictionary<string, byte>();
			}
		}

		public static ImmutableList<Employee> AllEmployees
		{
			get 
			{
				var builder = ImmutableList.CreateBuilder<Employee>();
				foreach(Person pers in Person.AllPersons)
				{
					if(pers is Employee)
					{
						builder.Add((Employee)pers);
					}
				}
				return builder.ToImmutableList<Employee>();
			}
		}

		public Employee(string name, DateTime birthDay, Dictionary<string,byte> tasks) : base(name, birthDay)
		{
			if(tasks is not null)
			{
				foreach(var item in tasks)
				{
					this.tasks.Add(item.Key, item.Value);
				}
			}
			allEmployees.Add(this);
		}

		public abstract uint CalculateSalary();

	}
}
