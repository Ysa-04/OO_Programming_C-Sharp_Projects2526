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

		private static List<Employee> allEmployees = new List<Employee>();
		public static ImmutableList<Employee> AllEmployees
		{
			get { return allEmployees.ToImmutableList<Employee>(); }
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
