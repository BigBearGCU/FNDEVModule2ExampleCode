using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<DateTime> aLinkedList = new LinkedList<DateTime>();

            // add elements at the start
            aLinkedList.AddFirst(new DateTime(1966, 2, 1));
            aLinkedList.AddFirst(new DateTime(1964, 12, 3));

            // add another element at the start and hold a reference to the node
            LinkedListNode<DateTime> node1 = aLinkedList.AddFirst(new DateTime(1968, 4, 5));

            Console.WriteLine("Count:    {0}", aLinkedList.Count);    // no Capacity for linked list
            PrintValues(aLinkedList);

            // add nodes before and after node1
            aLinkedList.AddBefore(node1, new DateTime(1997, 7, 2));
            aLinkedList.AddAfter(node1, new DateTime(1965, 1, 19));
            Console.WriteLine("Nodes added before and after node1");
            PrintValues(aLinkedList);

            // Remove items
            aLinkedList.Remove(new DateTime(1965, 1, 19));
            aLinkedList.RemoveLast();
            Console.WriteLine("Nodes removed");
            PrintValues(aLinkedList);

            // find item using linear search
            LinkedListNode<DateTime> foundNode = aLinkedList.Find(new DateTime(1968, 4, 5));
            if (foundNode != null)
            {
                Console.WriteLine("Found: {0}", foundNode.Value.ToShortDateString());

                // get next node
                LinkedListNode<DateTime> nextNode = foundNode.Next;
                if (nextNode != null)
                {
                    Console.WriteLine("Next: {0}", nextNode.Value.ToShortDateString());
                }

                // get previous node
                LinkedListNode<DateTime> previousNode = foundNode.Previous;
                if (previousNode != null)
                {
                    Console.WriteLine("Previous: {0}", previousNode.Value.ToShortDateString());
                }
            }
        }

        public static void PrintValues(IEnumerable<DateTime> myList)
        {
            foreach (DateTime dt in myList)
            {
                Console.WriteLine("{0}", dt.ToShortDateString());
            }
        }
    }
}
