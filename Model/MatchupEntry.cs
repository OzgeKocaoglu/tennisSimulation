using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class MatchupEntry
    {
        /// <summary>
        /// Represents one player int the matchup
        /// </summary>
        public Player Competing { get; set; }
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as the winner. 
        /// </summary>
        public Matchup ParentMatchup { get; set; }

        public MatchupEntry(double initialScore)
        {
        }

    }
}
