using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class LeagueTournament : Tournament, ITournament
    {
        public LeagueTournament(int id, string surface, string type) : base(id, surface, type)
        {

        }

        public List<Matchup> Matchups { get; set; }

        public void MatchPlayers()
        {
           
        }

        public void StartTournament(List<Player> players)
        {
            Console.WriteLine("League Tournament is starting");
        }
    }
}
