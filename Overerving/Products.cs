using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    public class Product
    {
        public string Barcode { get; set; }
        public string Omschrijving { get; set; }
        public decimal Prijs { get; set; }

        public Product(string barcode, string omschrijving, decimal prijs)
        {
            Barcode = barcode;
            Omschrijving = omschrijving;
            Prijs = prijs;
        }

        // 1. Equals: Twee producten zijn gelijk als hun Barcode identiek is
        public override bool Equals(object o)
        {
            if (o is null || GetType() != o.GetType()) { return false; }

            Product anderProduct = (Product)o;
            return this.Barcode == anderProduct.Barcode;
        }

        // 2. GetHashCode: De vingerafdruk baseren op diezelfde Barcode
        public override int GetHashCode()
        {
            return this.Barcode.GetHashCode();
        }
    }
}
