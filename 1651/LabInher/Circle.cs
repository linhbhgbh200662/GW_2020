using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInher
{
    internal class Circle : Shape 
    {
        public double Radius;

        public Circle()
        {
            this.Radius = 1.0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base()
        {
            this.Radius = radius;
            
        }

        public double GetArea()
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
