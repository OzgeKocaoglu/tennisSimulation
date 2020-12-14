using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class LeagueTournament : Tournament, ITournament
    {
        public List<List<Matchup>> Sets { get; set; }

        public void MatchPlayers()
        {
            throw new NotImplementedException();
        }

        public void StartTournament()
        {
            throw new NotImplementedException();
        }
    }
}
