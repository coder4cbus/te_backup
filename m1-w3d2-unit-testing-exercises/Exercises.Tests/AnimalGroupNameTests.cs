using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        //animal name yields cooresponding herd name
        public void GetHerdTest()
        {
            //Arrange
            AnimalGroupName animalTestGroup = new AnimalGroupName();

            //Act
            string herdName = animalTestGroup.GetHerd("crocodile");

            //Assert
            Assert.AreEqual("Float", herdName);
        }


        [TestMethod]
        //Case Insensitive 
        public void GetHerdTestTwo()
        {
            //Arrange
            AnimalGroupName animalTestGroup = new AnimalGroupName();
            AnimalGroupName animalTest2Group = new AnimalGroupName();
            AnimalGroupName animalTest3Group = new AnimalGroupName();

            //Act
            string herdLionName = animalTestGroup.GetHerd("Lion");
            string herd2LionName = animalTest2Group.GetHerd("LION");
            string herd3LionName = animalTest3Group.GetHerd("lion");

            //Assert
            Assert.AreEqual("Pride", herdLionName);
            Assert.AreEqual("Pride", herd2LionName);
            Assert.AreEqual("Pride", herd3LionName);
        }


        [TestMethod]
        //Unknown Return
        public void GetHerdTestThree()
        {
            //Arrange
            AnimalGroupName animalTestGroup = new AnimalGroupName();
            AnimalGroupName animalTest2Group = new AnimalGroupName();
            AnimalGroupName animalTest3Group = new AnimalGroupName();

            //Act
            string herdLionName = animalTestGroup.GetHerd("Buffalo");
            string herd2LionName = animalTest2Group.GetHerd("crows");
            string herd3LionName = animalTest3Group.GetHerd(" ");

            //Assert
            Assert.AreEqual("unknown", herdLionName);
            Assert.AreEqual("unknown", herd2LionName);
            Assert.AreEqual("unknown", herd3LionName);
        }
    }
}