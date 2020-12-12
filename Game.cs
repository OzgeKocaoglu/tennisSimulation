using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    class Game
    {
        private List<Player> players;
        public SkillSet skillSet;

        public Game()
        {
            players = new List<Player>();
            skillSet = new SkillSet();
        }

        public void CreateNewGame()
        {
            CreatePlayers();
            InitiliazeSkills();
        }

        public void CreatePlayers()
        {
            players.Add(new Player(Player.Hand.right, 0));
            players.Add(new Player(Player.Hand.left, 5));
            players.Add(new Player(Player.Hand.left, 10));
            players.Add(new Player(Player.Hand.right, 15));

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("Player " + i + "\nID: " + players[i].ID + "\nHand side: " + players[i].PlayerHand + "\nExperience: " + players[i].Experience);
                Console.WriteLine("----------------------------------------");
            }

        }

        public void InitiliazeSkills()
        {
            skillSet.CreateSkill("Grass", 0);
            skillSet.CreateSkill("Hard", 0);
            skillSet.DisplaySkills();
        }

        
    }
}
