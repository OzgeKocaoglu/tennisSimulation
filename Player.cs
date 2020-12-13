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
        #region Variables
        private int _id;
        private string playerHand = PlayerHand.right.ToString();
        private int _experience = 0;
        private PlayerSkills playerSkills;
        #endregion
        #region Getter/Setters
        public int id { get; set; }
        public string hand { get; set; }
        public int experience { get; set; }
        public PlayerSkills skills { get; set; }
        #endregion

        public Player()
        {

        }

        public Player(int _id, string _hand, int _experience)
        {
            this._id = _id;
            playerHand = _hand;
            this._experience = _experience;
            playerSkills = new PlayerSkills();
        }
    }
}
