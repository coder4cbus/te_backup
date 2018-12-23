using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        //end is larger
        public void MakeArrayTests()
            
        {
            //Arrange
            MaxEnd3 maxarray = new MaxEnd3();

            //Act
            int[] endLarger = maxarray.MakeArray(new int[] { 1, 0, 3 });
            int[] end2Larger = maxarray.MakeArray(new int[] { 1, 10, 3 });

            //Assert
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, endLarger);
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, end2Larger);
        }

        [TestMethod]
        //beginning is larger
        public void MakeArray2Tests()
        
        {
            //Arrange
            MaxEnd3 max2Array = new MaxEnd3();

            //Act
            int[] beginningLarger = max2Array.MakeArray(new int[] { 13, 0, 3 });
            int[] beginning2Larger = max2Array.MakeArray(new int[] { 13, 20, 3 });

           //Assert
            CollectionAssert.AreEqual(new int[] { 13, 13, 13 }, beginningLarger);
            CollectionAssert.AreEqual(new int[] { 13, 13, 13 }, beginning2Larger);
        }

        [TestMethod]
        public void MakeArray3Tests()
        {
            //Arrange
            MaxEnd3 max3Array = new MaxEnd3();

            //Act 
            int[] beginningLarger = max3Array.MakeArray(new int[] { 10, 0, 10 });
            int[] beginning2Larger = max3Array.MakeArray(new int[] { 10, 20, 10 });

            //Assert
            CollectionAssert.AreEqual(new int[] { 10, 10, 10 }, beginningLarger);
            CollectionAssert.AreEqual(new int[] { 10, 10, 10 }, beginning2Larger);
        }
    }
}
