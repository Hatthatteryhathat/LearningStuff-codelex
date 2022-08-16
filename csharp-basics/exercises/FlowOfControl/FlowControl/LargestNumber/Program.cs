using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int input1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            int input2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            int input3 = Int32.Parse(Console.ReadLine());

            int[] arr = new int[] { input1, input2, input3 };
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine(string.Join(", ", arr));

            Console.ReadKey();
        }
    }
}
