using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession03
{
    internal class Ex03
    {
        //2. Write a function to reverse a string
        public Ex03()
        {
            string str = "Hello world!";
            str = reverse(str);
            Console.WriteLine(str);  //!dlo wolleH
        }

        private string reverse(string str)
        {
            char[] chars = str.ToCharArray();
            int n = chars.Length;
            for (int i = 0; i <= n / 2; i++)
            {
                swap(chars, i, n - 1 - i);
            }
            str = new String(chars);
            return str;
        }

        private void swap(char[] chars, int i, int j)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
    }
}
