using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            var uniqueValues = new List<string>();
            var groups = 
                from words in values 
                group words by words;

            foreach (var group in groups) 
            {
                if (group.Count() == 1)
                { 
                    uniqueValues.Add(group.Key);
                }
            }

            Console.WriteLine("All values    : " + String.Join(", ", values));
            Console.WriteLine("Unique values : " + String.Join(", ", uniqueValues));
            Console.ReadKey();
        }
    }
}
