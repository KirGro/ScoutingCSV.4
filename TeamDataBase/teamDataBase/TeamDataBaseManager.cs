using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamDataBase;

namespace ScoutingCSV4.teamDataBasePack
{
    enum DataManagement {DEFAULT, MOVE, DUPLICATE, COMPRESSEDCOPY}
    enum Restore {NEW, RESTORING}
    class TeamDataBaseManager
    {
        private static readonly string version = "1.0.0";
        private TeamDataBase tdb;

        public TeamDataBaseManager(String fileLocation, Restore restoring)
        {
            switch(restoring)
            {
                default:
                {
                    Console.WriteLine("Preparing fresh database");
                    tdb = new TeamDataBase(2017, new Dictionary<int, Team>());
                }
                    break;
                case Restore.RESTORING:
                {
                        Console.WriteLine("Preparing to restore database");
                        RestoreDatabase();
                }
                    break;
                
            }
            Console.WriteLine("Database ready");
        }

        public TeamDataBaseManager(String fileLocation) : this(fileLocation, Restore.RESTORING) { }

        private void RestoreDatabase()
        {

        }

        private void RestoreProtocol1d0d0() 
        {
            
        }


    }
}
