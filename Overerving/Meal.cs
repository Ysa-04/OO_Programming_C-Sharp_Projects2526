using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class Meal
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double price;
		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public Meal(string name, double price)
		{
			this.Name = name;
			this.Price = price;
		}

		public virtual void ShowMenu()
		{
            Console.WriteLine($"{this.Name}\t\t\t{this.Price}");
		}

	}
}
