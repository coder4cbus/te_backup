using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        //Weekday Party
        public void HavePartyTests()
        {
            //Arrange
            CigarParty party = new CigarParty();

            //Act
            bool partyOn = party.HaveParty(42, false);
            bool partyOn2 = party.HaveParty(50, false);
            bool partyNoWay = party.HaveParty(70, false);
            bool party2NoWay = party.HaveParty(30, false);
            bool party3NoWay = party.HaveParty(101, false);
            bool party4NoWay = party.HaveParty(61, false);

            //Assert
            Assert.AreEqual(true, partyOn);
            Assert.AreEqual(true, partyOn2);
            Assert.AreEqual(false, partyNoWay);
            Assert.AreEqual(false, party2NoWay);
            Assert.AreEqual(false, party3NoWay);
            Assert.AreEqual(false, party4NoWay);
        }

       [TestMethod]
        //Weekend Party
        public void HaveParty2Tests()
        {
            //Arrange
            CigarParty weekendparty = new CigarParty();

            //Act
            bool partyOn = weekendparty.HaveParty(60, true);
            bool party1On = weekendparty.HaveParty(75, true);
            bool party2On = weekendparty.HaveParty(98, true);
            bool party3On = weekendparty.HaveParty(40, true);
            bool partyNoWay = weekendparty.HaveParty(25, true);
            bool party2NoWay = weekendparty.HaveParty(12, true);

            //Assert
            Assert.AreEqual(true, partyOn);
            Assert.AreEqual(true, party1On);
            Assert.AreEqual(true, party2On);
            Assert.AreEqual(true, party3On);
            Assert.AreEqual(false, party2NoWay);
            Assert.AreEqual(false, partyNoWay);
        }
    }
}