using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace BitArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(3);
            ba1[0] = true;
            ba1[1] = false;
            ba1[2] = true;
            Console.Write("ba1: ");
            PrintValues(ba1);

            BitArray ba2 = new BitArray(new bool[] { true, true, false });
            Console.Write("ba2: ");
            PrintValues(ba2);

            // bitwise operations
            ba1.And(ba2);
            Console.Write("ba1 after AND: ");
            PrintValues(ba1);

            ba1.Or(ba2);
            Console.Write("ba1 after OR: ");
            PrintValues(ba1);

            ba1.Xor(ba2);
            Console.Write("ba1 after XOR: ");
            PrintValues(ba1);

            // set bits
            ba1[2] = true;
            Console.Write("ba1 after set: ");
            PrintValues(ba1);

            ba2.SetAll(true);
            Console.Write("ba2 after set all true: ");
            PrintValues(ba2);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("{0} ", obj);
            Console.WriteLine();
        }
    }
}
