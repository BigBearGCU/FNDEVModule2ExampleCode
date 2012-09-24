using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> aList = new List<DateTime>();

            Action<DateTime> listAction;

            aList.Add(new DateTime(1968, 4, 5));
            aList.AddRange(new DateTime[] {
                new DateTime(1965, 1, 19),
                new DateTime(1994, 12, 3),
                new DateTime(1966, 2, 1),
                new DateTime(1997, 7, 2)});

            Console.WriteLine("Count:    {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            PrintValues(aList);

            // Get second item in list
            DateTime dt = aList[1];     // no need to cast, no unboxing (DateTime items stored as an array of value types)
            Console.WriteLine("aList[1] = {0}", dt.ToShortDateString());

            // Trim capacity
            aList.TrimExcess();    // c.f. TrimToSize in non-generic list
            Console.WriteLine("Count:    {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            // Get first three items
            List<DateTime> firstThree = aList.GetRange(0, 3);
            PrintValues(firstThree);

            // Remove next two
            aList.RemoveRange(3, 2);

            // sort and binary search
            aList.Sort();
            int index = aList.BinarySearch(new DateTime(1968, 4, 5));
            Console.WriteLine("Index of item '4 April 1968' is {0}.", index);
            PrintValues(aList);

            // foreach using Action delegate
            Console.WriteLine("Listing using ForEach");
            listAction = PrintDate;
            aList.ForEach(listAction);

            // find using a Predicate
            List<DateTime> sixtiesDates = aList.FindAll(IsSixties);
            Console.WriteLine("Sixties dates");
            PrintValues(sixtiesDates);
        }

        public static void PrintValues(IEnumerable<DateTime> myList)
        {
            foreach (DateTime dt in myList)
            {
                Console.WriteLine("{0}", dt.ToShortDateString());
            } 
        }

        private static void PrintDate(DateTime dt)
        {
            Console.WriteLine("{0}", dt.ToShortDateString());
        }

        private static bool IsSixties(DateTime dt)
        {
            if (dt.Year >= 1960 && dt.Year < 1970)
                return true;
            else
                return false;
        }

    }
}
