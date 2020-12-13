using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class Matchup
    {
        /// <summary>
        /// Represents one mathup at the all tournament.
        /// </summary>
        public List<MatchupEntry> Entries = new List<MatchupEntry>();
        public Player Winner { get; set; }
        public int MatchupSet { get; set; }
    }
}
