using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void GetPartialStringTests()
        //full string with concatenation
        {
            //Arrange
            NonStart stringparted = new NonStart();
            NonStart string2parted = new NonStart();
            NonStart string3parted = new NonStart();
           
            //Act
            string partialString = stringparted.GetPartialString("Hi", "There");
            string partial2String = string2parted.GetPartialString("", "There");
            string partial3String = string3parted.GetPartialString("Hi", "");
            
            //Assert
            Assert.AreEqual("ihere", partialString);
            Assert.AreEqual("here", partial2String);
            Assert.AreEqual("i", partial3String);
        }
    }
}
