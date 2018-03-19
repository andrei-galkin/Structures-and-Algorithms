using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Structures.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void WhenStackDoesNotHaveNodes_ThenItIsEmpty()
        {
            var queue = new Queue<int>();

            Assert.IsTrue(queue.IsEmpty);
        }

        [TestMethod]
        public void WhenFirstElementCome_ThenItIsServedFirst()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.AreEqual(1, queue.Peek().Value);
        }

        [TestMethod]
        public void WhenWeDequeueElement_ThenTheHeadIsNextElement()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();

            Assert.AreEqual(2, queue.Peek().Value);
        }

        [TestMethod]
        public void WhenWeItirateQueues_ThenWeGoThroughItems()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int i = 1;
            foreach (var item in queue)
            {
                Assert.AreEqual(i, item);
                i++;
            }
        }
    }
}
