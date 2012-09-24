using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionExample
{
    class AlternativeComparator<T,U> : Comparer<Node<T, U>> 
        where T: IComparable 
        where U: IComparable
    {

        public override int Compare(Node<T, U> x, Node<T, U> y)
        {
            int result =  -x.Value.CompareTo(y.Value);
            if (result == 0)
            {
                result = x.Key.CompareTo(y.Key);
            }

            return result;
        }
    }
}
