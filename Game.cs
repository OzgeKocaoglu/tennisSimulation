using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    class Game
    {
        DataSerializer dataSerializer;
        PlayerController playerController;
        TournamentController tournamentController;

        public Game()
        {
            dataSerializer = new DataSerializer();
        }

        public void CreateNewGame()
        {
            DataModel dataModel = dataSerializer.DeseriliazeJSON();
            playerController = new PlayerController(dataModel);
            tournamentController = new TournamentController(dataModel);
            StartGame();
        }

       public void StartGame()
        {
            tournamentController.StartTournaments(playerController.GetPlayers());
        }

    }
}
