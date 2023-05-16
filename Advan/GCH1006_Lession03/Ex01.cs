using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession03
{
    internal class Ex01
    {
        /*
             Objective: Re-use the code in different context
             Scope: (1) Re-use the code within a class
         */
        public Ex01()   // contructor: hàm k trả về
        {
            //Review function/method/operation

            int[] arr = { 6, -2, 9, 10, 2, 6, -2, 9, 10 };

            int max = findMax(arr);  /// goi ham (call the function findMax())
                // pass agruments for the parameter(s) of findMax()

            Console.WriteLine("Maximum value of arr is: " + max);

            int[] brr = { 11, 2, 5, 7, 4, 3, 2, -2 };
            max= findMax(brr);
            Console.WriteLine("Maximum value of brr is: " + max);
        }

        //printAll(brr);
        //int result = printAll(brr)

        //if(login("Linh"))
        /*
             - Function's name: findMax(), find_max()
               C#: FindMax()
               Not proper: findMax, abc() find8x10df(), 8xFind(), maximum()
             - List of parameter(s) - Inputs of the function
                      int[] x
             - Return type: data type of the expected output of the function
                      int 

         */



        private int findMax(int[] x) // definition of the function findMax()
        {
            int max = Int32.MinValue;
            for(int i = 0; i < x.Length; i++) 
            {
                if(max < x[i])
                { 
                    max = x[i]; 
                }
            }
            return max;   //Returned value
        }

        private void printAll(int[] x)
        {

        }

        private bool login(string username, string password)
        {
            return false;
        }
    }
}
