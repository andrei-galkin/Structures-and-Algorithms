using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Structures.Tests
{
    [TestClass]
    public class MaxHeapTests
    {
        [TestMethod]
        public void WhenMaxHeap_ThenThePeekNodeMustBeTheMaxElement()
        {
            var maxHeap = new MaxHeap<int>();

            maxHeap.Add(3);
            maxHeap.Add(1);
            maxHeap.Add(4);
            maxHeap.Add(2);
            maxHeap.Add(5);

            Assert.AreEqual(5, maxHeap.Peek());
        }

        [TestMethod]
        public void WhenPollElement_ThenNextMaxElementUp()
        {
            var maxHeap = new MaxHeap<int>();

            maxHeap.Add(3);
            maxHeap.Add(1);
            maxHeap.Add(4);
            maxHeap.Add(2);
            maxHeap.Add(5);
            maxHeap.Poll();

            Assert.AreEqual(4, maxHeap.Peek());
        }
    }
}
