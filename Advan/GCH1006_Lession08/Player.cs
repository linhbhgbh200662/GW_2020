using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession08
{
    internal class Player
    {
        public int id;
        public string name;
        public bool role; // true: captain, false: members
        public Team owner;
        
        public Team Owner
        {
            get { return owner; }
            set {
                if(owner != value)
                {
                    owner.removeMember(this);
                    owner = value;
                    owner.addMember(this);
                }
            }
        }
        public Player(int id, string name, bool role) 
        {
            this.id = id;
            this.name = name;
            this.role = false;
        }

        public void discussBeforeTheMath()
        {
            if (role)
                Console.WriteLine("Fighting");
            else
                Console.WriteLine("You don't have permission to process this task");
        }

        public void print()
        {
            Console.WriteLine("MemID: {0, -4} | {1, -22} | {2, -7}", id, name, (role) ? "Captain" : "Member");  // {0, -4}Ư: khoảng trống
        }
    }
}
