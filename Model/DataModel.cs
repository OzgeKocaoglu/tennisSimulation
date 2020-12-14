using System.Collections.Generic;

namespace Tennis_Simulation
{
    class DataModel
    {
        /// <summary>
        /// DataModel from JSON file.
        /// </summary>
        public List<Tournament> tournaments { get; set; }
        public List<Player> players { get; set; }
    }
}
