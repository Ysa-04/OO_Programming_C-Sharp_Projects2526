using System;
using System.Collections.Generic;
using System.Text;

namespace KlassenEnObjecten
{
    internal class Rectangle
    {
        private double width = 1.0;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
                }
                else
                {
                    this.width = value;
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
        public double Area
        {
            get
            {
                return this.Height * this.Width;
            }
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Rectangle()
        {

        }

    }
}
