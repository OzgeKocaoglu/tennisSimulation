
namespace Tennis_Simulation
{
    /// <summary>
    /// Represents one tournament at all tournaments
    /// </summary>
    class Tournament
    {
        public int id { get; set; }
        public string surface { get; set; }
        public string type { get; set; }

        public Tournament(int id, string surface, string type)
        {
            this.id = id;
            this.surface = surface;
            this.type = type;
        }
       
    }
}
