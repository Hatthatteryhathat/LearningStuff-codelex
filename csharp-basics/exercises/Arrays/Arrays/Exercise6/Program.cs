using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            Random randomNumberGen = new Random();

            for (int i = 0; i < array1.Length; i++) 
            {
                array1[i] = randomNumberGen.Next(1, 100);
            }

            Array.Copy(array1 , array2 , 10);
            array1[array1.Length -1] = -7;

            Console.WriteLine(String.Join(", ", array1));
            Console.WriteLine(String.Join(", ", array2));
            Console.ReadKey();
        }
    }
}
