using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = InputNumber("meters");
            int hours = InputNumber("hours");
            int minutes = InputNumber("minutes");
            int seconds = InputNumber("seconds");

            int kilometers = meters / 1000;
            double miles = (double)meters / 1609.344;
            int totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            double totalHours = hours + ((double)minutes / 60) + ((double)seconds / 3600);
            double speedMetersPerSecond = Math.Round((double)meters / (double)totalSeconds, 8);
            double speedKilometersPerHour = Math.Round((double)kilometers / (double)totalHours, 8);
            double speedMilesPerHour = Math.Round(miles / totalHours, 8);

            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine($"Your speed in m/s is  {speedMetersPerSecond}");
            Console.WriteLine($"Your speed in Km/h is  {speedKilometersPerHour}");
            Console.WriteLine($"Your speed in Miles/h is  {speedMilesPerHour}");
            Console.ReadKey();
        }

        static int InputNumber(string requiredInput) 
        {
            int inputValue;

            Console.Write($"Please input {requiredInput} :: ");
            while (!int.TryParse(Console.ReadLine(),out inputValue)) 
            {
                Console.WriteLine("Invalid input!");
                Console.Write($"Please input {requiredInput} :: ");
            }
            return inputValue;
        }
    }
}
