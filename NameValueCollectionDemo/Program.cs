using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NameValueCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection nv = new NameValueCollection();
            // note - multiple string values for the same key
            nv.Add("Minnesota", "St. Paul");
            nv.Add("Minnesota", "Minneapolis");
            nv.Add("Minnesota", "Rochester");
            nv.Add("Florida", "Miami");
            nv.Add("Florida", "Orlando");
            nv.Add("Arizona", "Phoenix");
            nv.Add("Arizona", "Tucson");

            // get the key at index 0
            string key = nv.GetKey(0);
            Console.WriteLine("Key 0: {0}", key);

            // remove entry for Minnesota by its key
            nv.Remove(key);

            // get values for Florida 
            foreach(string val in nv.GetValues("Florida"))
            {
                Console.WriteLine("A value for 'Florida': {0}", val);
            }

            // iterate through entries
            foreach(string k in nv)
            {
                // get values for each key as a comma-separated list
                Console.WriteLine("Key: {0} Values: {1}", k, nv.Get(k));
            }
        }
    }
}
