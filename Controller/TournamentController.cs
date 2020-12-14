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
        List<ITournament> alltournaments;


        public TournamentController(DataModel dataModel)
        {
            alltournaments = TournamentConverter.ConvertTournaments(dataModel.tournaments);
             
        }
        public List<ITournament> GetTournaments()
        {
            return alltournaments;
        }

        public void StartTournaments(List<Player> players)
        {

            for(int i = 0; i <alltournaments.Count; i++)
            {
                alltournaments[i].StartTournament(players);
            }
           
        }




    }
}
