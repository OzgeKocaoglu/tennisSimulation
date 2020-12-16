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
                GetTournamentResultPlayers();
                tournamentPlayers = alltournaments[i].StartTournament(players);
                
            }
           
        }

        public List<Player> GetTournamentResultPlayers()
        {
            for(int i=0; i< tournamentPlayers.Count; i++)
            {
                Console.WriteLine($"tournament player experiences: \n {i + 1}. Player: \n id = {tournamentPlayers[i].id} \n experience={tournamentPlayers[i].experience}");
            }
            return tournamentPlayers;
        }




    }
}
