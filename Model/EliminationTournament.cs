using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    class EliminationTournament: Tournament, ITournament
    {
        #region Variables
        public List<Matchup> Matchups { get; set; }
        private List<Player> eliminationTournamentPlayers { get; set; }
        #endregion
        public EliminationTournament(int id, string surface, string type): base(id, surface, type)
        {
            Matchups = new List<Matchup>();
            eliminationTournamentPlayers = new List<Player>();
        }

        public void StartTournament(List<Player> players)
        {
            Console.WriteLine("Elimination Tournament is starting");
            eliminationTournamentPlayers = players;
            MatchPlayers();
            StartMatchs(Matchups);
        }

        #region Matching Functions
        private void MatchPlayers()
        {
            Console.WriteLine("Matching players...");
            for (int i = 0; i<SettingUpPlayerList().Count; i++)
            {
                Matchup matchup = new Matchup(SettingUpPlayerList()[i]);
                Matchups.Add(matchup);
            }

            for(int i=0; i< Matchups.Count; i++)
            {
                for (int j = 0; j < Matchups[i].Entries.Count; j++)
                    Console.WriteLine("Matchup: " + i + "Player 1: " + Matchups[i].Entries[j].Competing.id);
            }

        }
        #endregion

        /// <summary>
        /// Takes player list and correct player list count for 2^n and split lists.
        /// </summary>
        List<List<Player>> SettingUpPlayerList()
        {
            if ((eliminationTournamentPlayers.Count % 2) != 0)
            {
                Console.WriteLine("Player number is not valid. So we decided to remove last player from the list.");
                eliminationTournamentPlayers.RemoveAt(eliminationTournamentPlayers.Count - 1);
            }
            List<List<Player>> dividedPlayers = ListUtils.splitList(eliminationTournamentPlayers, 2);
            return dividedPlayers;
        }

        private List<Player> StartMatchs(List<Matchup> matchups)
        {
            List<Player> player = new List<Player>();
            Match match;
            for(int i =0; i< matchups.Count; i++)
            {
                int index = i + 1;
                Console.WriteLine(this.id + ". Elimination Tournament and " + index + ". Match is starting...\n");
                match = new Match();
                match.StartMatch(matchups[i]);
                
            }
            return player;
        }

 
    }
}
