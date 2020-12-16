using System.Collections.Generic;

namespace Tennis_Simulation
{
    /// <summary>
    /// DataModel from input JSON file.
    /// </summary>
    class DataModel
    {
        public List<Tournament> tournaments { get; set; }
        public List<Player> players { get; set; }
    }
}
