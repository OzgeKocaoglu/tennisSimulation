using System;
using System.Collections.Generic;


namespace Tennis_Simulation
{
    class TournamentController
    {
        List<ITournament> alltournaments;
        List<Player> tournamentPlayers;

        public TournamentController(DataModel dataModel)
        {
            alltournaments = TournamentConverter.ConvertTournaments(dataModel.tournaments);
            tournamentPlayers = new List<Player>();
             
        }
        public List<ITournament> GetTournaments()
        {
            return alltournaments;
        }

        public void StartTournaments(List<Player> players)
        {
            for(int i = 0; i <alltournaments.Count; i++)
            {
                tournamentPlayers = alltournaments[i].StartTournament(players);
                
            }
           
        }
    }
}
