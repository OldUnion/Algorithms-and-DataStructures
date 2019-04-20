using System.Collections.Generic;
using System.Linq;
using Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.AlgorithmsTests
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            var sortingCollection = new List<int> { 5, 5, 6, 3, 2, 99, 3, -5, 33, 23, 435, 2, 23, 1 };
            var expectedResult = sortingCollection.ToList();
            expectedResult.Sort();

            BubbleSort.Sort(sortingCollection);

            CollectionAssert.AreEqual(sortingCollection, expectedResult);
        }
    }
}
