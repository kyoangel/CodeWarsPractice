using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Tests
{
    [TestClass()]
    public class TwoSumLeetCodeTests
    {
        [TestMethod()]
        public void Test_ZeroArray_Then_Throw_ArgumentException()
        {
            var actual = TwoSumLeetCode.TwoSum(new int[] { 3, 2, 3 }, 6);
            Assert.AreEqual(true, actual.SequenceEqual(new int[] { 0, 2 }));
        }
    }
}