using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession03
{
    internal class Ex02
    {
        public Ex02() 
        {
            /*
               1. Write a function to swap two elements of array at position i & j
               
            */

            int[] arr = { -2, 6, 100, 7, 9, 500, 20, 9 };
            int i = 2;
            int j = 5;

            //Process: swap two elements at position i & j
            swap(arr, i, j);
            swap(arr, 0, 7);  //swap two elements (-2) & 9

            //Output
            foreach(var x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("i = " + i);        // 2
            Console.WriteLine("arr = " + arr[7]); // 201
        }

        private void swap(int[] x, int i, int j)
        {
            int temp = x[i];
            x[i] = x[j];
            x[j] = temp;

            i = 201;
            x[7] = 201;
        }
    }
}
