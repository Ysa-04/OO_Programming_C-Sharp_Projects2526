using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExcercises
{
    internal abstract class Pizza
    {
        protected List<string> Ingredients;
        

        public Pizza(string[] extraToppings)
        {
            this.Ingredients = new List<string> { "deeg", "tomatensaus", "kaas" };
            foreach (var topping in extraToppings)
            {
                this.Ingredients.Add(topping);
            }
        }

        public abstract double UnitPrice
        {
            get;
        }

        public double Price
        {
            get
            {
                return this.UnitPrice + (this.Ingredients.Count * 0.5);
            }
        }

        public void ShowIngredients()
        {
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

    }
}
