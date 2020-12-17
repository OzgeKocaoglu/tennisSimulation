using System.Collections.Generic;

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
