using System.Collections.Generic;
namespace ScoutingCSV4.teamDataBasePack
{
    
    public struct MatchResult
    {
        private Dictionary<int, int> data;

        public MatchResult(Dictionary<int, int> data)
        {
            this.data = data;
        }

        public int GetData(int type)
        {
            return data[type];
        }
    }
}
