using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Chai", 18.0);
            ht.Add("Aniseed Syrup", 17.1);
            ht.Add("Chef Anton's Gumbo Mix", 28.58);
            PrintValues(ht);    // note - not sorted

            // contains specific key?
            if(ht.Contains("Chai"))
            {
                double val = (double)ht["Chai"];
                Console.WriteLine("Found Chai, price: {0:c}.", val);

                //remove
                ht.Remove("Chai");
            }

            PrintValues(ht);
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
