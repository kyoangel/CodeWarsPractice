using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataContainsDuplicate2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataContainsDuplicate2.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void Input_empty_array_return_false()
        {
            bool actual = GetActual(new int[] { }, 0);
            Assert.AreEqual(false, actual);
        }


        [TestMethod]
        public void Input_simple_case_return_true()
        {
            bool actual = GetActual(new int[] { -1, -1 }, 1);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Input_big_return_false()
        {
            var expected = true;
            bool actual = GetActual(new int[] { 2147483647, -2147483648, 2147483647, -2147483648 }, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Target_k_not_correct()
        {
            var expected = true;
            bool actual = GetActual(new int[] { 99, 99 }, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_contain_multi_same_element()
        {
            var expected = true;
            bool actual = GetActual(new int[] { 1, 0, 1, 1 }, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_no_duplicate_should_return_false()
        {

            var expected = false;
            bool actual = GetActual(new int[] { 1,2 }, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void specailCase()
        {
            var expected = true;
            bool actual = GetActual(new int[] { 0, 1, 2, 3, 4, 0, 0, 7, 8, 9, 10, 11, 12, 0 }, 1);
            Assert.AreEqual(expected, actual);
        }

        private static bool GetActual(int[] nums, int k)
        {
            var solution = new Solution();
            var actual = solution.ContainsNearbyDuplicate(nums, k);
            return actual;
        }
    }
}