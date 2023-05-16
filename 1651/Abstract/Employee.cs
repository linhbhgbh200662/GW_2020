using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Employee
    {
        private string Name;

        public void getName(string name)
        { this.Name = name; }

        public string getName()
        { return Name; }

        public Employee(string name) 
        {
            this.Name = name;
        }

        public abstract int Salary();

        public override string ToString()
        {
            return "Employee name " + Name;
        }
    }
}
