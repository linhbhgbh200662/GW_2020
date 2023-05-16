using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap
{
    class Student
    {
       private string Name; //riêng tư
       private int ID;
       private string _class;
      
       // sử dụng hàm get, set để đọc và ghi dữ liệu dựa trên các yêu cầu
       public string name // công khai
       {
            get { return Name;}
            set { this.Name = value;}
       }

       public int id
       {
            get { return ID;}   // đọc
            set { this.ID = value;}  // thay đổi
       }
       
       public string Class
       {
            get{ return _class;}
            set{ this._class = value;}
       }

        public override string ToString()
        {
            return "Student name: " + Name + "id" + ID + "class" + Class ;
        }
    }
}
