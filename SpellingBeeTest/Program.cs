using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeCantSpell.Hunspell;
using SpellingBeeGame;

namespace SpellingBeeTest
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void PartOne()
        {
            List<char> a = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g'};
            List<char> b = SpellingBeeModel.MustUseLetter2(a);
            Console.WriteLine(a.Count);
            Console.WriteLine(b.Count);
            foreach (var c in b)
            {
                Console.WriteLine(c);
            }
        }
        [TestMethod]
        public void PartTwo()
        {
            List<char> a = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Assert.AreEqual(7, SpellingBeeModel.WordChecker(a, "cabbage"));
        }

        [TestMethod]
        public void WordTooShort()
        {
            List<char> a = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Assert.AreEqual(0, SpellingBeeModel.WordChecker(a, "cab"));
        }
        [TestMethod]
        public void WithoutMainLetter()
        {
            List<char> a = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Assert.AreEqual(0, SpellingBeeModel.WordChecker(a, "fade"));
        }
    }
}
