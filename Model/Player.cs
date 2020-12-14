using Newtonsoft.Json;

namespace Tennis_Simulation
{
    public enum PlayerHand
    {
        right,
        left
    };
    class Player
    {
        /// <summary>
        /// Represents one player of all game.
        /// </summary>
        #region Getter/Setters
        public int id { get; set; }
        public string hand { get; set; }
        public int experience { get; set; }
        public PlayerSkills skills { get; set; }
        #endregion

        public Player()
        {

        }
    }
}
