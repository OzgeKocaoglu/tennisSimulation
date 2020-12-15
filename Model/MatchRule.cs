using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return playerOneScore + this.bonus;
        }
    }
}
