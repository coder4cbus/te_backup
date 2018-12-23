using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        public void GetLuckyTests()
        {
            //Arrange
            Lucky13 goneLucky= new Lucky13();

            //Assert
            bool expectedResult = goneLucky.GetLucky(new int[] { 0, 2, 4 });
            bool expected2Result = goneLucky.GetLucky(new int[] { 2, 5, 6, 4 });
            bool expected3Result = goneLucky.GetLucky(new int[] { 400, 5, 6, 7, 8, 9 });
            bool expected4Result = goneLucky.GetLucky(new int[] { 32, 13, 30 });


            //Act
            Assert.AreEqual(true, expectedResult);
            Assert.AreEqual(true, expected2Result);
            Assert.AreEqual(true, expected3Result);
            Assert.AreEqual(true, expected4Result);

            

        }
        [TestMethod]
        public void GetLucky2Tests()
        {
            //Arrange
            Lucky13 notLucky = new Lucky13();

            //Assert & Act
            Assert.AreEqual(false, notLucky.GetLucky(new int[] { 10, 2, 4, 1 }));
            Assert.AreEqual(false, notLucky.GetLucky(new int[] { 1, 3 }));
        }
    }
}
