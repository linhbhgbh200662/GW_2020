using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInher
{
    internal class Point2D
    {
        public int X;
        public int Y;

        public Point2D() 
        {
            this.X = 0;  
            this.Y = 0;
        }

        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return "("+X+","+Y+")";
        }
    }
}
