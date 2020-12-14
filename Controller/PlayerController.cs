using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class PlayerController
    {
        List<Player> players;
        public PlayerController(DataModel dataModel)
        {
            players = dataModel.players;
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

    }
}
