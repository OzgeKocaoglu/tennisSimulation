using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace tennisSimulation
{
    class Game
    {
       
        DataSerializer dataSerializer;
        private readonly string _path = @"C:\Users\Özge Kocaoğlu\source\repos\tennisSimulation\input.json";

        public Game()
        {
           dataSerializer = new DataSerializer();
        }

        public void CreateNewGame()
        {
            DataModel dataModel = dataSerializer.LoadJson(_path);
            GetPlayers(dataModel);
        }

        public void GetPlayers(DataModel dataModel)
        {
            List<Player> players = dataModel.players;
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("PlayerID: " + players[i].id + "\nPlayer Hand: " + players[i].hand + "\nPlayer Experience: " + players[i].experience + "\nPlayer Skills " + "\nclay " +  players[i].skills.clay);
                Console.WriteLine("---------------------------");
            }
        }


        
    }
}
