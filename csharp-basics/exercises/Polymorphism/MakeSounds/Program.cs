using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> noizyThings = new List<ISound>()
            {
                new Firework(),
                new Parrot(),
                new Radio(),
            };

            foreach (var noizeMaker in noizyThings) 
            {
                noizeMaker.PlaySound();
            }

            Console.ReadKey();
        }
    }
}