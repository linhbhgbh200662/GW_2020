using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.name = "Linh";
            st.id = 1;
            st.Class = "GCH1002";
            Console.WriteLine("Name: " + st.name);
            Console.WriteLine("ID: " + st.id);
            Console.WriteLine("Class: " + st.Class);
            
        }
    }
}
