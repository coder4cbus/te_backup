using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;


namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        /*
 * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
 * number of times that string appears in the array.
 * 
 * ** A CLASSIC **
 * 
 * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
 * GetCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
 * GetCount([]) → {}
 * GetCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
 * 
 */
        [TestMethod]
        public void GetCountTests()
        {
            //Arrange
            WordCount oneTwoThree = new WordCount();

            // Act
            Dictionary<string, int> initialStringArray = oneTwoThree.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>() {
            { "ba", 2},
            { "black", 1},
            { "sheep", 1},
            };

            //Assert
            CollectionAssert.AreEqual(initialStringArray, resultDictionary);
        }

        [TestMethod]
        public void GetCount2Tests()
        {
            // Arrange
            WordCount oneTwoThree = new WordCount();
            // 
            //Act
            Dictionary<string, int> initialStringArray = oneTwoThree.GetCount(new string[] { "a", "b", "a", "c", "b" });
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>() {
            { "a", 2},
            { "b", 2},
            { "c", 1},
            };
            //Assert
            CollectionAssert.AreEqual(initialStringArray, resultDictionary);
        }

    }
}