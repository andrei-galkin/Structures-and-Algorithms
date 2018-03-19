using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void WhenWeGiveArray_ThenItIsSorted()
        {
            int[] array = { 2, 4, 1, 5, 6, 8, 7, 9, 3 };
            QuickSort.Sort(array);
            int i = 1;

            foreach(int v in array)
            {
                Assert.AreEqual(i, v);
                i++;
            }
        }
    }
}
