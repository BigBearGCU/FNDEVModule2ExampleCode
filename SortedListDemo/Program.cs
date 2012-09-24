using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace SortedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("Chai", 18.0);
            sl.Add("Aniseed Syrup", 17.1);
            sl.Add("Chef Anton's Gumbo Mix", 28.58);
            sl.Add("Chang", 10.5);
            PrintValues(sl);    // note - sorted
          

            // contains specific key?
            if (sl.ContainsKey("Chai"))
            {
                double val = (double)sl["Chai"];  
                Console.WriteLine("Found Chai, price: {0:c}.", val);

                int index = sl.IndexOfKey("Chang");
                double val2 = (double)sl.GetByIndex(index);    // can't use sl.Values[index]
                Console.WriteLine("Found Chang, price: {0:c}.\n", val2);
            }

            // contains specific value?
            if (sl.ContainsValue(17.1))
            {
                int index = sl.IndexOfValue(17.1);
                string key = (string)sl.GetKey(index);        // can't use sl.Keys[index]
                Console.WriteLine("Found 17.1, item: {0}.\n", key);
            }

            // remove entries
            sl.Remove("Chai");
            sl.RemoveAt(1);

            PrintValues(sl);

            // non-existent key
            int indexNotFound = sl.IndexOfKey("Chai");
            Console.WriteLine("Key not found, index: {0}\n", indexNotFound);
        }

        public static void PrintValues(IDictionary myDictionary)
        {
            foreach (DictionaryEntry entry in myDictionary)
            {
                Console.WriteLine("{0} price: {1:c}", entry.Key, entry.Value);
            }
            Console.WriteLine();

        }
    }
}
