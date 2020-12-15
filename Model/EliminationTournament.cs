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

        private void MatchPlayers()
        {
            Console.WriteLine("Matching players...");
            List<List<Player>> playerList = ListUtils.SettingUpPlayerList(eliminationTournamentPlayers);
            for (int i = 0; i < playerList.Count; i++)
            {
                Matchup matchup = new Matchup(playerList[i]);
                Matchups.Add(matchup);
            }

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
