using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo");
            //Adding new element to head LIFO
            LinkedList list = new LinkedList();
            list.AddToHead(70);
            list.AddToHead(30);
            list.AddToHead(56);
            list.Display();
        }
    }
}
