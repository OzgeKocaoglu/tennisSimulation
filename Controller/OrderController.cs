using System;
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
            for (int i=0; i< players.Count; i++)
            {

                  int totalExperience = players[i].gainedExperience - players[i].experience;
                  Order order = new Order(i + 1, players[i].id, players[i].gainedExperience, totalExperience);
                  orders.Add(order);
            }
            Console.WriteLine("-------------------Order players------------------\n");
            SortPlayerList(orders);
            for (int i = 0; i < orders.Count; i++)
                Console.WriteLine($"{orders[i].id}. => Player {orders[i].player_id} Experience => {orders[i].total_experience}");
            return orders;
        }

        private void SortPlayerList(List<Order> orders)
        {
            orders.Sort(
              delegate (Order order1, Order order2)
                  {
                      return order1.CompareTo(order2);
                  }
              );
            for(int i=0; i<orders.Count; i++)
            {
                orders[i].id = i;
            }
        }

    }
}
