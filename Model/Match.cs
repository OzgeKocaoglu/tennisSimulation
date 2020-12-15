using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class Match
    {
        public ScoreSystem scoreSystem;


        public void StartMatch(Matchup matchup, string surface)
        {
            
            Player player1 = matchup.Entries[0].Competing;
            Player player2 = matchup.Entries[1].Competing;
            scoreSystem = new ScoreSystem(player1, player2, surface);
            Console.Write("Competing 1 score is: " + matchup.Entries[0].Score + "\n");
            Console.Write("Competing 2 score is: " + matchup.Entries[1].Score + "\n");

        }


    }
}
