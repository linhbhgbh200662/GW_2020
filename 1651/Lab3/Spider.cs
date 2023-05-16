using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab3
{
    public class Spider : Animal
    {
        public Spider() : base(8)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Spider is eating");
        }
        public override string ToString()
        {
            return "Spider " + " with " + Legs + " legs";
        }
    }
}