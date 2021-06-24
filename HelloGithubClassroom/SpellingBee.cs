using System;
using System.Collections.Generic;
using System.Linq;
using WeCantSpell.Hunspell;

namespace HelloGithubClassroom
{
    public class SpellingBee
    {
        public static Random random = new Random();
        public static List<char> RandomString(int length)
        {
            HashSet<char> randomLetters = new HashSet<char>();
            string chars = "bcdfghjklmnpqrstvw";
            string chars2 = "aiouy";
            randomLetters.Add('e');
            while (randomLetters.Count < 7)
            {
                randomLetters.Add(chars[random.Next(18)]);
                if (randomLetters.Count == 7)
                {
                    break;
                }
                randomLetters.Add(chars2[random.Next(5)]);
            }
            return randomLetters.ToList();
        }

        public static int WordChecker()
        {
            return 1;
        }

        /*public static void Main(string[] args)
        {
            var dictionary = WordList.CreateFromFiles(@"English (British).dic");
            List<String> wordsEntered = new List<String>();
            List<char> lettersToUse = SpellingBee.RandomString(7);
            foreach (var hello in lettersToUse) { Console.WriteLine("LETTER " + hello); }
            int score = 0;
            char mustUseLetter = lettersToUse[random.Next(7)];
            Console.WriteLine("YOU MUST USE: " + mustUseLetter);

            while (true)
            {
                int checker = 1;
                Console.WriteLine("ENTER A WORD -------------");
                var wordGuess = Console.ReadLine();
                if (!wordsEntered.Contains(wordGuess) && wordGuess.Length > 3 && wordGuess.Contains(mustUseLetter))
                {
                    foreach (char letter in wordGuess)
                    {
                        if (lettersToUse.Contains(letter))
                        {
                            checker++;
                        }
                    }

                    Console.WriteLine("Checker " + checker);
                    if (checker >= wordGuess.Length)
                    {
                        bool ok = dictionary.Check(wordGuess);
                        if (ok)
                        {
                            wordsEntered.Add(wordGuess);
                            score++;
                        }
                        Console.WriteLine("This word is not in the dictionary " + ok);
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }

                    if (wordGuess.Equals("EXIT"))
                    {
                        Console.WriteLine("FINAL SCORE " + score);
                        break;
                    }
                }
            }
            // check if word is in the dictionary that they enter and it matches the letters.

        }*/
    }
}
