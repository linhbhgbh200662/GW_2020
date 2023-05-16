using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab3
{
    public class Rectangle : Shape
    {
        private int length = 0;
        private int width = 0;

        public Rectangle(int length, int width, string color) : base(color)
        {
            this.length = length;
            this.width = width;
        }

        public override double Getarea()
        {
             double getarea = length * width;
             return getarea;
        }
        public override string ToString()
        {
            return "Rectangle with length " + length + " and width " + width;
        }
    }
}