using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Fish : Animal, Pet
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Fish() : base(0)
        {
            
        }
        public Fish(string name) : base(0)
        {
            this.name = name;
        }
        public override void Eat()
        {
            Console.WriteLine("Fish" + " " + Name + " " + " is eating");
        }
        public void Play()
        {
            Console.WriteLine("Fish" + " " + Name + " " + " is playing");
        }
        public override void Walk()
        {
            Console.WriteLine("Fish" + " " + Name + " " + " is swimming");
        }
        public override string ToString()
        {
            return "Fish" + Name + " with " + Legs + " legs";
        }
    }
}