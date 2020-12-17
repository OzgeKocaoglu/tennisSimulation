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


        public List<Order> OrderPlayers(List<Player> tournamentResultPlayers, List<Player> players)
        {

            //SortPlayerList(tournamentResultPlayers, players);
            Console.WriteLine("-------------------Sorted players------------------\n");
            for (int i=0; i<tournamentResultPlayers.Count; i++)
            {
                Player playerTemp = players.Find(
                    delegate (Player player)
                    {
                        return player.id == tournamentResultPlayers[i].id;
                    }
                );
                int gainedExperience = tournamentResultPlayers[i].experience - playerTemp.experience;
                Order order = new Order(i + 1, tournamentResultPlayers[i].id, gainedExperience, tournamentResultPlayers[i].experience);
                orders.Add(order);
            }
            return orders;
        }



        /*private void SortPlayerList(List<Player> tournamentResultPlayers, List<Player> players)
        {
            tournamentResultPlayers.Sort(
              delegate (Player player1, Player player2)
              {
                  int compareExperience = player1.experience.CompareTo(player2.experience);
                  Console.WriteLine("compare experience: " + compareExperience);
                  if (compareExperience == 0)
                  {
                      Console.WriteLine("Compared experience equal");
                      Player playerOne = players.Find(
                          delegate (Player player)
                          {
                              return player.id == player1.id;
                          }
                     );
                      Player playerTwo = players.Find(
                          delegate (Player player)
                          {
                              return player.id == player2.id;
                          }
                     );
                      Console.WriteLine($"First experience is:\n Player one {playerOne.experience} \n Player two {playerTwo.experience}");
                      return playerOne.experience.CompareTo(playerTwo.experience);
                  }
                  return compareExperience;
              }

              );
        }*/

    }
}
