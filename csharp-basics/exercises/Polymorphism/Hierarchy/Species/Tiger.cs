﻿using System;
using Hierarchy.FoodTypes;

namespace Hierarchy.Species
{
    internal class Tiger : Feline
    {
        private string _animalType;
        private string _animalName;
        private double _weight;
        private string _livingRegion;
        private int _foodEaten;

        public Tiger(string animalType, string animalName, string weight, string livingRegion)
        {
            _animalType = animalType;
            _animalName = animalName;
            _weight = double.Parse(weight);
            _livingRegion = livingRegion;
            _foodEaten = 0;
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                _foodEaten += food.FoodQuantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} is not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("> Grrrr... ");
        }

        public override string AnimalType => _animalType;

        public override string Name => _animalName;

        public override double Weight => _weight;

        public override string LivingRegion => _livingRegion;

        public override int FoodEaten => _foodEaten;
    }
}
