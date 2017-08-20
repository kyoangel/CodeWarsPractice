using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountingDuplicates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates.Tests
{
    [TestClass()]
    public class CountingDuplicatesTests
    {
        [TestMethod]
        public void Test_DuplicateCount_WHEN_inputNull_THEN_returnZero()
        {
            AssertDuplicateCountByInputString(0, null);
        }


        [TestMethod]
        public void Test_DuplicateCount_WHEN_inputOneChar_THEN_returnZero()
        {
            AssertDuplicateCountByInputString(0, "a");

        }

        [TestMethod]
        public void Test_DuplicateCount_WHEN_noDuplicate_THEN_returnZero()
        {
            AssertDuplicateCountByInputString(0, "string");
            AssertDuplicateCountByInputString(0, "unity");
            AssertDuplicateCountByInputString(0, "Girl");
        }

        private static void AssertDuplicateCountByInputString(int expected, string input)
        {
            //given param input

            //when
            int result = CountingDuplicates.DuplicateCount(input);

            //then
            Assert.AreEqual(expected, result);
        }

    }
}