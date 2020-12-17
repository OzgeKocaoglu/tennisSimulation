using System;

namespace Tennis_Simulation
{
    class Order: IComparable<Order>
    {
        #region Variables
        public int id { get; set; }
        public int player_id { get; set; }
        public int gained_experience { get; set; }
        public int total_experience { get; set; }
        #endregion

        public Order(int id, int playerId, int gainedExperience, int totalExperience)
        {
            this.id = id;
            player_id = playerId;
            gained_experience = gainedExperience;
            total_experience = totalExperience;
        }

        #region Utility Methods
        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            if (this.total_experience > other.total_experience) return -1;
            if (this.total_experience < other.total_experience) return 1;
            if(this.total_experience == other.total_experience)
            {
                if ((this.total_experience - this.gained_experience) > (other.total_experience - other.gained_experience)) return -1;
            }
            return 0;
        }
        #endregion
    }
}
