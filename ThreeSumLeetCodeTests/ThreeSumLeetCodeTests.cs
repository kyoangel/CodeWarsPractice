using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreeSumLeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumLeetCode.Tests
{
    [TestClass()]
    public class ThreeSumLeetCodeTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Array length is too short")]
        public void ArrayTooshort()
        {
            var actual = ThreeSumLeetCode.ThreeSum(new int[] { -1, 0 });
        }

        [TestMethod()]
        public void ThreeSumTest()
        { 
            var actual = ThreeSumLeetCode.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            var expect = new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } };
            for (int i = 0; i < expect.Count(); i++)
            {
                Assert.IsTrue(actual[i].SequenceEqual(expect[i]));
            }
            
        }

        [TestMethod]
        public void NoAnswer()
        {
            var actual = ThreeSumLeetCode.ThreeSum(new int[] { -7, -3, 0, 2, 4, 8 });
            var expect = new List<IList<int>>();
            Assert.AreEqual(expect.Count, actual.Count);
        }
    }
}