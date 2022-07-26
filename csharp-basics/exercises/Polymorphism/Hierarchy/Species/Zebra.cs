﻿using System;
using Hierarchy.FoodTypes;

namespace Hierarchy.Species
{
    internal class Zebra : Mammal
    {
        private string _animalType;
        private string _animalName;
        private double _weight;
        private string _livingRegion;
        private int _foodEaten;

        public Zebra(string animalType, string animalName, string weight, string livingRegion)
        {
            _animalType = animalType;
            _animalName = animalName;
            _weight = double.Parse(weight);
            _livingRegion = livingRegion;
            _foodEaten = 0;
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                _foodEaten += food.FoodQuantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("> *Zebra noizess*");
        }

        public override string AnimalType => _animalType;

        public override string Name => _animalName;

        public override double Weight => _weight;

        public override string LivingRegion => _livingRegion;

        public override int FoodEaten => _foodEaten;
    }
}
