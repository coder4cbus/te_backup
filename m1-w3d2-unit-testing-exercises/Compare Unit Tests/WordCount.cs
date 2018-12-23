        [TestMethod]
        public void wordCount()
        {
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };
            Dictionary<string, int> actual = exercises.WordCount(new string[] { "ba", "ba", "black", "sheep" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 2 },
                {"c", 1 },
                {"a", 2 }
            };
            actual = exercises.WordCount(new string[] { "a", "b", "a", "c", "b" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
            };
            actual = exercises.WordCount(new string[] { });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 1 },
                {"c", 1 },
                {"a", 1 }
            };
            actual = exercises.WordCount(new string[] { "c", "b", "a" });
            AssertCollections(expected, actual);
        }