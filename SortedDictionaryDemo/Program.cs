using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedSortedDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> sd = new SortedDictionary<string, double>();
            sd.Add("Chai", 18.0);
            sd.Add("Aniseed Syrup", 17.1);
            sd.Add("Chef Anton's Gumbo Mix", 28.58);
            PrintEntries(sd);   // note - sorted
            PrintKeys(sd);
            PrintValues(sd);


            // contains specific key?
            if (sd.ContainsKey("Chai"))
            {
                double val = sd["Chai"];
                Console.WriteLine("Found Chai, price: {0:c}.", val);

                sd.Remove("Chai");
            }

            // remove entry
            sd.Remove("Chai");

            PrintEntries(sd);

        }

        public static void PrintEntries(SortedDictionary<string, double> mySortedDictionary)
        {
            foreach (KeyValuePair<string, double> entry in mySortedDictionary)
            {
                Console.WriteLine("{0} price: {1:c}", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }

        public static void PrintKeys(SortedDictionary<string, double> mySortedDictionary)
        {
            // use foreach - can also use Enumerator
            foreach (string key in mySortedDictionary.Keys)
            {
                Console.WriteLine("{0}", key);
            }
            Console.WriteLine();
        }

        public static void PrintValues(SortedDictionary<string, double> mySortedDictionary)
        {
            // use Enumerator - can also use foreach
            SortedDictionary<string, double>.ValueCollection.Enumerator denum;
            denum = mySortedDictionary.Values.GetEnumerator();
            while (denum.MoveNext())
            {
                double value = denum.Current;
                Console.WriteLine("{0:c}", value);
            }
            Console.WriteLine();
        }
    }
}
