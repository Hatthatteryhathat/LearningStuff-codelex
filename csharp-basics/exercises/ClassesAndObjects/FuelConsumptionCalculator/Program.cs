using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        public static double currentOdoValue;
        public static double litersSpent;
        public static bool isRunTest = true;

        private static void Main(string[] args)
        {
            if (isRunTest)
            {
                Test();
            }

            Console.Write("Enter initial odometer reading : ");
            currentOdoValue = double.Parse(Console.ReadLine());
            Car car = new Car(currentOdoValue);
            Console.WriteLine("-=-=-=-=-=-=-=-=-");
            Console.WriteLine(">> Filling up at the gas station! <<");

            while (true)
            {
                Console.WriteLine(" | 1. FillUp");
                Console.WriteLine(" | 2. Display");
                Console.Write("\nChoose action : ");

                switch ((int)char.GetNumericValue(Console.ReadKey().KeyChar))
                {
                    case 1:
                        FillUp(car);
                        break;

                    case 2:
                        Console.WriteLine($"\nConsumption of 'km per liter' is :: " +
                            $"{Math.Round(car.CalculateConsumption() , 2)}km");

                        if (car.GasHog())
                        {
                            Console.WriteLine("Fuel usage: Gas Hog");
                        }
                        else if (car.EconomyCar())
                        {
                            Console.WriteLine("Fuel usage: Economy Car");
                        }
                        else 
                        { 
                            Console.WriteLine("Fuel usage: Average");
                        }

                        break;
                }

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");
            }
        }

        public static void FillUp(Car car)
        {
            Console.Write("\nEnter current odometer reading: ");
            currentOdoValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter liters spent since last FillUp : ");
            litersSpent = Convert.ToInt32(Console.ReadLine());
            car.FillUp(currentOdoValue, litersSpent);
        }

        public static void Test()
        {
            double initialKm = 0;
            Car testCar = new Car(initialKm);

            testCar.FillUp(100 , 5);
            Console.WriteLine($" Consumption km per 1 liter :: " +
                $"{Math.Round(testCar.CalculateConsumption(), 2)}");

            testCar.FillUp(157, 12);
            Console.WriteLine($" Consumption km per 1 liter :: " +
                $"{Math.Round(testCar.CalculateConsumption(), 2)}");

            testCar.FillUp(402, 57);
            Console.WriteLine($" Consumption km per 1 liter :: " +
                $"{Math.Round(testCar.CalculateConsumption(), 2)}");

            Console.WriteLine("Test done, bye!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
