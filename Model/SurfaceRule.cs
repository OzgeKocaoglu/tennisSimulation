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
            throw new NotImplementedException();
        }

        
    }
}
