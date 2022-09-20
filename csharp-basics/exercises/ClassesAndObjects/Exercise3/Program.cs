using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter initial mileage : ");
            double initialMileage = double.Parse(Console.ReadLine());
            Odometer odometer = new Odometer(initialMileage);

            Console.Write("Enter add fuel : ");
            double initialFuel = double.Parse(Console.ReadLine());
            FuelGauge gauge = new FuelGauge();

            for (int i = 0; i < initialFuel; i++) 
            {
                gauge.AddFuel();
            }

            while (gauge.GetFuel() > 0) 
            {
                Console.WriteLine($"Current mileage : {odometer.GetMileage()} || Current fuel : {gauge.GetFuel()}");
                odometer.AddMileage(gauge);
            }

            Console.ReadKey();
        }
    }
}
