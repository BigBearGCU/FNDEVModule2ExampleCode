using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue aq = new Queue();
            aq.Enqueue("Item 1");
            aq.Enqueue("Item 2");
            aq.Enqueue("Item 3");
            aq.Enqueue("Item 4");

            Console.WriteLine("Count:    {0}", aq.Count);
            PrintValues(aq);

            // Peek item but do not remove
            object item = aq.Peek();
            Console.WriteLine("Peek: {0}", item);
            PrintValues(aq);

            // Peek and cast but do not remove
            string itemString = (string)aq.Peek();
            Console.WriteLine("Peek: {0}", itemString);
            PrintValues(aq);

            // Contains
            Boolean contains = aq.Contains("Item 3");
            Console.WriteLine("Contains: {0}", contains);

            // Remove items
            object item1 = aq.Dequeue();
            object item2 = aq.Dequeue();
            Console.WriteLine("Dequeue: {0}  {1}", item1, item2);
            PrintValues(aq);
            Console.WriteLine("Count:    {0}", aq.Count);

            // Trim to size
            aq.TrimToSize();   // no Capacity property
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("{0}   ", obj);
            Console.WriteLine();
        }
    }
}
