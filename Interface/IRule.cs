namespace Tennis_Simulation
{
    interface IRule
    {
        string name { get; set; }
        int bonus { get; set; }
        int applyRule(Player playerOne, Player playerTwo, int playerOneScore);
    }
}
