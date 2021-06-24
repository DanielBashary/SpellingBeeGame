using System;
using System.Collections.Generic;
using System.Linq;
using WeCantSpell.Hunspell;

namespace SpellingBeeGame
{
    public class SpellingBeeModel
    {
        public static Random random = new Random();
        public static List<char> WordList(int length)
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
            return MustUseLetter2(randomLetters.ToList());
        }

        public static List<char> MustUseLetter2(List<char> letterList)
        {
            int mustUseIndex = random.Next(7);
            char mustUseLetter = letterList[mustUseIndex];
            letterList.RemoveAt(mustUseIndex);
            letterList.Add(mustUseLetter);
            return letterList;
        }


        public static int WordChecker(List<char> lettersToUse, String wordGuess)
        {
            var dictionary = WeCantSpell.Hunspell.WordList.CreateFromFiles(@"C:\Users\Daniel Bashary\source\repos\07-spelling-bee-final-version-basharyd\SpellingBeeGame\bin\Debug\English (British).dic");
            List<String> wordsEntered = new List<String>();
            int score = 0;
            int checker = 1;
                if (!wordsEntered.Contains(wordGuess) && wordGuess.Length > 3 && wordGuess.Contains(lettersToUse[6]))
                {
                    foreach (char letter in wordGuess)
                    {
                        if (lettersToUse.Contains(letter))
                        {
                            checker++;
                        }
                    }
                    if (checker >= wordGuess.Length)
                    {
                        bool ok = dictionary.Check(wordGuess);
                        if (ok)
                        {
                            wordsEntered.Add(wordGuess);
                            score = wordGuess.Length;
                        }
                    }
                }
                return score;
        }
    }
}