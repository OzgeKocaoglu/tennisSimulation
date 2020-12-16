using System;

namespace Tennis_Simulation
{
    class SurfaceRule : IRule
    {
        public string name { get; set; }
        public int bonus { get; set; }
        public string surfaceType;

        public SurfaceRule(string name, int bonus, string type)
        {
            this.name = name;
            this.bonus = bonus;
            surfaceType = type;
        }
        public int applyRule(Player playerOne, Player playerTwo, int playerOneScore)
        {
            if (surfaceType.Contains("clay"))
            {
                if(playerOne.skills.clay > playerTwo.skills.clay)
                {
                    playerOneScore += this.bonus;
                    Console.WriteLine($"Surface bonus added to player {playerOne.id}. Current point is: {playerOneScore}");
                    return playerOneScore;
                }
            }
            else if (surfaceType.Contains("grass"))
            {
                if (playerOne.skills.grass > playerTwo.skills.grass)
                {
                    playerOneScore += this.bonus;
                    Console.WriteLine($"Surface bonus added to player {playerOne.id}. Current point is: {playerOneScore}");
                    return playerOneScore;
                }
            }
            else if (surfaceType.Contains("hard"))
            {
                if (playerOne.skills.hard > playerTwo.skills.hard)
                {
                    playerOneScore += this.bonus;
                    Console.WriteLine($"Surface bonus added to player {playerOne.id}. Current point is: {playerOneScore}");
                    return playerOneScore;
                }
            }

            return playerOneScore;
        }

    }
}
