using System.Collections.Generic;

namespace Tennis_Simulation
{
    /// <summary>
    /// Represents one mathup at the all tournament.
    /// </summary>
    class Matchup
    {
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
