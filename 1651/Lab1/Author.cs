using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Author
    {
        public string Name { get; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author(string name, string email, char gender)
        {
            if (gender == 'm' || gender == 'f')
            {
                this.Name = name;
                this.Email = email;
                this.Gender = gender;
            }
            else
            {
                Console.WriteLine("Giới tính k phù hợp");
            }

        }
        public override string ToString()
        {
            return "Author[Name= " + this.Name + ", Email= " + this.Email + ", Gender= " + this.Gender + "]";
        }
    }
}

    

