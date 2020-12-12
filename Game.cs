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
            skillSet = new SkillSet();
            skillSet.DisplaySkills();
        }

        public void CreateNewGame()
        {
            players = new List<Player>();
            CreatePlayers();
        }

        //TO DO: JSON Dosyasından çek. 
        public void CreatePlayers()
        {
            players.Add(new Player(Player.Hand.right, 0));
            players.Add(new Player(Player.Hand.left, 5));
            players.Add(new Player(Player.Hand.left, 10));
            players.Add(new Player(Player.Hand.right, 15));

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Player " + i + "\nID: " + players[i].ID + "\nHand side: " + players[i].PlayerHand + "\nExperience: " + players[i].Experience + "\nPlayer Skills: " + players[i].PlayerSkills.SkillSet.GetSkills()[0].Name + "\nValue: " + players[i].PlayerSkills.SkillSet.GetSkills()[0].Value);
            }

        }


        
    }
}
