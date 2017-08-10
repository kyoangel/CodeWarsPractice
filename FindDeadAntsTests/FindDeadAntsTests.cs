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
            //given
            string input = null;
            //when
            int result = FindDeadAnts.DeadAntCount(input);
            //then
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void Test_DeadAntCount_WHEN_empty_THEN_return_zero()
        {
            //given
            string input = string.Empty;
            //when
            int result = FindDeadAnts.DeadAntCount(input);
            //then
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_DeadAntCount_WHEN_ant_THEN_return_zero()
        {
            //given
            string input = "ant";
            //when
            int result = FindDeadAnts.DeadAntCount(input);
            //then
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_DeadAntCount_WHEN_four_ants_THEN_return_zero()
        {
            //given
            string input = "ant ant ant ant";
            //when
            int result = FindDeadAnts.DeadAntCount(input);
            //then
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_DeadAntCount_WHEN_ant_ant_a_nt_THEN_return_one()
        {
            //given
            string input = "ant ant a nt";
            //when
            int result = FindDeadAnts.DeadAntCount(input);
            //then
            Assert.AreEqual(1, result);

        }
        

            [TestMethod]
        public void Test_DeadAntCount_WHEN_ant_anantt_aantnt_THEN_return_two()
        {
            //given
            string input = "ant anantt aantnt";
            //when
            int result = FindDeadAnts.DeadAntCount(input);
            //then
            Assert.AreEqual(2, result);

        }
    }
}