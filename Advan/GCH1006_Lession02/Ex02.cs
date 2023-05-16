using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession02
{
    internal class Ex02
    {
        public Ex02() 
        {
            int[] arr = new int[10];
            List<int> aList = new List<int>();
            aList.Add(15);
            aList.Add(9);
            aList.Add(10);

            Console.WriteLine(aList.Count);  //3
            Console.WriteLine(aList[0]); // 15

            aList.Insert(1, 100);
            Console.WriteLine(string.Join(" ", aList));

            aList.RemoveAt(9);
            Console.WriteLine(string.Join(" ", aList));
        }
    }
}
