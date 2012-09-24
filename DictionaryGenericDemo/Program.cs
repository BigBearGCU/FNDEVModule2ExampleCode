using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("Chai", 18.0);
            dict.Add("Aniseed Syrup", 17.1);
            dict.Add("Chef Anton's Gumbo Mix", 28.58);
            PrintEntries(dict);
            PrintKeys(dict);
            PrintValues(dict);

            dict["Chai"] = 20.0;


            // contains specific key?
            if (dict.ContainsKey("Chai"))
            {
                //
                double val = dict["Chai"];
                Console.WriteLine("Found Chai, price: {0:c}.", val);

                dict.Remove("Chai");
            }

            // remove entry
            dict.Remove("Chai");

            PrintEntries(dict);

        }

        public static void PrintEntries(Dictionary<string,double> myDictionary)
        {
            foreach (KeyValuePair<string,double> entry in myDictionary)
            {
                Console.WriteLine("{0} price: {1:c}", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }

        public static void PrintKeys(Dictionary<string, double> myDictionary)
        {
            // use foreach - can also use Enumerator
            foreach (string key in myDictionary.Keys)
            {
                Console.WriteLine("{0}", key);
            }
            Console.WriteLine();
        }

        public static void PrintValues(Dictionary<string, double> myDictionary)
        {
            foreach (double val in myDictionary.Values)
            {
                Console.WriteLine("{0:c}", val);
            }
            // use Enumerator - can also use foreach
            //Dictionary<string, double>.ValueCollection.Enumerator denum;
            //denum = myDictionary.Values.GetEnumerator();
            //while (denum.MoveNext()) 
            //{
            //    double value = denum.Current;
            //    Console.WriteLine("{0:c}", value);
            //}
            Console.WriteLine();
        }
    }
}
