using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cat : Animal, Pet
    {
         public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Cat() : base(4)
        {
            
        }

        public Cat(string name) : base(4)
        {
            this.name = name;
        }
        public override void Eat()
        {
            Console.WriteLine("Cat" +" "+ Name +" "+ "is eating");
        }
        public void Play()
        {
            Console.WriteLine("Cat"+" "+ Name +" "+ "is playing");
        }
        public override string ToString()
        {
            return "Cat" + " " + Name + " with " + Legs + " legs";
        }
    }
}