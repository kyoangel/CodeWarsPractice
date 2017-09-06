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
    }
}