using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice
{
    class LinkedList
    {
        public Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.nextNode != null)
                {
                    temp = temp.nextNode;
                }
                temp.nextNode = node;
            }
        }
        public void DisplayList()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextNode;
            }
        }
    }
}
