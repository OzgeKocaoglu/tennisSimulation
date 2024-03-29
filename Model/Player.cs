﻿
namespace Tennis_Simulation
{
    /// <summary>
    /// Represents one player of all game.
    /// </summary>
    class Player
    {
        #region Variables
        public int id { get; set; }
        public string hand { get; set; }
        public int experience { get; set; }
        public int gainedExperience { get; set; }
        public PlayerSkills skills { get; set; }
        #endregion

        public Player() { }
    }
}
