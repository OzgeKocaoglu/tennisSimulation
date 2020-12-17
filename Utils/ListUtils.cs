using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
            List<List<Player>> dividedPlayers = splitList(players, 2);
            return dividedPlayers;
        }

        #region Random Suffle Functions
        public static void Shuffle<T>(this IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        #endregion
    }


}
