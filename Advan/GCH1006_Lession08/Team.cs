using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GCH1006_Lession08
{
    internal class Team
    {
        public int id;
        public string name;
        public string description;
        public string stadium;

        public Player[] players;
        public const int MAX = 11;
        public int count;
        public Team (int id, string name)
        {
            this.id = id;
            this.name = name;
            players= new Player[MAX];
        }

        public void addMember(Player p)
        {
            if(count < MAX)
            {
                players[count] = p;
                count++;
            }    
        }

        public void addMember()
        {
            if(count < MAX)
            {

            }    
        }


        public void printTeamMembers()
        {
            for (int i = 0; i < count; i++)
            {
                players[i].print();
            }    
        }
    }
}
