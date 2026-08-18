using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class Order
    {
        private uint number;
        public uint Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        protected double UnitPrice;
        public virtual double TotalPrice
        {
            get
            {
                return Number * UnitPrice;
            }
        }

        public Order(uint number, double unitPrice)
        {
            this.Number = number;
            this.UnitPrice = unitPrice;
        }
    }
}
