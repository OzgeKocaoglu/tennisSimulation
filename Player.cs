using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    class Player
    {
        #region Variables
        public enum Hand
        {
            right,
            left
        };
        private string id;
        private Hand playerHand = Hand.right;
        private int experience = 0;
        private PlayerSkills playerSkills;
        #endregion
        #region Getter/Setters
        internal string ID { get => id;  private set => id = value; }
        internal int Experience { get => experience; set => experience = value; }
        internal Hand PlayerHand { get => playerHand; set => playerHand = value; }
        internal PlayerSkills PlayerSkills { get => playerSkills; set => playerSkills = value; }
        #endregion
        public Player(Hand _hand, int _experience)
        {
            id = (++GlobalVariables.PLAYER_COUNT).ToString();
            playerHand = _hand;
            experience = _experience;
            playerSkills = new PlayerSkills();
        }
        public Player(string _id, Hand _hand, int _experience)
        {
            id = _id;
            playerHand = _hand;
            experience = _experience;
            playerSkills = new PlayerSkills();
        }

    }
}
