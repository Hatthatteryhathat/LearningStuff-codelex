using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }

            average = sum / (double)upperBound;
            Console.WriteLine("Sum is :: " + sum);
            Console.WriteLine("Average :: " + average);
            Console.ReadKey();
        }
    }
}
