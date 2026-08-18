using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;

namespace Overerving
{
    internal class Dog : Animal
    {
        private string chip;
        public string Chip
        {
            get { return chip; }
            set { chip = value; }
        }
        private List<string> individualAllergies = new List<string>();
        public List<string> IndividualAllergies
        {
            get { return individualAllergies; }
            set { individualAllergies = value; }
        }

        private List<string> allergies = new List<string>();
        public override ImmutableList<string> Allergies
        {
            get
            {
                foreach (string allergy in IndividualAllergies)
                {
                    allergies.Add(allergy);
                }
                allergies.Add("druiven");
                allergies.Add("noten");
                allergies.Add("chocolade");
                allergies.Add("avocado");

                return allergies.ToImmutableList<string>();
            }
        }
        public override void ShowChip()
        {
            Console.WriteLine($"De chip is: {Chip}");
        }
    }
}
