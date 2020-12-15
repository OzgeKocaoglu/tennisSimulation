using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class Match
    {
        public ScoreSystem scoreSystem { get; set; }

        public Match()
        {
            scoreSystem = new ScoreSystem();
        }
        public void StartMatch(Matchup matchup)
        {

            Player player1 = matchup.Entries[0].Competing;
            Player player2 = matchup.Entries[1].Competing;
            matchup.Entries[0].Score = scoreSystem.addPointToPlayer(player1, player2);
            matchup.Entries[1].Score = scoreSystem.addPointToPlayer(player2, player1);
            Console.Write("Competing 1 score is: " + matchup.Entries[0].Score + "\n");
            Console.Write("Competing 2 score is: " + matchup.Entries[1].Score + "\n");

        }


    }
}
