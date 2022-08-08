using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int countPositive = 0;
            int sumNegative = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > 0)
                {
                    countPositive++;
                }
                else 
                {
                    sumNegative += array[i];
                }
            }

            Console.WriteLine($"Positive numbers : {countPositive}");
            Console.WriteLine($"Sum of negative numbers : {sumNegative}");
            Console.ReadKey();
        }
    }
}
