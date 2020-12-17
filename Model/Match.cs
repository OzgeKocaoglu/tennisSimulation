using System;

namespace Tennis_Simulation
{
    class Match
    {
        public ScoreSystem scoreSystem;
        public Player Winner;
        public Player Loser;

        public void StartMatch(Matchup matchup, string surface)
        {
            
            Player player1 = matchup.Entries[0].Competing;
            Player player2 = matchup.Entries[1].Competing;

            scoreSystem = new ScoreSystem(player1, player2, surface);
            matchup.Entries[0].Score = scoreSystem.addPointToPlayer();
            scoreSystem = new ScoreSystem(player2, player1, surface);
            matchup.Entries[1].Score = scoreSystem.addPointToPlayer();

            Console.Write("Competing 1 score is: " + matchup.Entries[0].Score + "\n");
            Console.Write("Competing 2 score is: " + matchup.Entries[1].Score + "\n");

            CalculateWinner(matchup.Entries[0], matchup.Entries[1]);
        }
        public void CalculateWinner(MatchupEntry playerOne, MatchupEntry playerTwo)
        {
            double sum = playerOne.Score + playerTwo.Score;
            double playerOneWinProbability = playerOne.Score / sum;
            Console.WriteLine("Matchup competing one win probability : " + playerOneWinProbability);
            double playerTwoWinProbability = playerTwo.Score / sum;
            Console.WriteLine("Matchup competing two win probability : " + playerTwoWinProbability);
            if (playerOneWinProbability > playerTwoWinProbability)
            {
                Console.WriteLine($"Winner is: Player {playerOne.Competing.id}");
                Winner = playerOne.Competing;
                Loser = playerTwo.Competing;
            }
            else
            {
                Console.WriteLine($"Winner is: Player {playerTwo.Competing.id}");
                Winner = playerTwo.Competing;
                Loser = playerOne.Competing;
            }
        }
    }
}
