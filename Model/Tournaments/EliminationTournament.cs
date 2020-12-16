using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    class EliminationTournament: Tournament, ITournament
    {
        #region Variables
        public List<List<Matchup>> Rounds;
        private List<Player> eliminationTournamentPlayers { get; set; }
        #endregion

        public EliminationTournament(int id, string surface, string type): base(id, surface, type)
        {
            Rounds = new List<List<Matchup>>();
            eliminationTournamentPlayers = new List<Player>();
        }

        public List<Player> StartTournament(List<Player> players)
        {
            Console.WriteLine("Elimination Tournament is starting\n");
            eliminationTournamentPlayers = players;
            MatchPlayers(eliminationTournamentPlayers);
            for(int i =0; i< Rounds.Count; i++)
            {
                List<Player> winnerList = StartMatchs(Rounds[i]);
                for (int j = 0; j < winnerList.Count; j++)
                {
                    Console.WriteLine($"Round: {i+1} \n Winner list\n : {winnerList[j].id} ");
                }
                if(winnerList.Count != 1)
                {
                    MatchPlayers(winnerList);
                }
                
            }
            return eliminationTournamentPlayers;

        }


       private void MatchPlayers(List<Player> players)
        {
            Console.WriteLine("Matching players...\n");
            List<Matchup> Matchups = new List<Matchup>();
            List<List<Player>> playerList = ListUtils.SettingUpPlayerList(players);
            for (int i = 0; i < playerList.Count; i++)
            {
                Matchup matchup = new Matchup(playerList[i]);
                Matchups.Add(matchup);
               
            }
            Rounds.Add(Matchups);

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
                AddExperiences(match.Winner, match.Loser);
                player.Add(SetWinnerPlayer(matchups[i]));
                
            }
            return player;
        }

        private void AddExperiences(Player winner, Player loser)
        {
            for (int i=0; i<eliminationTournamentPlayers.Count; i++)
            {
                if(eliminationTournamentPlayers[i] == winner)
                {
                    Console.WriteLine($"Elimination Tournament {eliminationTournamentPlayers[i].id}. oyuncu ilk deneyim puanı: {eliminationTournamentPlayers[i].experience}");
                    eliminationTournamentPlayers[i].experience += 20;
                    Console.WriteLine($"Elimination Tournament {eliminationTournamentPlayers[i].id}. oyuncu son deneyim puanı: {eliminationTournamentPlayers[i].experience}");
                }
                else if(eliminationTournamentPlayers[i] == loser)
                {
                    Console.WriteLine($"Elimination Tournament {eliminationTournamentPlayers[i].id}. oyuncu ilk deneyim puanı: {eliminationTournamentPlayers[i].experience}");
                    eliminationTournamentPlayers[i].experience += 10;
                    Console.WriteLine($"Elimination Tournament {eliminationTournamentPlayers[i].id}. oyuncu son deneyim puanı: {eliminationTournamentPlayers[i].experience}");
                }
            }
            
        }

        public Player SetWinnerPlayer(Matchup matchup)
        {
            Player winnerPlayer = new Player();
            Console.WriteLine($"Matchup winner is {matchup.Winner}");
            for (int i=0; i< eliminationTournamentPlayers.Count; i++)
            {
                if(matchup.Entries[0].Competing == matchup.Winner)
                {
                    if (matchup.Entries[0].Competing.id == eliminationTournamentPlayers[i].id)
                    {
                        Console.WriteLine($"Elimination players winner is {eliminationTournamentPlayers[i].id}");
                        return eliminationTournamentPlayers[i];
                    }
                }
                else
                {
                    if(matchup.Entries[1].Competing.id == eliminationTournamentPlayers[i].id)
                    {
                        Console.WriteLine($"Elimination players winner is {eliminationTournamentPlayers[i].id}");
                        return eliminationTournamentPlayers[i];
                    }
                }
            }
            return winnerPlayer;

        }


       

    }
}
