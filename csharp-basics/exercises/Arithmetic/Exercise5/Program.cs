using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGen = new Random();
            int random1To100 = randomNumberGen.Next(1, 100);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            string usersGuess = Console.ReadLine();

            if (random1To100 == Int32.Parse(usersGuess))
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too {(random1To100 < Int32.Parse(usersGuess) ? "high" : "low")}." +
                    $"  I was thinking of {random1To100}.");
            }
            
            Console.ReadKey();
        }
    }
}
