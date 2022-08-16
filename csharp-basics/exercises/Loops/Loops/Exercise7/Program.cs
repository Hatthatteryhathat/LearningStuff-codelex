using System;

namespace Exercise7
{
    internal class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Random rnd = new Random();
            int currentRoll = 0;
            int score = 0;

            while (true) 
            {
                currentRoll = rnd.Next(1, 7);
                score += currentRoll;
                Console.WriteLine($"You rolled a {currentRoll} !");
                
                if (currentRoll == 1) 
                {
                    Console.WriteLine("\n-------\nYou got 0 points.");
                    break;
                }

                Console.Write("Roll again? y/n  :: ");

                if (Console.ReadKey().KeyChar == 'n') 
                {
                    Console.WriteLine($"\n-------\nYou got {score} points.");
                    break;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
