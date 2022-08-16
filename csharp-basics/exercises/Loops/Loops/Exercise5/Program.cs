using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word :: ");
            string word1 = Console.ReadLine();

            Console.Write("\nEnter second word :: ");
            string word2 = Console.ReadLine();

            Console.WriteLine($"\n{word1}{new string('.' , 30 - word1.Length - word2.Length)}{word2}");
            Console.ReadKey();
        }
    }
}
