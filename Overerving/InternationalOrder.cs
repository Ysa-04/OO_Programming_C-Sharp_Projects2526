using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class InternationalOrder : Order
    {
        public InternationalOrder(uint number, double unitPrice) : base(number, unitPrice)
        {

        }
        public override double TotalPrice
        {
            get
            {
                double price = this.UnitPrice * Number * 1.1;
                if (this.Number >= 100)
                {
                    price -= 1000;
                }
                return price;
            }
        }
    }
}
