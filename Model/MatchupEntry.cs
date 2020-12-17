namespace Tennis_Simulation
{
    /// <summary>
    /// Represents one player int the matchup
    /// </summary>
    class MatchupEntry
    {
        public Player Competing { get; set; }
        public double Score { get; set; }

        public MatchupEntry() { }
    }
}
