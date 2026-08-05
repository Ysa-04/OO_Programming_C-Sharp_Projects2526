using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenEnObjecten
{
    internal class CombinationOf2Numbers
    {
        public int Number1;
        public int Number2;

        //construcrtor:
        public CombinationOf2Numbers(int Number1, int Number2)
        {
            this.Number1 = Number1;
            //deze klasse Number1 = Number1 da je meegeeft bij initialisatie
            this.Number2 = Number2;
        }

        public double Sum()
        {
            return Number1 + Number2;
        }
        public double Difference()
        {
            return Number1 - Number2;
        }
        public double Product()
        {
            return Number1 * Number2;
        }
        public double Quotient()
        {
            if (Number1 <= 0 || Number2 <= 0)
            {
                Console.WriteLine("FOUT!");
            }
            return Number1 / Number2;
        }
    }

}
