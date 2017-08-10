using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindDeadAnts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDeadAnts.Tests
{
    [TestClass()]
    public class FindDeadAntsTests
    {
        [TestMethod()]
        public void Test_DeadAntCount_WHEN_null_THEN_return_zero()
        {
            Assert.AreEqual(0, FindDeadAnts.DeadAntCount(null));
        }

        [TestMethod]
        public void Test_DeadAntCount_WHEN_ant_THEN_return_zero()
        {
            //given

            //when

            //then

        }
    }
}