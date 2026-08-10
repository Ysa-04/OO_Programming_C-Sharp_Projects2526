using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class InternationalRegisteredLetter : RegisteredLetter
    {
        public override byte Duration
        {
            get
            {
                return (byte)Math.Ceiling(Distance / 50);
            }
        }

        public override double Price
        {
            get
            {
                double calculatedPrice = (Distance / 100.0) * 20.0;
                return Math.Max(20.0, calculatedPrice);
            }
        }
    }
}
