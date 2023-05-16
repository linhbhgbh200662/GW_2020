using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInher
{
    internal class Rectangle : Shape //hcn
    {
        public virtual double Width { get; set; }
        public virtual double Length { get; set; }

        public Rectangle()
        {
            this.Width = 1.0;
            this.Length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color,filled)
        {
            this.Width = width;
            this.Length = length;
        }

        public double GetArea()
        {
            return Width * Length;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Length);
        }

        public override string ToString()
        {
            return "A Rectangle with width= " + Width + " , " + "length =" + Length + " which is a subclass of " + base.ToString();

        }
    }
}
