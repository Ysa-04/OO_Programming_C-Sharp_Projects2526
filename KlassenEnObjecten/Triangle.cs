using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenEnObjecten
{
    internal class Triangle
    {
        private double @base = 1.0;
        public double Base
        {
            get
            {
                return @base;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
                }
                else
                {
                    this.@base = value;
                }
                
            }
        }

        private double height = 1.0;
        public double Height
        {
            get 
            { 
                return height; 
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
                }
                else
                {
                    this.height = value;
                }
               
            }
        }
        //geen private, want je moet toch niks aanpassen.
        public double Area
        {
            get
            {
                return this.Height * this.Base;
            }
        }

    }
}
