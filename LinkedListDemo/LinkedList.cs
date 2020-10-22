using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    class LinkedList
    {
        public Node head;
        public void AddToHead(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                node.next = null;
            else
                node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} is inserted at the head ", node.data);
        }

        public void AddToTail(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into the linked list", node.data);
        }
        public void InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
                Console.WriteLine("{0} is inserted at position {1}", data, position);
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
        }
        public void DeleteFisrtElement()
        {
            if (this.head == null)
                Console.WriteLine("List is empty");
            else
            {
                Console.WriteLine("Value removed from head is {0} ", this.head.data);
                this.head = this.head.next;
                return;
            }
        }
        public void DeleteLastElement()
        {
            Node temp = this.head;
            if (temp == null)
                Console.WriteLine("List is empty");
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Console.WriteLine("Value removed from tail is {0} ", temp.next.data);
                temp.next = null;
                return;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "\t");
                temp = temp.next;
            }
            Console.WriteLine("\n ______________________________________________________________________");
        }
    }
}
