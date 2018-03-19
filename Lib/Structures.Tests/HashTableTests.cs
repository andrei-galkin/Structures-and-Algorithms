using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Structures.Tests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void WhenWeAddSevearalItems_ThenWeGetItByKey()
        {
            var hashTable = new HashTable<string, string>();
            hashTable.Add("Test1", "Test1");
            hashTable.Add("Test2", "Test2");
            hashTable.Add("Test3", "Test3");

            Assert.AreEqual("Test1", hashTable.Get("Test1"));
        }

        [TestMethod]
        public void WhenGetElementByKey_ThenWeGetSecondElementByKey()
        {
            var hashTable = new HashTable<string, string>();
            hashTable.Add("Test1", "Test1");
            hashTable.Add("Test2", "Test2");
            hashTable.Add("Test3", "Test3");

            Assert.AreEqual("Test2", hashTable.Get("Test2"));
        }

        [TestMethod]
        public void WhenDeleteElement_ThenGetNull()
        {
            var hashTable = new HashTable<string, string>();
            hashTable.Add("Test1", "Test1");
            hashTable.Add("Test2", "Test2");
            hashTable.Add("Test3", "Test3");
            hashTable.Delete("Test2");

            Assert.AreEqual(null, hashTable.Get("Test2"));
        }

        [TestMethod]
        public void WhenAddTenItems_ThenTenItemsAdded()
        {
            var hashTable = new HashTable<string, string>();

            for (int i = 0; i < 10; i++)
            {
                hashTable.Add("Test" + i.ToString(), "Test"+ i.ToString());
            }

            Assert.AreEqual(10, hashTable.Count);
        }

        [TestMethod]
        public void WhenAddTenItemsAndOneDelete_ThenNineItemsAdded()
        {
            var hashTable = new HashTable<string, string>();

            for (int i = 0; i < 10; i++)
            {
                hashTable.Add("Test" + i.ToString(), "Test" + i.ToString());
            }

            hashTable.Delete("Test0");

            Assert.AreEqual(9, hashTable.Count);
        }
    }
}
