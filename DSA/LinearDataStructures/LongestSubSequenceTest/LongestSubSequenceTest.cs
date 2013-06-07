using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongestSubSequence;

namespace LongestSubSequenceTest
{
    [TestClass]
    public class LongestSubSequenceTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyList()
        {
            List<int> testList = new List<int>();

            List<int> longestSub = SubSequence.FindLongestSubsequence(testList);
            List<int> resultList = new List<int>();

            Assert.AreEqual(resultList, longestSub);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestZeroElementsList()
        {
            List<int> testList = new List<int>(){};
            List<int> longestSub = SubSequence.FindLongestSubsequence(testList);
            List<int> resultList = new List<int>(){};

            Assert.AreEqual(resultList, longestSub);
        }

        [TestMethod]       
        public void TestOneElementsList()
        {
            List<int> testList = new List<int>() { 1 };
            List<int> longestSub = SubSequence.FindLongestSubsequence(testList);
            List<int> resultList = new List<int>() {1};

            for (int i = 0; i < longestSub.Count - 1; i++)
            {
                Assert.AreEqual(resultList[i], longestSub[i]);
            }                        
        }

        [TestMethod]
        public void TestTwoElementsList()
        {
            List<int> testList = new List<int>() { 1, 5 };
            List<int> longestSub = SubSequence.FindLongestSubsequence(testList);
            List<int> resultList = new List<int>() { 5 };

            for (int i = 0; i < longestSub.Count - 1; i++)
            {
                Assert.AreEqual(resultList[i], longestSub[i]);
            }
        }

        [TestMethod]
        public void TestManyElementsList()
        {
            List<int> testList = new List<int>()
                {
                    1, 5, 5, 5, 6, 3, 4, 56, 1, 5, 4, 4, 4, 4
                };
            List<int> longestSub = SubSequence.FindLongestSubsequence(testList);
            List<int> resultList = new List<int>() { 4, 4, 4, 4, 4 };

            for (int i = 0; i < longestSub.Count - 1; i++)
            {
                Assert.AreEqual(resultList[i], longestSub[i]);
            }
        }
    }
}