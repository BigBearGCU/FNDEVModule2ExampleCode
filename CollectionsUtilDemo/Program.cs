using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace CollectionsUtilDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = CollectionsUtil.CreateCaseInsensitiveHashtable();
            ht.Add("UK", "London");
            Console.WriteLine("Capital of UK: {0}", ht["uk"]);

            SortedList sl = CollectionsUtil.CreateCaseInsensitiveSortedList();
            sl.Add("USA", "Washington D.C.");
            Console.WriteLine("Capital of USA: {0}", sl["uSa"]);
        }
    }
}
