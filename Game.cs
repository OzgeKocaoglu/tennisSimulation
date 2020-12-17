using System;
using System.Collections.Generic;
using Tennis_Simulation.Controller;

namespace Tennis_Simulation
{
    class Game
    {
        DataSerializer dataSerializer;
        PlayerController playerController;
        TournamentController tournamentController;
        OrderController orderController;
        DataModel dataModel;

        public Game()
        {
            dataSerializer = new DataSerializer();
        }

        public void CreateNewGame()
        {
            dataModel = dataSerializer.DeseriliazeJSON();
            playerController = new PlayerController(dataModel);
            tournamentController = new TournamentController(dataModel);
            orderController = new OrderController();
            StartGame();
        }

       public void StartGame()
        {
            tournamentController.StartTournaments(playerController.GetPlayers());
            orderController.OrderPlayers(playerController.GetPlayers());
        }

    }
}
