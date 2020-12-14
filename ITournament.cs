
using System.Collections.Generic;

namespace Tennis_Simulation
{
    interface ITournament
    {
        List<List<Matchup>> Sets { get; set; }
        void MatchPlayers();
        void StartTournament(List<Player> players);
    }
}
