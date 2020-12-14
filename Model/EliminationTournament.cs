using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    class EliminationTournament: Tournament, ITournament
    {
        public EliminationTournament(int id, string surface, string type): base(id, surface, type)
        {

        }

        public List<List<Matchup>> Sets { get; set; }

        public void MatchPlayers()
        {
          
        }

        public void StartTournament(List<Player> players)
        {
            Console.WriteLine("Elimination Tournament is starting");
        }
    }
}
