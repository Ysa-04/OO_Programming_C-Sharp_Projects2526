using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class HighPriorityRegisteredLetter : RegisteredLetter
    {
        public override byte Duration
        {
            get
            {
                return (byte)Math.Ceiling(Distance / 200);
            }
        }
        public override double Price
        {
            get
            {
                double calculatedPrice = (Distance / 100) * 30.0;
                return Math.Max(30.0, calculatedPrice);
            }
        }
    }
}
