using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class Margherita : Pizza
    {
        public override double UnitPrice
        {
            get
            {
                return 5;
            }
        }

        public Margherita(string[] extraToppings) : base(extraToppings)
        {
            Ingredients.Add("mozerella");
        }
    }
}
