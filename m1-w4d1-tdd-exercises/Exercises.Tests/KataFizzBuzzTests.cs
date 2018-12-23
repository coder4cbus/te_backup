using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises;


namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz emptyString = new KataFizzBuzz();
        KataFizzBuzz expectedStringForNumber30 = new KataFizzBuzz();
        KataFizzBuzz expectedStringForNumber55 = new KataFizzBuzz();
        KataFizzBuzz expectedStringForNumber99 = new KataFizzBuzz();
        [TestMethod()]
         public void FizzBuzzDivideBy3And5()
        {
            //Arrange
            string actualStringResult;
            string actualStringResultForNumber60;
            string expectedStringForNumber15 = "FizzBuzz";
            string expectedStringForNumber60 = "FizzBuzz";
            //Act
            actualStringResult = emptyString.FizzBuzz(15);
            actualStringResultForNumber60 = emptyString.FizzBuzz(60);
            //Assert
            Assert.AreEqual(expectedStringForNumber15, actualStringResult);
            Assert.AreEqual(expectedStringForNumber60, actualStringResultForNumber60);
        }
        [TestMethod()]
        public void BuzzDivideBy5()
        {
            //Arrange
            string actualStringResult;
            string actualStringResultForNumber5;
            string expectedStringForNumber5 = "Buzz";
            string expectedStringForNumber55 = "Buzz";
            //Act
            actualStringResult = emptyString.FizzBuzz(55);
            actualStringResultForNumber5 = emptyString.FizzBuzz(5);
            //Assert
            Assert.AreEqual(expectedStringForNumber55, actualStringResult);
            Assert.AreEqual(expectedStringForNumber5, actualStringResultForNumber5);
        }
        [TestMethod()]
        public void FizzDivideBy3()
        {
            //Arrange
            string actualStringResult;
            string actualStringResultForNumber3;
            string expectedStringForNumber99 = "Fizz";
            string expectedStringForNumber3 = "Fizz";
            //Act
            actualStringResult = emptyString.FizzBuzz(99);
            actualStringResultForNumber3 = emptyString.FizzBuzz(3);
            //Assert
            Assert.AreEqual(expectedStringForNumber99, actualStringResult);
            Assert.AreEqual(expectedStringForNumber3, actualStringResultForNumber3);

        }
        [TestMethod()]
        public void FizzBuzzYieldsEmptyString()
        {
            //Arrange
            string actualStringResult;
            string actualStringResultForNegativeNumber;
            string expectedStringForNumber105 = " ";
            string expectedStringForNegativeNumber = " ";
            //Act
            actualStringResult = emptyString.FizzBuzz(105);
            actualStringResultForNegativeNumber = emptyString.FizzBuzz(-25);
            //
            Assert.AreEqual(expectedStringForNumber105, actualStringResult);
            Assert.AreEqual(expectedStringForNegativeNumber, actualStringResultForNegativeNumber);
        }

    }
}
