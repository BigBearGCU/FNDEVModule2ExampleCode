using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<DateTime> aq = new Queue<DateTime>();
            aq.Enqueue(new DateTime(2008, 1, 19));   // item 1
            aq.Enqueue(new DateTime(2008, 4, 5));   // item 2
            aq.Enqueue(new DateTime(2008, 7, 2));   // item 3
            aq.Enqueue(new DateTime(2008, 12, 3));   // item 4

            Console.WriteLine("Count:    {0}", aq.Count);
            PrintValues(aq);

            // Peek item 1 but do not remove
            DateTime item = aq.Peek();
            Console.WriteLine("Peek: {0}", item.ToShortDateString());   // item is DateTime, not object
            PrintValues(aq);

            // Contains
            Boolean contains = aq.Contains(new DateTime(2008, 7, 2));
            Console.WriteLine("Contains: {0}", contains);

            // Remove items
            DateTime item1 = aq.Dequeue();
            DateTime item2 = aq.Dequeue();
            Console.WriteLine("Dequeue: {0}  {1}", item2.ToShortDateString(), item2.ToShortDateString());
            PrintValues(aq);
            Console.WriteLine("Count:    {0}", aq.Count);

            // Trim to size
            aq.TrimExcess();   // c.f. TrimToSize in non-generic Queue

            // iterate through Queue using a Queue.Enumerator
            Console.WriteLine("Listing using Queue.Enumerator");
            Queue<DateTime>.Enumerator qenum = aq.GetEnumerator();    // Queue<T>.Enumerator is a public inner struct declared in Queue<t>, see MyClass in this project for similar example
            while (qenum.MoveNext())
            {
                DateTime dt = qenum.Current;
                Console.WriteLine("{0}", dt.ToShortDateString());
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
