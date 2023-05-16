using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle()
        {
            Radius = 1.0;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return "Circle[Radius = " + Radius + "]";
        }
    }
    
}
