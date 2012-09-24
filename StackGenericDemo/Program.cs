using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<DateTime> ast = new Stack<DateTime>();
            ast.Push(new DateTime(2008, 1, 19));   // item 1
            ast.Push(new DateTime(2008, 4, 5));   // item 2
            ast.Push(new DateTime(2008, 7, 2));   // item 3
            ast.Push(new DateTime(2008, 12, 3));   // item 4

            Console.WriteLine("Count:    {0}", ast.Count);
            PrintValues(ast);

            // Peek item 4 but do not remove
            DateTime item = ast.Peek();
            Console.WriteLine("Peek: {0}", item.ToShortDateString());
            PrintValues(ast);

            // Contains
            Boolean contains = ast.Contains(new DateTime(2008, 7, 2));
            Console.WriteLine("Contains: {0}", contains);

            // Remove item 4 and item 3
            DateTime item4 = ast.Pop();
            DateTime item3 = ast.Pop();
            Console.WriteLine("Pop: {0}  {1}", item4.ToShortDateString(), item3.ToShortDateString());
            PrintValues(ast);
            Console.WriteLine("Count:    {0}", ast.Count);

            // iterate through Stack using a Stack.Enumerator
            Console.WriteLine("Listing using Stack.Enumerator");
            Stack<DateTime>.Enumerator stenum = ast.GetEnumerator();    // Stack<T>.Enumerator is a public inner struct declared in Stack<T>, 
            while (stenum.MoveNext())
            {
                DateTime dt = stenum.Current;
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
