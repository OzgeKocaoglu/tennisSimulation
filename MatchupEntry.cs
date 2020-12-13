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
        public Matchup ParentMatchup { get; set; }

    }
}
