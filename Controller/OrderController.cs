using System.Collections.Generic;


namespace Tennis_Simulation.Controller
{
    class OrderController
    {
        List<Order> orders;

        public OrderController()
        {
            orders = new List<Order>();
        }

        public List<Order> OrderPlayers(List<Player> players)
        {
            return orders;
        }

    }
}
