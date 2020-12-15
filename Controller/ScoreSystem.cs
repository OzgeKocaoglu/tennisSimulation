using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class ScoreSystem
    {
        #region Variables
        List<IRule> rules = new List<IRule>();
        int playerPoint = 0;
        string tournamentSurface;
        Player player;
        Player oppositePlayer;
        #endregion

        public ScoreSystem(Player playerOne, Player playerTwo, string type)
        {
            player = playerOne;
            oppositePlayer = playerTwo;
            tournamentSurface = type;
            CreateRules();
        }

        public int addPointToPlayer()
        {
            for(int i=0; i<rules.Count; i++)
            {
                playerPoint = rules[i].applyRule(player, oppositePlayer, playerPoint);
            }
            return playerPoint;
        }

        private void CreateRules()
        {
            rules.Add(new MatchRule("matchRule", 1));
            rules.Add(new HandSideRule("handSideRule", 2));
            rules.Add(new ExperienceRule("experienceRule", 3));
            rules.Add(new SurfaceRule("surfaceRule", 4, tournamentSurface));

        }
    }
}
