using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sibala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala.Tests
{
    [TestClass()]
    public class DiceTests
    {
        [TestMethod]
        public void Test_Calculate_WHEN_input1234_THEN_returnNoPoint()
        {
            //given
            Dice d = new Dice(1, 2, 3, 4);
            //when
            string result = d.Calculate();

            //then
            Assert.AreEqual("NoPoint", result);
        }

        [TestMethod]
        public void Test_Calculate_WHEN_input2255_THEN_return10Point()
        {
            //given
            Dice d = new Dice(2, 2, 5, 5);
            //when
            string result = d.Calculate();

            //then
            Assert.AreEqual("10Points", result);
        }

        [TestMethod]
        public void Test_Calculate_WHEN_input4444_THEN_returnAll4()
        {
            //given
            Dice d = new Dice(4, 4, 4, 4);
            //when
            string result = d.Calculate();

            //then
            Assert.AreEqual("All4", result);
        }

        [TestMethod]
        public void Test_Calculate_WHEN_input2256_THEN_return11Points()
        {
            //given
            Dice d = new Dice(2, 2, 5, 6);
            //when
            string result = d.Calculate();

            //then
            Assert.AreEqual("11Points", result);
        }

        [TestMethod]
        public void Test_Calculate_WHEN_input3312_THEN_returnBG()
        {
            //given
            Dice d = new Dice(3, 3, 1, 2);
            //when
            string result = d.Calculate();

            //then
            Assert.AreEqual("BG", result);
        }

        [TestMethod]
        public void Test_Calculate_WHEN_input1166_THEN_returnEighteenLa()
        {
            //given
            Dice d = new Dice(1, 1, 6, 6);
            //when
            string result = d.Calculate();

            //then
            Assert.AreEqual("EighteenLa", result);
        }
    }
}