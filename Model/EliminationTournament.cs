using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    class EliminationTournament: Tournament, ITournament
    {
        #region Variables
        public List<List<Matchup>> Rounds;
        public List<Matchup> Matchups { get; set; }
        private List<Player> eliminationTournamentPlayers { get; set; }
        #endregion

        public EliminationTournament(int id, string surface, string type): base(id, surface, type)
        {
            Matchups = new List<Matchup>();
            Rounds = new List<List<Matchup>>();
            Rounds.Add(Matchups);
            eliminationTournamentPlayers = new List<Player>();
        }

        public void StartTournament(List<Player> players)
        {
            Console.WriteLine("Elimination Tournament is starting\n");
            
            for(int i=0; i< Rounds.Count; i++)
            {
                Console.WriteLine($"Round {i+1} is starting ");
                eliminationTournamentPlayers = players;
                MatchPlayers(eliminationTournamentPlayers);
                StartMatchs(Matchups);
            }
           
        }

        private void MatchPlayers(List<Player> players)
        {
            Console.WriteLine("Matching players...\n");
            List<List<Player>> playerList = ListUtils.SettingUpPlayerList(players);
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
                Console.WriteLine($"{this.id}. Elimination Tournament and {i+1} Match is starting...\n");
                match = new Match();
                match.StartMatch(matchups[i], this.surface);
                AddExperiences(match.GetWinner(), matchups[i]);
                //TODO: GET THE WİNNER LIST AND MAKE THEM PROCESS AGAIN.
                
            }
            return player;
        }

        private void AddExperiences (Player winner, Matchup matchup)
        {
            if(matchup.Entries[0].Competing == winner)
            {
                matchup.Entries[0].Competing.experience += 20;
                matchup.Entries[1].Competing.experience += 10;
                Console.WriteLine($"Player:{matchup.Entries[0].Competing.id} and Experience is {matchup.Entries[0].Competing.experience}");
                Console.WriteLine($"Player:{matchup.Entries[1].Competing.id} and Experience is {matchup.Entries[1].Competing.experience}");
            }
            else
            {
                matchup.Entries[1].Competing.experience += 20;
                matchup.Entries[0].Competing.experience += 10;
                Console.WriteLine($"Player:{matchup.Entries[0].Competing.id} and Experience is {matchup.Entries[0].Competing.experience}");
                Console.WriteLine($"Player:{matchup.Entries[1].Competing.id} and Experience is {matchup.Entries[1].Competing.experience}");
            }
            
        }

 
    }
}
