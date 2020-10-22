using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
