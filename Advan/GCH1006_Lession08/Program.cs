using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team one = new Team(101, "Arsenal");
            Team two = new Team(202, "MU");

            Player p1 = new Player(1, "Quan", true);
            p1.Owner = one;

            Player p2 = new Player(2, "Tuan", false);
            p2.Owner = one;

            Player p3 = new Player(3, "Viet Anh", false);
            p3.Owner = one;

            one.captain = p2;
            one.printTeamMembers();
            Console.WriteLine("---------------------------");

            one.captain = p3;
            one.printTeamMembers();
            Console.WriteLine("---------------------------");

            one.captain = p2;
            one.printTeamMembers();
            Console.WriteLine("---------------------------");

            p2.Owner = two;
            one.printTeamMembers();
            two.printTeamMembers();
        }
    }
}
