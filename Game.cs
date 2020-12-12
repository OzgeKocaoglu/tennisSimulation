using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    class Game
    {
        private List<Player> players;

        public Game()
        {
            players = new List<Player>();
        }

        public void CreateNewGame()
        {
            CreatePlayers();
        }

        public void CreatePlayers()
        {
            players.Add(new Player(Player.Hand.right, 0));
            players.Add(new Player(Player.Hand.left, 5));
            players.Add(new Player(Player.Hand.left, 10));
            players.Add(new Player(Player.Hand.right, 15));

            for(int i=0; i<players.Count; i++)
            {
                Console.WriteLine("Player "+ i + "\nID: " + players[i].ID + "\nHand side: " + players[i].PlayerHand + "\nExperience: " + players[i].Experience);
                Console.WriteLine("----------------------------------------");
            }

        }
    }
}
