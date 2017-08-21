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
    }
}