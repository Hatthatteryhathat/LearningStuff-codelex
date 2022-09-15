using System;
using System.Collections.Generic;

namespace Hierarchy_TDD
{
    class Program
    {
        public void Main()
        {
            var animals = new List<Animal>();
            while (true)
            {
                Console.WriteLine(">> Input guide - {AnimalType} {AnimalName} {Weight} {Region} {Catbreed- ifCat}<<\n");
                var input = Console.ReadLine();

                if (input == "End" || input == "end")
                {
                    break;
                }
                else
                {
                    var inputArr = input?.Split(' ');
                    Animal currentAnimal = AnimalIdentifyer.IdentifyAnimal(inputArr);
                    animals.Add(currentAnimal);
                    currentAnimal.MakeSound();

                    var chosenFood = Console.ReadLine()?.Split(" ");
                    FeedAnimal.Feed(currentAnimal, chosenFood);

                    Console.WriteLine(currentAnimal);
                    Console.WriteLine("-----------------");
                }
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadKey();
        }
    }
}