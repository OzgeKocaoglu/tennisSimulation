  

using System.Collections.Generic;

namespace Tennis_Simulation
{
    class Tournament
    {
        public Tournament(int id, string surface, string type)
        {
            this.id = id;
            this.surface = surface;
            this.type = type;
        }

        /// <summary>
        /// Represents one tournament at all tournaments
        /// </summary>
        public int id { get; set; }
        public string surface { get; set; }
        public string type { get; set; }
       
    }
}
