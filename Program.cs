using System;

namespace Tennis_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.CreateNewGame();
            Console.ReadLine();
        }
    }
}
