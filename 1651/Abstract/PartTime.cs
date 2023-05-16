using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class PartTime : Employee
    {
        private int WorkingHour = 0;
        

        public PartTime(int workingHour, string name) : base(name)
        {
            WorkingHour = workingHour;
        }

        public override int Salary()
        {
            int salary = WorkingHour * 15;
            return salary;
        }
        
        public override string ToString()
        {
            return "PartTime with workinghour " + WorkingHour;
        }
    }
}
