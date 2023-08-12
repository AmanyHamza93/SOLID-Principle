using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincple.OCP
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) 
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Radius * Radius * 3.14;
        }
    }
}
