using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes = InputMinutes();
            int minutesInYear = 525948;
            int minutesInDay = 1440;
            int years = minutes / minutesInYear;
            int days = minutes / minutesInDay;
            int remainingMinutes = (minutes - (minutesInYear * years)) / minutesInDay;

            Console.WriteLine($"1) {minutes} minutes is {years} years AND {remainingMinutes} days!");
            Console.WriteLine($"2) {minutes} minutes is {days} days!");
            Console.ReadKey();
        }

        static int InputMinutes() 
        {
            int amountOfMinutes;

            Console.WriteLine("Please input amount of minutes:: ");
            while (!int.TryParse(Console.ReadLine(), out amountOfMinutes)) 
            {
                Console.Clear();
                Console.WriteLine("Input a valid amount of minutes!");
                Console.WriteLine("Please input amount of minutes:: ");
            }
            return amountOfMinutes;
        }
    }
}
