﻿using System;
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
        public int Search(int value)
        {
            if (head == null)
            {
                return 0;
            }
            int count = 0;
            Node temp = this.head;
            while (temp.data != value)
            {
                count++;
                temp = temp.nextNode;
            }
            Console.WriteLine($"Index of the node is:{count} i.e, {count+1} element in list");
            return count;
        }
        public void AddAfterNumber(int oldValue, int newValue)
        {
            int position = this.Search(oldValue);
            this.AddInBetween(newValue, position+1);
        }
        public void DeleteInBetween()
        {

        }
        public int Size()
        {
            int count = 0;
            while(this.head != null)
            {
                count++;
                head = head.nextNode;
            }
            return count;
        }
        public void DeleteANumber(int value)
        {
            int position = this.Search(value);
            Node temp = this.head;
            while (head.data != value)
            {
                head.nextNode = head;
                position--;
            }
            head = head.nextNode;
        }
    }
}
