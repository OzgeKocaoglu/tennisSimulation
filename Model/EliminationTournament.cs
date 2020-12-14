﻿using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    class EliminationTournament: Tournament, ITournament
    {

        public List<List<Matchup>> Sets { get; set; }
        private List<Player> eliminationTournamentPlayers = new List<Player>();

        public EliminationTournament(int id, string surface, string type): base(id, surface, type)
        {

        }

        public void MatchPlayers()
        {
            Console.WriteLine("Matching players...");
            Sets = new List<List<Matchup>>();

            if((eliminationTournamentPlayers.Count % 2) != 0)
            {
                Console.WriteLine("Player number is not valid. So we decided to remove last player from the list.");
                eliminationTournamentPlayers.RemoveAt(eliminationTournamentPlayers.Count - 1);
            }
            for(int i = 0; i< eliminationTournamentPlayers.Count; i++)
            {

            }
        }
        public void StartTournament(List<Player> players)
        {
            Console.WriteLine("Elimination Tournament is starting");
            eliminationTournamentPlayers = players;
            MatchPlayers();
        }
    }
}
