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
            //given
            string input = null;

            //when
            int result = CountingDuplicates.DuplicateCount(input);

            //then
            Assert.AreEqual(0, result);
        }
    }
}