using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    public enum Hand
    {
        right,
        left
    };
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    class Player
    {
        #region Variables
            private int _id;
            private string playerHand = Hand.right.ToString();
            private int _experience = 0;
            private PlayerSkills playerSkills;
        #endregion
         
        #region Getter/Setters
            [JsonProperty(PropertyName ="id")]
            public int id { get; set; }
            [JsonProperty(PropertyName = "hand")]
            public string hand { get; set; }
            [JsonProperty(PropertyName = "experience")]
            public int experience { get; set; }
            [JsonProperty(PropertyName = "skills")]
            public PlayerSkills skills { get; set; }
        #endregion

        public Player(string _hand, int _experience)
        {
            _id = ++GlobalVariables.PLAYER_COUNT;
            playerHand = _hand;
            this._experience = _experience;
            playerSkills = new PlayerSkills();
        }
        public Player(int _id, string _hand, int _experience)
        {
            this._id = _id;
            playerHand = _hand;
            this._experience = _experience;
            playerSkills = new PlayerSkills();
        }

        public Player()
        {
        }
    }
}
