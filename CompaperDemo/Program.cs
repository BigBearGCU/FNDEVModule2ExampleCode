using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ComparerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedList using the default comparer.
            SortedList mySL1 = new SortedList();
            Console.WriteLine("mySL1 (default):");
            mySL1.Add("FIRST", "Hello");
            mySL1.Add("SECOND", "World");
            mySL1.Add("THIRD", "!");
            try
            {
                mySL1.Add("first", "Ola!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            PrintKeysAndValues(mySL1);

            // Create a SortedList using the specified case-insensitive comparer.
            SortedList mySL2 = new SortedList(new CaseInsensitiveComparer());
            Console.WriteLine("mySL2 (case-insensitive comparer):");
            mySL2.Add("FIRST", "Hello");
            mySL2.Add("SECOND", "World");
            mySL2.Add("THIRD", "!");
            try
            {
                mySL2.Add("first", "Ola!");   // will not work as key has already been added (case insensitive comparer used)
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            PrintKeysAndValues(mySL2);

            // sort an ArrayList of objects of different types by their type name, using custom Comparer
            // code is from http://www.codeguru.com/csharp/.net/net_data/sortinganditerating/article.php/c15169/
            ArrayList Items = new ArrayList();

            // Add several different data types to the Items ArrayList
            Items.Add(5);
            Items.Add("C# Tip");
            Items.Add(new object());
            Items.Add(new DateTime());
            Items.Add(9876543210);

            // Print out the unsorted list of items
            Console.WriteLine("Unsorted:\r\nData Type [Value]");
            foreach (object item in Items)
                Console.WriteLine(" " + item.GetType().ToString() + " ["
                            + item.ToString() + "]");

            // Sort the items
            DataTypeComparer MyDataTypeComparer = new DataTypeComparer();
            Items.Sort(MyDataTypeComparer);

            // Print out the list of items sorted by data type
            Console.WriteLine("Sorted:\r\nData Type [Value]");
            foreach (object item in Items)
                Console.WriteLine(" " + item.GetType().ToString() + " ["
                            + item.ToString() + "]");

        }

        public static void PrintKeysAndValues(SortedList myList)
        {
            Console.WriteLine("        -KEY-   -VALUE-");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("        {0,-6}: {1}",
                    myList.GetKey(i), myList.GetByIndex(i));
            }
            Console.WriteLine();
        }

    }
}
