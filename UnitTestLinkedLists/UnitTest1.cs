using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTest;

namespace UnitTestLinkedLists
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Return5thElementInt()
        {
            var list = new LinkedList();
            list.AddToList(1);
            list.AddToList(2);
            list.AddToList(3);
            list.AddToList(4);
            list.AddToList(5);
            list.AddToList(6);
            list.AddToList(7);

            int response = (int)list.getNthFromLast(5);

            Assert.IsTrue(response == 3);
        }

        [TestMethod]
        public void Return5thElementString()
        {
            var list = new LinkedList();
            list.AddToList("1");
            list.AddToList("2");
            list.AddToList("3");
            list.AddToList("4");
            list.AddToList("5");
            list.AddToList("6");
            list.AddToList("7");

            string response = (string)list.getNthFromLast(5);

            Assert.IsTrue(response == "3");
        }

        [TestMethod]
        public void ReturnNLargerThanList()
        {
            var list = new LinkedList();
            list.AddToList("1");
            list.AddToList("2");
            list.AddToList("3");
            list.AddToList("4");
            list.AddToList("5");
            list.AddToList("6");
            list.AddToList("7");

            string response = (string)list.getNthFromLast(10);

            Assert.IsTrue(response == null);
        }

        [TestMethod]
        public void ReturnNNegativeThanList()
        {
            var list = new LinkedList();
            list.AddToList("1");
            list.AddToList("2");
            list.AddToList("3");
            list.AddToList("4");
            list.AddToList("5");
            list.AddToList("6");
            list.AddToList("7");

            string response = (string)list.getNthFromLast(-10);

            Assert.IsTrue(response == null);
        }
    }
}
