 [TestMethod()]
        public void Lucky13Test()
        {
            Assert.AreEqual(true, exercises.Lucky13(new int[] { 0, 2, 4 }), "Test 1: Input was [0, 2, 4]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 1, 2, 3 }), "Test 2: Input was [1, 2, 3]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 1, 2, 4 }), "Test 3: Input was [1, 2, 4]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 5, 2, 3 }), "Test 4: Input was [5, 2, 3]");
        }