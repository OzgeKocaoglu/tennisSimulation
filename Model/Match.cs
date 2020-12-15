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
            int playerOneScore = scoreSystem.addPointToPlayer();
            scoreSystem = new ScoreSystem(player2, player1, surface);
            int playerTwoScore = scoreSystem.addPointToPlayer();

            Console.Write("Competing 1 score is: " + playerOneScore + "\n");
            Console.Write("Competing 2 score is: " + playerTwoScore + "\n");

        }


    }
}
