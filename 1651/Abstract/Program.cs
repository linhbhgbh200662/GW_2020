using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTime PT = new PartTime('6');
            Console.WriteLine(PT.ToString());
            Console.WriteLine("Salary: " + PT.Salary());
        }
    }
}
