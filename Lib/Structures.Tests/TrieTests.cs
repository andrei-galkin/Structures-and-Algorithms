using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Structures.Tests
{
    [TestClass]
    public class TrieTests
    {
        [TestMethod]
        public void WhenStackDoesNotHaveNodes_ThenItIsEmpty()
        {
            var sanpleText = @"O Canada!
                                Our home and native land!
                                True patriot love in all of us command.
                                With glowing hearts we see thee rise,
                                The True North strong and free!
                                From far and wide,
                                O Canada, we stand on guard for thee.
                                God keep our land glorious and free!
                                O Canada, we stand on guard for thee.
                                O Canada, we stand on guard for thee.";

            var trie = new Trie<string>();
            foreach(string word in sanpleText.Split(' '))
            {
                trie.Add(word, word);
            }

            Assert.IsTrue(trie.Matcher.Next('C'));
            Assert.IsTrue(trie.Matcher.Next('a'));
        }
    }
}
