using System;
using System.Collections.Generic;

namespace Tennis_Simulation
{
    static class ListUtils
    {
        public static List<List<T>> splitList<T>(List<T> locations, int nSize = 2)
        {
            var list = new List<List<T>>();

            for (int i = 0; i < locations.Count; i += nSize)
            {
                list.Add(locations.GetRange(i, Math.Min(nSize, locations.Count - i)));
            }

            return list;
        }
        public static List<List<Player>> SettingUpPlayerList(List<Player> players)
        {
            if ((players.Count % 2) != 0)
            {
                Console.WriteLine("Player number is not valid. So we decided to remove last player from the list.");
                players.RemoveAt(players.Count - 1);
            }
            List<List<Player>> dividedPlayers = ListUtils.splitList(players, 2);
            return dividedPlayers;
        }
    }


}
