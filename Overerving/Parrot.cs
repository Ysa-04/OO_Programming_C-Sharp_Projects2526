using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Overerving
{
    internal class Parrot : Animal
    {
        private List<string> allergies = new List<string>();
        public override ImmutableList<string> Allergies
        {
            get
            {
                return allergies.ToImmutableList<string>();
            }
        }

        public override void ShowChip()
        {
            Console.WriteLine("Papegaaien worden niet gechipt.");
        }
    }
}
