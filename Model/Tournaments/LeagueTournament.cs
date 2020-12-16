using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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

        public void MatchPlayers(List<Player> players)
        {
            Console.WriteLine("Matching players...\n");
            //Match one player with all players
            //Do this for all players
        }

        private List<Player> StartMatchs(List<Matchup> matchups)
        {
            List<Player> player = new List<Player>();
            Match match;
            for (int i = 0; i < matchups.Count; i++)
            {
                //Start all matchups randomize. 
                Console.WriteLine($"{this.id}. League Tournament and {i + 1} Match is starting...\n");
                match = new Match();
                match.StartMatch(matchups[i], this.surface);

            }
            return player;
        }

        public void StartTournament(List<Player> players)
        {
            Console.WriteLine("League Tournament is starting\n");
            leagueTournamentPlayers = players;
            //MatchPlayers(leagueTournamentPlayers);
            //StartMatchs(Matchups);
        }


        #region Utility Methods
        private RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
        private int RandomInteger(int min, int max)
        {
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                byte[] four_bytes = new byte[4];
                Rand.GetBytes(four_bytes);
                scale = BitConverter.ToUInt32(four_bytes, 0);
            }

            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }
        #endregion
    }
}
