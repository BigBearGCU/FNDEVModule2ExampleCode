using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueGenericDemo
{
    // class with public inner struct - similar to Queue<T>.Enumerator
    // example usage:
    //      MyClass.MyStruct myStruct = new MyClass.MyStruct(3);
    //      int val = myStruct.AStructProperty;
    public class MyClass
    {
        int _aClassProperty;

        public MyClass() { }

        public int AClassProperty
        {
            get { return _aClassProperty; }
            set { _aClassProperty = value; }
        }

        public struct MyStruct
        {
            int _aStructProperty;

            public MyStruct(int value) 
            {
                _aStructProperty = value;
            }

            public int AStructProperty
            {
                get { return _aStructProperty; }
                set { _aStructProperty = value; }
            }
        }
    }
}
