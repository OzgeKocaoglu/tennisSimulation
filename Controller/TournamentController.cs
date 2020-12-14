using AutoMapper;
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
        List<ITournament> alltournaments;


        public TournamentController(DataModel dataModel)
        {
            tournaments = dataModel.tournaments;
            alltournaments = new List<ITournament>();
        }
        public List<Tournament> GetTournaments()
        {
            return tournaments;
        }


        public void StartTournaments(List<Player> players)
        {
            for (int i = 0; i < tournaments.Count; i++)
            {
                if(tournaments[i].type == "elimination")
                {
                    alltournaments.Add(new EliminationTournament(tournaments[i].id, tournaments[i].surface, tournaments[i].type));
                }
                else if(tournaments[i].type == "league")
                {
                    alltournaments.Add(new LeagueTournament(tournaments[i].id, tournaments[i].surface, tournaments[i].type));
                }

            }

            for(int i = 0; i <alltournaments.Count; i++)
            {
                Console.WriteLine("Tournaments: \n");
                alltournaments[i].StartTournament(players);
            }
           
        }



    }
}
