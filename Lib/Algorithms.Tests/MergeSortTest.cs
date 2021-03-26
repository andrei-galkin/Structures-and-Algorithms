using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void WhenWeGiveArray_ThenItIsSorted()
        {
            int[] array = { 2, 4, 1, 5, 6, 8, 7, 9, 3 };
            MergeSort.Sort(array);
            int i = 1;

            foreach (int v in array)
            {
                Assert.AreEqual(i, v);
                i++;
            }
        }

        [TestMethod]
        public void test()
        {
            var arr = new int[] {1, 3, 6, 7, 9, 11, 15, 17};
            var r = twoSum(arr, 17);
            var f = Fib(7);

            Assert.AreEqual(r, true);
        }

        private bool twoSum(int[] array, int target)
        {
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex <= rightIndex)
            {
                if (array[leftIndex] + array[rightIndex] == target)
                {
                    Console.WriteLine(array[leftIndex] + " " + array[rightIndex]);
                    return true;
                }

                if (array[leftIndex] + array[rightIndex] < target)
                {
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }
            }

            return true;
        }

        private int Fib(int n)
        {
            if (n == 0)
                return 0;

            var previousFib = 0;
            var currentFib = 1;

            for (int i = 2; i <= n; i++)
            {
                // loop is skipped if n = 1
                var newFib = previousFib + currentFib;
                previousFib = currentFib;
                currentFib = newFib;
            }

            return currentFib;
        }
    }
}
