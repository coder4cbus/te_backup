using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        //declare and initialize array
        int[] emptyArray = { };
        int[] arrayOfBookTitles = { 1, 2, 3, 4, 5 };



        [TestMethod()]
        public void PotterNoPurchase()
        {
            //Arrange
            int[] emptyArray = { };
            KataPotter potter = new KataPotter();
            decimal expectedTotal = (8M * 0);

            //Act
            decimal actualCost = potter.GetCost(emptyArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);
        }

        [TestMethod()]
        public void PotterTotalNoDiscounts()
        {
            //Arrange
            int[] bookArray = { 0 };
            KataPotter potter = new KataPotter();
            decimal expectedTotal = (8M * 1);

            //Act
            decimal actualCost = potter.GetCost(bookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);

            //Arrange
            bookArray = new int[] { 0, 0 };
            expectedTotal = (8M * 2);

            //Act
            actualCost = potter.GetCost(bookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);

            //Arrange
            bookArray = new int[] { 4, 4, 4, 4, 4 };
            expectedTotal = (8M * 5);

            //Act
            actualCost = potter.GetCost(bookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);
        }

        [TestMethod()]
        public void PotterDiscountsForOneGroup()
        {
            //Arrange
            int[] bookArray = { 0, 1 };
            KataPotter potter = new KataPotter();
            decimal expectedTotal = (8M * 2 * 0.95M);

            //Act
            decimal actualCost = potter.GetCost(bookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);

            //Arrange
            bookArray = new int[] { 0, 1, 2 };

            expectedTotal = (8M * 3 * 0.90M);

            //Act
            actualCost = potter.GetCost(bookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);

            //Arrange
            bookArray = new int[] { 0, 1, 2, 3 };

            expectedTotal = (8M * 4 * 0.80M);

            //Act
            actualCost = potter.GetCost(bookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);

            //Arrange
            bookArray = new int[] { 0, 1, 2, 3, 4 };

            expectedTotal = (8M * 5 * 0.75M);

            //Act
            actualCost = potter.GetCost(bookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);
        }
        [TestMethod()]
        public void PotterSameBookDiscounts()
            {
            //Arrange
            KataPotter potterArrays = new KataPotter();
            int[] oneBookArray = { 0, 0, 1, 1 };
           

            decimal expectedTotal = (2 * (8M * 2 * 0.95M));

            //Act
            decimal actualCost = potterArrays.GetCost(oneBookArray);

            //Assert
            Assert.AreEqual(expectedTotal, actualCost);



        }
    }
}