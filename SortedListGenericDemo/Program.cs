using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedListGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, double> sl = new SortedList<string, double>();
            sl.Add("Chai", 18.0);
            sl.Add("Aniseed Syrup", 17.1);
            sl.Add("Chef Anton's Gumbo Mix", 28.58);
            PrintEntries(sl);
            PrintKeys(sl);
            PrintValues(sl);


            // contains specific key?
            if (sl.ContainsKey("Chai"))
            {
                double val = sl["Chai"];
                Console.WriteLine("Found Chai, price: {0:c}.", val);

                int index = sl.IndexOfKey("Chai");
                double val2 = sl.Values[index];     // no GetByIndex method
                Console.WriteLine("Found Chai, price: {0:c}.\n", val2);
            }

            // contains specific value?
            if (sl.ContainsValue(17.1))
            {
                int index = sl.IndexOfValue(17.1);
                string key = sl.Keys[index];        // no GetKey method
                Console.WriteLine("Found 17.1, item: {0}.\n", key);
            }

            // remove entry
            sl.Remove("Chai");

            PrintEntries(sl);

        }

        public static void PrintEntries(SortedList<string, double> mySortedList)
        {
            foreach (KeyValuePair<string, double> entry in mySortedList)
            {
                Console.WriteLine("{0} price: {1:c}", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }

        public static void PrintKeys(SortedList<string, double> mySortedList)
        {
            // use foreach - can also use Enumerator
            foreach (string key in mySortedList.Keys)
            {
                Console.WriteLine("{0}", key);
            }
            Console.WriteLine();
        }

        public static void PrintValues(SortedList<string, double> mySortedList)
        {
            // use foreach - can't also use Enumerator with SortedList
            foreach (double value in mySortedList.Values)
            {
                Console.WriteLine("{0}", value);
            }
            Console.WriteLine();
        }
    }
}
