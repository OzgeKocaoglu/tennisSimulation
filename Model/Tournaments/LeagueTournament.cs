using System;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace Tennis_Simulation
{
    class LeagueTournament : Tournament, ITournament
    {
        public List<Matchup> Matchups { get; set; }
        private List<Player> leagueTournamentPlayers { get; set; }

        public LeagueTournament(int id, string surface, string type) : base(id, surface, type)
        {
            Matchups = new List<Matchup>();
            leagueTournamentPlayers = new List<Player>();
        }

        public List<Player> StartTournament(List<Player> players)
        {
            Console.WriteLine("League Tournament is starting\n");
            leagueTournamentPlayers = players;
            MatchPlayers(leagueTournamentPlayers);
            Console.WriteLine($"Matchup count is : {Matchups.Count}");
            StartMatchs(Matchups);
            return leagueTournamentPlayers;
        }
        public void MatchPlayers(List<Player> players)
        {
            Console.WriteLine("Matching players...\n");
            for(int i = 0; i< players.Count; i++)
            {
                for(int j = i+1; j < players.Count; j++)
                {
                    List<Player> playerList = new List<Player>();
                    playerList.Add(players[i]);
                    playerList.Add(players[j]);
                    Matchup matchup = new Matchup(playerList);
                    Console.WriteLine($"Player {players[i].id} is matching up with Player {players[j].id}");
                    Matchups.Add(matchup);
                }
            }
            Matchups.Shuffle();
        }
        private List<Player> StartMatchs(List<Matchup> matchups)
        {
            List<Player> player = new List<Player>();
            for(int i= 0; i< matchups.Count; i++)
            {
                Console.WriteLine($"{this.id}. League Tournament and Match is starting...\n");
                Match match;
                match = new Match();
                match.StartMatch(matchups[i], this.surface);
                AddExperiences(match.Winner, match.Loser);

            }
            return player;
        }
        private void AddExperiences(Player winner, Player loser)
        {
            for (int i = 0; i < leagueTournamentPlayers.Count; i++)
            {
                if (leagueTournamentPlayers[i] == winner)
                {
                    leagueTournamentPlayers[i].gainedExperience += 10;
                }
                else if (leagueTournamentPlayers[i] == loser)
                {
                    leagueTournamentPlayers[i].gainedExperience += 1;
                }
            }

        }

    }
}
