using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCSV4.teamDataBasePack
{
    public class Team
    {
        private String name;
        private int number;
        private ArrayList matches;

        public Team(int number) 
        {
            this.number = number;
        }

        public int GetTeamNumber()
        {
            return number;
        }
    }
}
