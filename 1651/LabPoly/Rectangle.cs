using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoly
{
    internal class Rectangle : Shape
    {
        private int lenght;
        private int width;

        public virtual int Length
        {
            get { return this.lenght; } 
            set { this.lenght = value; }
        }

        public virtual int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Rectangle()
        {
            this.Width = 1;
            this.Length = 1;
        }
        public Rectangle(string color, int lenght, int width) : base(color)
        {
            this.Width = width;
            this.Length = lenght;
        }
        public override double GetArea()
        {
            return Width * Length;
        }
        public override string ToString()
        {
            return "Rectangle[length=" + Length + ",width=" + Width + ",color=" + Color + "]";
        }
    }
}

