using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace OrderedDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary od = new OrderedDictionary();
            od.Add("Chai", 18.0);
            od.Add("Aniseed Syrup", 17.1);
            od.Add("Chef Anton's Gumbo Mix", 28.58);
            PrintValues(od);    // note - not sorted

            Console.WriteLine("Value of 'Chai':{0:c}.", od["Chai"]);
            Console.WriteLine("Value of item 0: {0:c}.", od[0]);

            // contains specific key?
            if (od.Contains("Chai"))
            {
                double val = (double)od["Chai"];
                Console.WriteLine("Found Chai, price: {0:c}.", val);

                //remove
                od.Remove("Chai");
            }

            PrintValues(od);
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
