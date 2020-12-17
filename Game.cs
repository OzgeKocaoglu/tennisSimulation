using System;
using System.Collections.Generic;
using Tennis_Simulation.Controller;

namespace Tennis_Simulation
{
    class Game
    {
        #region Variables
        DataSerializer dataSerializer;
        PlayerController playerController;
        TournamentController tournamentController;
        OrderController orderController;
        DataModel dataModel;
        #endregion

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
            OrderResults();
        }
        public void StartGame()
        {
            tournamentController.StartTournaments(playerController.GetPlayers());
           
        }
        public void OrderResults()
        {
            orderController.OrderPlayers(playerController.GetPlayers());
        }

    }
}
