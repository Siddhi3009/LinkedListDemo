﻿using System;

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
            //list.AddToTail(56);
            //list.AddToTail(30);
            //list.AddToTail(70);
            //list.Display();

            //Inserting number at specific position
            //list.AddToTail(56);
            //list.AddToTail(70);
            //list.InsertAtParticularPosition(2, 30);
            //list.Display();

            //Deleting Fisrt Element
            //list.DeleteFisrtElement();
            //list.Display();

            //Deleting Last Element
            //list.DeleteLastElement();
            //list.Display();

            //Inserting element after a value
            //list.InsertAfterValue(30, 40);
            //list.Display();

            //Deleting node with a value
            //list.DeleteWithValue(40);
            //list.Display();

            //Displaying Size of List
            //Console.WriteLine("Size of list: " + list.SizeOfList());

            //Add with sorting
            list.AddWithSorting(6);
            list.AddWithSorting(2);
            list.AddWithSorting(8);
            list.AddWithSorting(3);
            list.AddWithSorting(7);
            list.AddWithSorting(9);
            list.AddWithSorting(5);
            list.Display();

        }
    }
}
