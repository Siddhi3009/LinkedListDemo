using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo");
            LinkedList list = new LinkedList();

            //Adding new element to head LIFO
            //list.AddToHead(70);
            //list.AddToHead(30);
            //list.AddToHead(56);
            //list.Display();

            //Adding new element to tail FIFO
            list.AddToTail(56);
            list.AddToTail(30);
            list.AddToTail(70);
            list.Display();

            //Inserting number at specific position
            //list.AddToTail(56);
            //list.AddToTail(70);
            //list.InsertAtParticularPosition(2, 30);
            //list.Display();

            //Deleting Fisrt Element
            list.DeleteFisrtElement();
            list.Display();
        }
    }
}
