using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis_Simulation;

namespace Tennis_Simulation
{
    class TournamentController
    {
        List<Tournament> tournaments;

        public TournamentController(DataModel dataModel)
        {
            tournaments = dataModel.tournaments;
        }

        public List<Tournament> GetTournaments()
        {
            return tournaments;
        }


        public void StartTournaments(List<Player> players)
        {
            for(int i = 0; i <tournaments.Count; i++)
            {
                Console.WriteLine("Tournament " + i + " is starting.");
                tournaments[i].StartTournament(players);
            }
        }

    }
}
