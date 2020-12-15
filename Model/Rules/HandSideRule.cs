using System;

namespace Tennis_Simulation
{
    class HandSideRule : IRule
    {
        public string name { get; set; }
        public int bonus { get; set; }

        public HandSideRule(string name, int bonus)
        {
            this.name = name;
            this.bonus = bonus;
        }

        public int applyRule(Player playerOne, Player playerTwo, int playerOneScore)
        {
            if (playerOne.hand == "left")
            {
                playerOneScore += bonus;
                Console.WriteLine($"Left hand bonus added to player {playerOne.id}. Current point is: {playerOneScore}");
            }

            return playerOneScore;
        }
    }
}

