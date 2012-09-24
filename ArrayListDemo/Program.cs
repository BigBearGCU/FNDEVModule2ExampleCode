using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Paris");
            al.Add("Ottowa");
            al.AddRange(new string[] { "Rome", "Tokyo", "Tunis", "Canberra" });

            Console.WriteLine("Count:    {0}", al.Count);
            Console.WriteLine("Capacity: {0}", al.Capacity);

            Console.WriteLine("Print values using foreach");
            PrintValues(al);
            Console.WriteLine("Print values using IEnumerator");
            PrintValuesByEnumerator(al);

            // Get second item in list as string
            string str = (string)al[1];    // need to cast, would also unbox if stored type was value type
            Console.WriteLine("al[1] = {0}", str);

            // Get first three items
            ArrayList firstThree = al.GetRange(0, 3);
            PrintValues(firstThree);

            // Remove next two
            al.RemoveRange(3, 2);
            PrintValues(al);

            // Get, insert and remove
            object itemOne = al[1];
            al.Insert(1, "Moscow");
            al.RemoveAt(2);
            PrintValues(al);

            // Sort 
            al.Sort();
            PrintValues(al);

            // Search
            int targetIndex = al.BinarySearch("Moscow");
            Console.WriteLine("Index of Moscow: {0}", targetIndex);

            // Trim capacity
            al.TrimToSize();
            Console.WriteLine("Count:    {0}", al.Count);
            Console.WriteLine("Capacity: {0}", al.Capacity);

            // Creates a new ArrayList with five elements and initialize each element with a value.
            ArrayList al2 = ArrayList.Repeat("Boston", 5);   // static method
            PrintValues(al2);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("{0}   ", obj);
            Console.WriteLine();
        }

        public static void PrintValuesByEnumerator(IEnumerable myList)
        {
            IEnumerator ie = myList.GetEnumerator();
            while (ie.MoveNext())
            {
                Object obj = ie.Current;
                Console.Write("{0}   ", obj);
            }
            Console.WriteLine();
        }

    }
}
