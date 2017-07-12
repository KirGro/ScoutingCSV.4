using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCSV4.teamDataBasePack
{
    public class TeamDataBase
    {
        public Dictionary<int, Team> teams;
        private int year;
        
        public TeamDataBase(int year, Dictionary<int, Team> teams)
        {
            this.year = year;
            this.teams = teams;
        }

        internal void AddTeam(int teamNumber)
        {
            teams.Add(teamNumber, new Team(teamNumber));
        }

        internal void AddTeam(Team team)
        {
            teams.Add(team.GetTeamNumber(), team);
        }


    }
}
