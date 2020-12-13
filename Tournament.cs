

using System.Collections.Generic;

namespace Tennis_Simulation
{
    class Tournament
    {
        /// <summary>
        /// Represents one tournament at all tournaments
        /// </summary>
        public int _id { get; set; }
        public string surface { get; set; }
        public string type { get; set; }
        public List<List<Matchup>> Sets { get; set; } = new List<List<Matchup>>();
    }
}
