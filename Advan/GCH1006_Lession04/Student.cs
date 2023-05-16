using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession04
{
    //Define two classes: Student & Teacher
    // Student can register a course, but a course contains no more than 5 students
    // Teacher
    // The system contains these main operations:
    // - Display the list of student n a course
    //        
    // - Assign a teacher to a course
    //        A teacher can be assigned into no more than 5 courrses.
    public class Student
    {

        public int Id;
        public string Name;
        public string Email;
        public string Batch;
        public bool Gender = true;

        

        public bool registerACourse(Course c)
        {
            return c.updateStudentList(this);
        }

        public void print()
        {
            Console.WriteLine("Id: " + Id + "Name: " + Name );
        }

    }
}
