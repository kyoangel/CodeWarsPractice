using Microsoft.VisualStudio.TestTools.UnitTesting;
using BandNameGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator.Tests
{
    [TestClass()]
    public class BandNameGeneratorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "A team name should not be null or empty.")]
        public void Test_GenerateBandName_WHEN_input_empty_THEN_return_argumentExceptino()
        {
            //given
            string input = "";

            //when
            string actual = BandNameGenerator.GenerateBandName(input);

            //then
            //ExpectedException by Attribute
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "A team name should not be null or empty.")]
        public void Test_GenerateBandName_WHEN_input_null_THEN_return_argumentExceptino()
        {
            //given
            string input = null;

            //when
            string actual = BandNameGenerator.GenerateBandName(input);

            //then
            //ExpectedException by Attribute
        }

        [TestMethod]
        public void Test_GnerateBandName_WHEN_input_single_char_THEN_return_double_char()
        {
            //given
            string input = "a";

            //when
            string actual = BandNameGenerator.GenerateBandName(input);

            //then
            Assert.AreEqual("aa", actual);
        }

        [TestMethod]
        public void Test_GenerateBandName_WHEN_noun_start_not_equal_end_THEN_return_the_add_caption_str()
        {
            //given
            string input = "car";

            //when
            string actual = BandNameGenerator.GenerateBandName(input);

            //then
            Assert.AreEqual("The Car", actual);

        }
    }
}