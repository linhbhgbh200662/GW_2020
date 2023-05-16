using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class MovablePoint
    {
        private int x = 0;
        //public int X 
        //{
         //   get { return x; }
         //   set { x = value; }

       // }

        private int y = 0;

        //public int Y 
        //{
         //   get { return y; }
         //   set { y = value; }

        //}

        public MovablePoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveUP()
        {
            y++;
        }
        public void MoveDOWN()
        {
            y--;
        }
        public void MoveLEFT()
        {
            x--;
        }
        public void MoveRIGHT()
        {
            x++;
        }
        public override string ToString()
        {
            return "MovablePoint with x = " + x + " and y = " + y;
        }
    }
}