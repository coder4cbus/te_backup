  [TestMethod()]
        public void MaxEnd3Test()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, exercises.MaxEnd3(new int[] { 11, 5, 9 }), "Test 2: Input was [11, 5, 9]");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 2, 11, 3 }), "Test 3: Input was [2, 11, 3]");
        }