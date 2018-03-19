using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void WhenStackDoesNotHaveNodes_ThenItIsEmpty()
        {
            var stack = new Stack<int>();

            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void WhenLastElementCome_ThenItIsServedFirst()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(3, stack.Peek().Value);
        }

        [TestMethod]
        public void WhenWePopElement_ThenTheHeadIsNextElement()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop();

            Assert.AreEqual(2, stack.Peek().Value);
        }

        [TestMethod]
        public void WhenWeItirateStack_ThenWeGoThroughItems()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int i = 3;
            foreach (var item in stack)
            {
                Assert.AreEqual(i, item);
                i--;
            }
        }
    }
}
