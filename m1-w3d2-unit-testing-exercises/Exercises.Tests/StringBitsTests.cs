using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        public void GetBitsTest()
        {
            //Arrange
            StringBits lotsOfBits = new StringBits();

            //Act
            string tooManyBits = lotsOfBits.GetBits("Help");
            string tooMany2Bits = lotsOfBits.GetBits("ALLCAPS");
            string tooMany3Bits = lotsOfBits.GetBits("Space Between Words");

            //Assert 
            Assert.AreEqual("Hl", tooManyBits);
            Assert.AreEqual("ALAS", tooMany2Bits);
            Assert.AreEqual("SaeBtenWrs", tooMany3Bits);
        }
    }
}