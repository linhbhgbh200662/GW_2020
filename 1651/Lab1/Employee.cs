using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Employee
    {
        public int ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Salary { get; set; }

        public Employee(int id, string firstName, string lastName, int salary)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public int AnnuallSalary()
        {
            return Salary * 12;
        }
        public override string ToString()
        {
            return "Employee[id=" + ID + ", name=" + FullName() + ", salary=" + Salary + "]";
        }
    }
}

