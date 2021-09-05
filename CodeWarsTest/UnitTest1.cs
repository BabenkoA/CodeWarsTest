using NUnit.Framework;
using Code_Wars;
using System.Collections.Generic;
using System;

namespace CodeWarsTest
{
    public class Tests
    {
        private readonly IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private PagnationHelper<int> helper;

        [SetUp]
        public void SetUp()
        {
            helper = new PagnationHelper<int>(collection, 10);
        }

        [Test]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = 10)]
        [TestCase(3, ExpectedResult = -1)]
        public int PageItemCountTest(int pageIndex)
        {
            return helper.PageItemCount(pageIndex);
        }

        [Test]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(12, ExpectedResult = 1)]
        [TestCase(10, ExpectedResult = 1)]
        [TestCase(20, ExpectedResult = 2)]
        public int PageIndexTest(int itemIndex)
        {
            return helper.PageIndex(itemIndex);
        }

        [Test]
        public void ItemCountTest()
        {
            Assert.AreEqual(24, helper.ItemCount);
        }

        [Test]
        public void PageCountTest()
        {
            Assert.AreEqual(3, helper.PageCount);
        }

        [Test]
        public void SampleTest()
        {
            //Assert.AreEqual(new List<string> { "a" }, Kata.Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Kata.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }

        [Test]
        public void DeleteOccTest() 
        {
            Assert.AreEqual(new int[] { 1, 1, 3, 3, 7, 2, 2, 2 }, Kata.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3));
        }


    }


    [TestFixture]
    public static class KataTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void test()
        {
            Console.WriteLine("Fixed Tests");
            testing(Kata.EgyptianFraction("3", "4"), "[1/2, 1/4]");
            testing(Kata.EgyptianFraction("12", "4"), "[3]"); 
            testing(Kata.EgyptianFraction("0", "2"), "[]");
            testing(Kata.EgyptianFraction("9", "10"), "[1/2, 1/3, 1/15]");
        }
    }
}