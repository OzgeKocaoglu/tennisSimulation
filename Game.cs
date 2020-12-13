using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    class Game
    {
        DataSerializer dataSerializer;

        public Game()
        {
            dataSerializer = new DataSerializer();
        }

        public void CreateNewGame()
        {
            DataModel dataModel = dataSerializer.DeseriliazeJSON();
            if(dataModel != null) GetPlayers(dataModel);
        }

        public void GetPlayers(DataModel dataModel)
        {
            List<Player> players = dataModel.players;
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("PlayerID: " + players[i].id + "\nPlayer Hand: " + players[i].hand + "\nPlayer Experience: " + players[i].experience + "\nPlayer Skills " + "\nclay " + players[i].skills.clay);
                Console.WriteLine("---------------------------");
            }
        }



    }
}
