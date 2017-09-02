using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TwoSum.Tests
{
    [TestClass()]
    public class TwoSumLeetCodeTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "No two sum solution")]
        public void Test_ZeroArray_Then_Throw_ArgumentException()
        {
            var actual = TwoSumLeetCode.TwoSum(new int[] { }, 0);
        }

        [TestMethod()]
        public void Test_ExactlySolution_PairNotTheSame()
        {
            var actual = TwoSumLeetCode.TwoSum(new int[] { 2, 3, 4, 5 }, 6);
            Assert.AreEqual(true, actual.SequenceEqual(new int[] { 0, 2 }));

        }

        [TestMethod]
        public void Test_DuplicatePairArray_Solution()
        {
            var actual = TwoSumLeetCode.TwoSum(new int[] { 3, 2, 3 }, 6);
            Assert.AreEqual(true, actual.SequenceEqual(new int[] { 0, 2 }));
        }
    }
}