using System;
using System.Text.RegularExpressions;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].Replace("ea", "*");
            }

            Console.WriteLine(String.Join(", ", words));
            Console.ReadKey();
        }
    }
}
