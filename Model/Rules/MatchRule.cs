using System;

namespace Tennis_Simulation
{
    class MatchRule : IRule
    {
        public string name { get; set; }
        public int bonus { get; set; }

        public MatchRule(string name, int bonus)
        {
            this.name = name;
            this.bonus = bonus;
        }
        public int applyRule(Player playerOne, Player playerTwo, int playerOneScore)
        {
           playerOneScore += this.bonus;
           Console.WriteLine($"Matching bonus added to player {playerOne.id}. Current point is: {playerOneScore}");
            return playerOneScore;
        }
    }
}
