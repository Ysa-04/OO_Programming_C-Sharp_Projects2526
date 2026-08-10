using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class RegisteredLetter
    {
		private double distance;
		public double Distance
		{
			get { return distance; }
			set 
			{ 
				if (value > 0)
				{
                    distance = value;
                }
			}
		}

		public virtual byte Duration
		{
			get 
			{ 
				return (byte)Math.Ceiling(Distance / 100); 
			}
		}

		public virtual double Price
		{
			get 
			{ 
				if (Distance < 100)
				{
					return 15.0;
				}
				else
				{
                    double extra = Math.Ceiling((Distance - 100) / 100.0);
					return 15.0 + (extra * 10.0);
                }
				
			}
			
		}



	}
}
