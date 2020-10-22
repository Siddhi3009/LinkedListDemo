using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;
using System.Collections.Generic;

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
        [TestMethod]
        public void Given3Numbers_WhenInsertingSecondInBetween_ShouldPassLinkedListResult()
        {
            LinkedList list = new LinkedList();
            list.AddToTail(56);
            list.AddToTail(30);
            list.AddToTail(70);
            list.InsertAfterValue(30, 40);
            Node node = list.Search(30);
            Node actual = node.next;
            Node expected = list.Search(40);
            Assert.AreEqual(actual.GetType(), expected.GetType());
        }
        [TestMethod]
        public void GivenALinkedListNumbers_WhenDeletingANodeWithGivenValue_ShouldPassLinkedListResult()
        {
            int expected = 70;
            LinkedList list = new LinkedList();
            list.AddToTail(56);
            list.AddToTail(30);
            list.AddToTail(40);
            list.AddToTail(70);
            list.DeleteWithValue(40);
            Node node = list.Search(30);
            int actual = node.next.data;
            Assert.AreEqual(expected, actual);
        }

    }
}
