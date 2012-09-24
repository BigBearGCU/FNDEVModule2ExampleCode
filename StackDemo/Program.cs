using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ast = new Stack();
            ast.Push("Item 1");
            ast.Push("Item 2");
            ast.Push("Item 3");
            ast.Push("Item 4");

            Console.WriteLine("Count:    {0}", ast.Count);
            PrintValues(ast);

            // Peek item but do not remove
            object item = ast.Peek();
            Console.WriteLine("Peek: {0}", item);
            PrintValues(ast);

            // Peek and cast but do not remove
            string itemString = ast.Peek() as string;   // fast cast
            Console.WriteLine("Peek: {0}", item);
            PrintValues(ast);

            // Contains
            Boolean contains = ast.Contains("Item 3");
            Console.WriteLine("Contains: {0}", contains);

            // Remove items
            object item4 = ast.Pop();
            object item3 = ast.Pop();
            Console.WriteLine("Pop: {0}  {1}", item4, item3);
            PrintValues(ast);
            Console.WriteLine("Count:    {0}", ast.Count);

            // no TrimToSize method
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("{0}   ", obj);
            Console.WriteLine();
        }
    }
}
