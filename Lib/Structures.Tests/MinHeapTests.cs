using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Structures.Tests
{
    [TestClass]
    public class MinHeapTests
    {
        [TestMethod]
        public void WhenMinHeap_ThenThePeekNodeMustBeTheMinElement()
        {
            var minHeap = new MinHeap<int>();

            for (int i = 10; i > 0; i--)
            {
                minHeap.Add(i);
            }

            Assert.AreEqual(1, minHeap.Peek());
        }
    }
}
