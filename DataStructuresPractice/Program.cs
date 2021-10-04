using System;

namespace DataStructuresPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //linkedList.AddNode(56);
            //linkedList.AddNode(30);
            //linkedList.AddNode(70);
            linkedList.AddInReverseOrder(70);
            linkedList.AddInReverseOrder(30);
            linkedList.AddInReverseOrder(56);

            linkedList.DisplayList();
            Console.ReadKey();
        }
    }
}
