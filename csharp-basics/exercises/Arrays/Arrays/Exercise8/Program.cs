using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>();
            words.Add("codelex");
            words.Add("rainbow");
            words.Add("ellectric");
            words.Add("kettle");
            words.Add("chimney");

            Random random = new Random();
            string chosenWord = words[random.Next(0,words.Count)];

            string underLines = new string('_', chosenWord.Length);
            char[] wordToGuess = underLines.ToCharArray();
            bool isGuessWrong;
            string wrongLetters = "";
            int numberOfAttempts = 8;

            while (true) 
            {
                DisplayInfo(wordToGuess, wrongLetters);
                char guessedLetter = Console.ReadKey().KeyChar;
                isGuessWrong = true;

                for (int i = 0; i < wordToGuess.Length; i++) 
                {
                    if (guessedLetter == chosenWord[i]) 
                    {
                        wordToGuess[i] = guessedLetter;
                        isGuessWrong = false;
                    }
                }

                if (isGuessWrong) 
                {
                    wrongLetters += guessedLetter;
                }

                if (!wordToGuess.Contains('_')) 
                {
                    DisplayInfo(wordToGuess, wrongLetters);
                    Console.WriteLine("You won!!");
                    break;
                }

                numberOfAttempts--;

                if (numberOfAttempts == 0) 
                {
                    DisplayInfo(wordToGuess, wrongLetters);
                    Console.WriteLine("You ran out of attempts!!");
                    break;
                }
            }
            
            Console.ReadKey();
        }

        public static void DisplayInfo(char[] wordToGuess, string wrongLetters) 
        {
            Console.Clear();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"Word   ::  {string.Join(" ", wordToGuess)}");
            Console.WriteLine($"Misses ::  {wrongLetters}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("\nGuess ::");
        }
    }
}
