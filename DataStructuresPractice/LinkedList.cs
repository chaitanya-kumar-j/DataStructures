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
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.nextNode = temp;
            }
        }
        public void AddInBetween(int data, int position)
        {
            Node newestNode = new Node(data);
            if(this.head == null)
            {
                this.head =  newestNode;
            }
            if (position ==0)
            {
                newestNode.nextNode = this.head;
                this.head = newestNode;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while(current!=null && count < position)
            {
                prev = current;
                current = current.nextNode;
                count++;
            }
            newestNode.nextNode = prev.nextNode;
            prev.nextNode = newestNode;
        }
        public void RemoveFirstNode()
        {
            if(this.head == null)
            {
                head = null;
            }
            this.head = this.head.nextNode;
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            Node temp = head;
            while (temp.nextNode.nextNode != null)
            {
                temp = temp.nextNode;
            }
            temp.nextNode = null;
        }
    }
}
