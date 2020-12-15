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

        public Matchup(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                MatchupEntry entry = new MatchupEntry();
                entry.Competing = players[i];
                Entries.Add(entry);
            }
        }

    }
}
