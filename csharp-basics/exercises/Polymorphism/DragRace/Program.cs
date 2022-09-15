using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cars = new List<ICar>();

            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Mercedes());
            cars.Add(new VV());
            cars.Add(new Tesla());

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    car.SpeedUp();

                    if (i == 3 && car is IBoost boost)
                    {
                        boost.UseNitrousOxideEngine();
                    }
                }
            }

            ICar fastestCar = cars[0];

            foreach (var car in cars) 
            {
                if (Int32.Parse(car.ShowCurrentSpeed()) > Int32.Parse(fastestCar.ShowCurrentSpeed())) 
                {
                    fastestCar = car;
                }
            }

            Console.WriteLine($"Fastest car is : {fastestCar.GetType().ToString().Substring(9)}");
            Console.WriteLine($"With the speed of : {fastestCar.ShowCurrentSpeed()} km/h");
            Console.ReadKey();
        }
    }
}