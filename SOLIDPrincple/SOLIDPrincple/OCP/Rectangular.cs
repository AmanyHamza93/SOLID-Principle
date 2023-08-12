using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincple.OCP
{
    internal class Rectangular:Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangular(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double Area()
        {
           return Height * Width;
        }
    }
}
