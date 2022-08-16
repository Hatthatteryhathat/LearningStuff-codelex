using System;

namespace Exercise2
{
    class Program
    {       
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            int[] array = new int[maxNumber - minNumber + 1];
            int counter = minNumber;
            var sum = 0;

            for (int i=0; i < (maxNumber - minNumber + 1); i++) 
            {
                sum += counter;
                array[i] = counter++;
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
