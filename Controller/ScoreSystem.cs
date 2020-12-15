using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class ScoreSystem
    {
        int matchBonus = 1;
        int handSideBonus = 2;
        int highExperienceBonus = 3;
        int surfaceBonus = 4;


        public int addPointToPlayer(Player player, Player oppositeplayer)
        {
            int playerPoint = 0;
            playerPoint += matchBonus;
            if (player.hand == "left") playerPoint += handSideBonus;
            if (player.experience > oppositeplayer.experience) playerPoint += highExperienceBonus;

            return playerPoint;
        }
    }
}
