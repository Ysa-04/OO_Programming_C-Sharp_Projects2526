using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class Veggie : Pizza
    {
        public override double UnitPrice
        {
            get
            {
                return 6;
            }
        }

        public Veggie(string[] extraToppings) : base(extraToppings)
        {
            Ingredients.Add("tofu");
            Ingredients.Add("spinazie");
            Ingredients.Remove("kaas");
        }
    }
}
