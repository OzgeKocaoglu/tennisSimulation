using Tennis_Simulation.Controller;

namespace Tennis_Simulation
{
    class Game
    {
        DataSerializer dataSerializer;
        PlayerController playerController;
        TournamentController tournamentController;
        OrderController orderController;

        public Game()
        {
            dataSerializer = new DataSerializer();
        }

        public void CreateNewGame()
        {
            DataModel dataModel = dataSerializer.DeseriliazeJSON();
            playerController = new PlayerController(dataModel);
            tournamentController = new TournamentController(dataModel);
            orderController = new OrderController();
            //orderController.OrderPlayers(tournamentController.GetTournamentPlayers()) 
            StartGame();
        }

       public void StartGame()
        {
            tournamentController.StartTournaments(playerController.GetPlayers());
        }

    }
}
