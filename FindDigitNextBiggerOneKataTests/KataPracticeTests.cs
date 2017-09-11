using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindDigitNextBiggerOneKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigitNextBiggerOneKata.Tests
{
    [TestClass()]
    public class KataPracticeTests
    {
        [TestMethod()]
        public void NextBiggerNumberTest()
        {
            Assert.AreEqual(21, KataPractice.NextBiggerNumber(12));
            Assert.AreEqual(531, KataPractice.NextBiggerNumber(513));
            Assert.AreEqual(2071, KataPractice.NextBiggerNumber(2017));
            Assert.AreEqual(441, KataPractice.NextBiggerNumber(414));
            Assert.AreEqual(414, KataPractice.NextBiggerNumber(144));
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(1234567908, KataPractice.NextBiggerNumber(1234567890));
            //Assert.AreEqual(559095479, KataPractice.NextBiggerNumber(559094975));
            
        }
    }
}