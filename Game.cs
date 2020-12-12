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
            players.Add(new Player("1", Player.Hand.right, 0));
            Console.WriteLine(players[0].ID);
            Console.WriteLine(players[0].PlayerHand);
        }
    }
}
