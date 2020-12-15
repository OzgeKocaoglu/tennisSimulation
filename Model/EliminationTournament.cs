using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    internal class EliminationTournament: Tournament, ITournament
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
        }

        #region Matching Functions
        private void MatchPlayers()
        {
            Console.WriteLine("Matching players...");
            for (int i = 0; i<SettingUpPlayerList().Count; i++)
            {
                SetInitialMatchUp(SettingUpPlayerList()[i]);
            }

        }
        void SetInitialMatchUp(List<Player> players)
        {
            List<MatchupEntry> entries = new List<MatchupEntry>();
            Matchup matchup = new Matchup();

            for(int i=0; i<players.Count; i++)
            {
                MatchupEntry entry = new MatchupEntry();
                entry.Competing = players[i];
                entries.Add(entry);
            }
            matchup.Entries = entries;
            Matchups.Add(matchup);

        }
        #endregion
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

    }
}
