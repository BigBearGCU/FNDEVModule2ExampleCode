using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace BitVector32Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BitVector32 bv = new BitVector32(0);   // all flags set to false
            
            // create masks to isolate each of the first five bit flags
            int myBit1 = BitVector32.CreateMask(0);
            int myBit2 = BitVector32.CreateMask(myBit1);
            int myBit3 = BitVector32.CreateMask(myBit2);
            int myBit4 = BitVector32.CreateMask(myBit3);
            int myBit5 = BitVector32.CreateMask(myBit4);

            Console.WriteLine(bv.ToString());    // ToString() shows bit pattern

            // set alternating bits to true
            bv[myBit1] = true;
            bv[myBit3] = true;
            bv[myBit5] = true;

            Console.WriteLine(bv.ToString());

            BitVector32 bv2 = new BitVector32(255);   // all flags set to binary representation of 255
            Console.WriteLine(bv2.ToString());

            BitVector32 bv3 = new BitVector32(0);   // all flags set to false

            // create sections with max values 6,3,1 and 12
            BitVector32.Section mySect1 = BitVector32.CreateSection(6);
            BitVector32.Section mySect2 = BitVector32.CreateSection(3, mySect1);
            BitVector32.Section mySect3 = BitVector32.CreateSection(1, mySect2);
            BitVector32.Section mySect4 = BitVector32.CreateSection(12, mySect3);

            Console.WriteLine("mySect1 - offset:{0}, mask:{1}", mySect1.Offset, Convert.ToString(mySect1.Mask, 2));
            Console.WriteLine("mySect2 - offset:{0}, mask:{1}", mySect2.Offset, Convert.ToString(mySect2.Mask, 2));
            Console.WriteLine("mySect3 - offset:{0}, mask:{1}", mySect3.Offset, Convert.ToString(mySect3.Mask, 2));
            Console.WriteLine("mySect4 - offset:{0}, mask:{1}", mySect4.Offset, Convert.ToString(mySect4.Mask, 2));

            bv3[mySect1] = 5;
            bv3[mySect2] = 3;
            bv3[mySect3] = 1;
            bv3[mySect4] = 9;

            Console.WriteLine(bv3.ToString());

            int bv3Data = bv3.Data;

            Console.WriteLine("value of bv3: {0}", bv3Data);
        }

    }
}
