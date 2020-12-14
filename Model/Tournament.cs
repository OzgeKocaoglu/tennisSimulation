

using System.Collections.Generic;

namespace Tennis_Simulation
{
    class Tournament : ITournament
    {
        public int id { get; set; }
        public string surface { get; set; }
        public string type { get; set; }
        public List<List<Matchup>> Sets { get; set; }

        public void MatchPlayers()
        {
            
        }

        public void StartTournament(List<Player> players)
        {
            
        }
    }
}
