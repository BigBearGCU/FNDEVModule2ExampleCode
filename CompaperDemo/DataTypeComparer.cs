using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ComparerDemo
{
    public class DataTypeComparer : IComparer
    {
        public DataTypeComparer() 
        { 
        }

        public int Compare(object obj1, object obj2)
        {
            return obj1.GetType().ToString().
               CompareTo(obj2.GetType().ToString());
        }
    }

}
