using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void WhenOneNodeAppended_ThenTheNodeIsAfterHead()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Append(1);
            linkedList.Append(2);


            Assert.AreEqual(1, linkedList.Head.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Value);
        }

        [TestMethod]
        public void WhenOneNodePreppended_ThenTheNodeIsBeforeHead()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Append(1);
            linkedList.Prepend(2);


            Assert.AreEqual(2, linkedList.Head.Value);
        }

        [TestMethod]
        public void WhenOneNodeDeleted_ThenTheNodeIsNotInTheList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);

            linkedList.Delete(2);

            Assert.AreEqual(1, linkedList.Head.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Value);
        }

        [TestMethod]
        public void WhenWeItirateLinkedList_ThenWeGoThroughItems()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);

            int i = 1;
            foreach (var item in linkedList)
            {
                Assert.AreEqual(i, item);
                i++;
            }
        }

        [TestMethod]
        public void WhenNeedToFindElement_ThenElementFound()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);

            int element = linkedList.Find(3);
            Assert.AreEqual(3, element);
        }
    }
}
