

namespace Tennis_Simulation
{
    public enum TournamentTypes
    {
        elimination,
        league
    }

    class Tournament
    {
        private int _id;
        private string _surface;
        private string _type = TournamentTypes.elimination.ToString();

        public int id { get; set; }
        public string surface { get; set; }
        public string type { get; set; }
    }
}
