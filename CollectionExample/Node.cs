
using System;

namespace CollectionExample
{
	public class Node<T,U> : IComparable<Node<T,U>>
		where T : IComparable
		where U : IComparable
	{
		private T _Key;
		private U _Value;
		
		public T Key {
			set {
				_Key = value;
			}
			
			get {
				return _Key;
			}
		}
		
		public U Value {
			set {
				_Value = value;
			}
			
			get {
				return _Value;
			}
		}
		
		public int CompareTo (Node<T, U> other)
		{
			return Key.CompareTo(other.Key);
		}

        public override string ToString()
        {
            return string.Format("[{0}: {1}]", Key, Value);
        }

	}
}
