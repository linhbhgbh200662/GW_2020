using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GCH1006_Lession04
{
    public class Course
    {
        public int id;
        public string name;
        public Student[] std;   // danh sách sv đang theo hk
        private const int MAX_STD = 5; // mọt khóa hk có tối đa 5 sv
        private int count = 0;  // số lượng sv đã đky hk 

        public Course(int id, string name)
        {
            this.id = id;
            this.name = name;
            std = new Student[MAX_STD];
        }

        public bool updateStudentList(Student each)
        {
            if (count < MAX_STD)
            {
                std[count] = each;
                count++;
                return true;
            }
            else
            {
                return false;
            }        
        }
        public void printStudentList()
        {
            for(int i = 0; i < count; i++)
            {
                std[i].print();
            }
        }
    }
}
