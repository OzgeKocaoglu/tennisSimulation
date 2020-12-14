
using System.Collections.Generic;

namespace Tennis_Simulation
{
    interface ITournament
    {
        List<List<Matchup>> Sets { get; set; }
        void StartTournament(List<Player> players);
    }
}
