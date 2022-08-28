using System;
using System.Collections.Generic;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingredient strawberries = new Ingredient("Strawberry", 1.50);
            Ingredient banana = new Ingredient("Banana", 0.50);
            Ingredient mango = new Ingredient("Mango", 2.50);
            Ingredient blueberries = new Ingredient("Blueberry", 1);
            Ingredient raspberries = new Ingredient("Raspberry", 1);
            Ingredient apple = new Ingredient("Apple", 1.75);
            Ingredient pineapple = new Ingredient("Pineapple", 3.50);

            CreateSmoothie(new Ingredient[] { banana });
            CreateSmoothie(new Ingredient[]{ raspberries, strawberries, blueberries });

            Console.ReadKey();
        }

        public static void CreateSmoothie(Ingredient[] ingredients) 
        {
            Smoothie smoothie = new Smoothie(ingredients);
            Console.WriteLine($"Smoothie ingredients :: {string.Join(", ", smoothie.Ingredients)}");
            Console.WriteLine($"Cost :${string.Format("{0:0.00}" , smoothie.GetCost())}");
            Console.WriteLine($"Price :${string.Format("{0:0.00}", smoothie.GetPrice())}");
            Console.WriteLine($"Smoothie name :: {smoothie.GetName()}");
            Console.WriteLine("-=-=-=-=-=-==-=-=-=-");
        }
    }
}
