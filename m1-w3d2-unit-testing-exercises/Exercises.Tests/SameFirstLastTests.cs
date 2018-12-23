using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void notTheSameTests()
        {
            //Arrange
            SameFirstLast testIsItTheSame = new SameFirstLast();
            SameFirstLast testIsIt2TheSame = new SameFirstLast();
            SameFirstLast testIsIt3TheSame = new SameFirstLast();
            //Act
            bool testIsNotSame = testIsItTheSame.IsItTheSame(new int[] { 32, 13, 30 });
            bool testIsNotSame2 = testIsIt2TheSame.IsItTheSame(new int[] { 1, 2, 3 });

            bool testIsNotSame3 = testIsIt3TheSame.IsItTheSame(new int[] { 1, 2, 3, 1, 5 });

            //Assert 
            Assert.AreEqual(false, testIsNotSame);
            Assert.AreEqual(false, testIsNotSame2);
            Assert.AreEqual(false, testIsNotSame3);


        }
        [TestMethod]
        public void theSameTests()
        {
            //Arrange
            SameFirstLast testIsItTheSame = new SameFirstLast();
            //Act

            //Assert 
            Assert.AreEqual(true, testIsItTheSame.IsItTheSame(new int[] { 1, 2, 3, 1 }));

            Assert.AreEqual(true, testIsItTheSame.IsItTheSame(new int[] { 1, 2, 1 }));
        }
    }
}
