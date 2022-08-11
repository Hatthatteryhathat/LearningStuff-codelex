using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RollTwoDice diceGame = new RollTwoDice();

            diceGame.DiceGame();

            Console.ReadKey();
        }
    }
}
