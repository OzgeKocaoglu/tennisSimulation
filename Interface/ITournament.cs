
using System.Collections.Generic;

namespace Tennis_Simulation
{
    interface ITournament
    {
        List<Matchup> Matchups { get; set; }
        void StartTournament(List<Player> players);
    }
}
