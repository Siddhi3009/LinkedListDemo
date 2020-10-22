using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;
namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenData_WhenSearched_ShouldReturnNodeContainingThatData()
        {
            int data = 30;
            LinkedList list = new LinkedList();
            list.AddToTail(56);
            list.AddToTail(30);
            list.AddToTail(70);
            Node node = list.Search(30);
            Assert.AreEqual(data, node.data);
        }
    }
}
