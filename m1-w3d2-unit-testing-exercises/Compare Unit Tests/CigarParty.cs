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
        public void HavePartyTests()
        {
        }
    }
}
 /*
         cigarParty(30, false) → false
         cigarParty(50, false) → true
         cigarParty(70, true) → true
         */
        [TestMethod]
        public void CigarParty()
        {
            Assert.AreEqual(false, exercises.CigarParty(30, false), "Input: CigarParty (30, false)");
            Assert.AreEqual(true, exercises.CigarParty(50, false), "Input: CigarParty (50, false)");
            Assert.AreEqual(true, exercises.CigarParty(70, true), "Input: CigarParty (70, true)");
        }