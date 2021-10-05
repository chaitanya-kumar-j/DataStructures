using System;

namespace DataStructuresPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList linkedList = new LinkedList();
            //linkedList.AddNode(56);
            //linkedList.AddNode(30);
            //linkedList.AddNode(70);
            //linkedList.AddInReverseOrder(70);
            //linkedList.AddInReverseOrder(30);
            //linkedList.AddInReverseOrder(56);
            // linkedList.AddInBetween(30, 1);
            // linkedList.RemoveFirstNode();
            // linkedList.RemoveLastNode();
            // linkedList.Search(30);
            //linkedList.AddAfterNumber(30, 40);
            //linkedList.DisplayList();
            // linkedList.DeleteANumber(40);
            //int a = linkedList.Size();
            //Console.WriteLine(a);

            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.DisplayStack();
        }
    }
}
