using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Using for:: ");

            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i] + " ");
            }

            Console.WriteLine("\n-=-=-=-=-");
            Console.WriteLine("Using foreach:: ");

            foreach (char ch in vowels) 
            {
                Console.Write(ch + " ");
            }

            Console.ReadKey();
        }
    }
}
