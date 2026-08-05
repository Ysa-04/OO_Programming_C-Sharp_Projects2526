using System;
using System.Collections.Generic;
using System.Text;

namespace Objecten
{
    internal class FoodPurchase
    {
        public bool Refridgerate;

		private string productName;
		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
		}

		private int number;
		public int Number
		{
			get { return number; }
			set 
			{ 
				if (value <= 0)
				{
                    Console.WriteLine("Ongeldig aantal!");
				}
				else
				{
                    number = value;
                }
			}
		}

		private double unitPrice;
		public double UnitPrice
		{
			get { return unitPrice; }
			set 
			{ 
				if (value <= 0 || value > 5000)
				{
                    Console.WriteLine("Ongeldige eenheidsprijs!");
				}
				else
				{
                    unitPrice = value;
                }
				
			}
		}

		//computed property:
		private DateTime expirationDate = new DateTime();
		public DateTime ExpirationDate
		{
			get { return expirationDate.AddMonths(2); }
		}

		public FoodPurchase(string productName, int number, double unitPrice, bool refridgerate)
		{
			this.ProductName = productName;
			this.Number = number;
			this.UnitPrice = unitPrice;
			this.Refridgerate = refridgerate;

			this.expirationDate = DateTime.Now;
		}


		public double CalculateTotalPrice()
		{
			return this.Number * this.UnitPrice;
            
        }
	}
}
