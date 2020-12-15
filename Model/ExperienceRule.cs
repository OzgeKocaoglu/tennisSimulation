using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class ExperienceRule : IRule
    {
        public string name { get; set; }
        public int bonus { get; set; }

        public ExperienceRule(string name, int bonus)
        {
            this.name = name;
            this.bonus = bonus;
        }

        public int applyRule(Player playerOne, Player playerTwo, int playerOneScore)
        {
            if (playerOne.experience > playerTwo.experience) playerOneScore += this.bonus;
            return playerOneScore;
        }
    }
}
