using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Happy Birthday";
            string text2 = "MANY THANKS";
            string text3 = "sPoNtAnEoUs";

            Console.WriteLine(ReverseCase(text1));
            Console.WriteLine(ReverseCase(text2));
            Console.WriteLine(ReverseCase(text3));
            Console.ReadKey();
        }

        public static string ReverseCase(string text) 
        {
            char[] letters = text.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsUpper(letters[i])) 
                {
                    letters[i] = char.ToLower(letters[i]);
                }
                else 
                { 
                    letters[i] = char.ToUpper(letters[i]);
                }
            }

            return string.Join("", letters);
        }
    }
}
