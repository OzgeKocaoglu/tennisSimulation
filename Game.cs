﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace tennisSimulation
{
    class Game
    {
       
        // DataSerializer dataSerializer;
        private readonly string _path = @"C:\Users\Özge Kocaoğlu\source\repos\tennisSimulation\input.json";

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                Console.WriteLine(json);
               Player playerList =JsonConvert.DeserializeObject<Player>(json);
                Console.WriteLine(playerList);
            }
        }

        public Game()
        {
            // dataSerializer = new DataSerializer();
        }

        public void CreateNewGame()
        {
            
            CreatePlayers();
            LoadJson();
        }

        //TO DO: JSON Dosyasından çek. 
        public void CreatePlayers()
        {
            /*players.Add(new Player(Hand.right.ToString(), 0));
            players.Add(new Player(Hand.left.ToString(), 5));
            players.Add(new Player(Hand.left.ToString(), 10));
            players.Add(new Player(Hand.right.ToString(), 15));

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Player " + i + "\nID: " + players[i].id + "\nHand side: " + players[i].hand + "\nExperience: " + players[i].experience);
            }
            */
        }


        
    }
}
