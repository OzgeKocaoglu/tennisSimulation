using System;

namespace tennisSimulation
{
    class Program
    {

        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.CreateNewGame();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            
        }
    }
}

