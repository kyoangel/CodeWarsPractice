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
        public void Test_GenerateBandName_WHEN_InputEmptyStr_THEN_ThrowException()
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
        public void Test_GenerateBandName_WHEN_InputNullStr_THEN_ThrowException()
        {
            //given
            string input = null;

            //when
            string actual = BandNameGenerator.GenerateBandName(input);

            //then
            //ExpectedException by Attribute
        }

        [TestMethod]
        public void Test_GenerateBandName_WHEN_InputSingleChar_THEN_ReturnCaptionDoubleChars()
        {
            //given
            string input = "a";

            //when
            string actual = BandNameGenerator.GenerateBandName(input);

            //then
            Assert.AreEqual("Aa", actual);
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

        [TestMethod]
        public void Test_GenerateBandName_WHEN_noun_with_the_same_start_end_THEN_return_caption_double_str()
        {
            //given
            string input = "bob";
            //when
            string actual = BandNameGenerator.GenerateBandName(input);

            //then
            Assert.AreEqual("Bobbob", actual);

        }

        [TestMethod]
        public void Test_GenerateBandName_WHEN_situation_THEN_expected()
        {
            //given

            //when

            //then

        }
    }
}