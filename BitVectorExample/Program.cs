using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace BitVectorExample
{
    class Program
    {
        public static void Main()
        {
            // UsageOne();
            UsageTwo();
            // UsageTwoAlternative();
        }

        public static void UsageOne()
        {

            // Creates and initializes a BitVector32.
            BitVector32 myBV = new BitVector32(0);

            // Creates four sections in the BitVector32 with maximum values 6, 3, 1, and 15.
            // mySect3, which uses exactly one bit, can also be used as a bit flag.
            BitVector32.Section mySect1 = BitVector32.CreateSection(6);
            BitVector32.Section mySect2 = BitVector32.CreateSection(3, mySect1);
            BitVector32.Section mySect3 = BitVector32.CreateSection(1, mySect2);
            BitVector32.Section mySect4 = BitVector32.CreateSection(15, mySect3);

            // Displays the values of the sections.
            Console.WriteLine("Initial values:");
            Console.WriteLine("\tmySect1: {0}", myBV[mySect1]);
            Console.WriteLine("\tmySect2: {0}", myBV[mySect2]);
            Console.WriteLine("\tmySect3: {0}", myBV[mySect3]);
            Console.WriteLine("\tmySect4: {0}", myBV[mySect4]);

            // Sets each section to a new value and displays the value of the BitVector32 at each step.
            Console.WriteLine("Changing the values of each section:");
            Console.WriteLine("\tInitial:    \t{0}", myBV.ToString());

            // set a value of sector 4 higher than its limit
            myBV[mySect1] = 7;

            Console.WriteLine("\tmySect1 = 5:\t{0}", myBV.ToString());
            myBV[mySect2] = 3;
            Console.WriteLine("\tmySect2 = 3:\t{0}", myBV.ToString());
            myBV[mySect3] = 1;
            Console.WriteLine("\tmySect3 = 1:\t{0}", myBV.ToString());

            // set a value of sector 4 higher than its limit
            myBV[mySect4] = 17;
            Console.WriteLine("\tmySect4 = 16:\t{0}", myBV.ToString());

            // Displays the values of the sections.
            Console.WriteLine("New values:");
            
            // Value 7 is displayed
            Console.WriteLine("\tmySect1: {0}", myBV[mySect1]);
            
            Console.WriteLine("\tmySect2: {0}", myBV[mySect2]);
            Console.WriteLine("\tmySect3: {0}", myBV[mySect3]);

            // Value 1 is displayed
            Console.WriteLine("\tmySect4: {0}", myBV[mySect4]);

            /*
             * Initial values:
             * mySect1: 0
             * mySect2: 0 
             * mySect3: 0
             * mySect4: 0
             * 
             * Changing the values of each section:
             * Initial:        BitVector32{00000000000000000000000000000000}
             * mySect1 = 5:    BitVector32{00000000000000000000000000000111}
             * mySect2 = 3:    BitVector32{00000000000000000000000000011111}
             * mySect3 = 1:    BitVector32{00000000000000000000000000111111}
             * mySect4 = 16:   BitVector32{00000000000000000000000001111111}
             * 
             * New values:
             * mySect1: 7
             * mySect2: 3
             * mySect3: 1
             * mySect4: 1
             */

        }


        /*
         * Usage 1 32bit integer to store two 3bit numbers
         * Example usage, 7 segment display
         */
        static public void UsageTwo(){
            // Creates and initializes a BitVector32.
            BitVector32 myBV = new BitVector32(0);
            BitVector32.Section MaxNumberSect = BitVector32.CreateSection(7);
            BitVector32.Section MaxNumberSect2 = BitVector32.CreateSection(7, MaxNumberSect);

            // rotate value between 0-7
            for (int i = 0; i < 20; i++)
            {
                myBV[MaxNumberSect] = i;
                myBV[MaxNumberSect2] = i;
                System.Console.WriteLine(myBV[MaxNumberSect]);
                System.Console.WriteLine(myBV[MaxNumberSect2]);
            }
        }

        /*
         * Usage 1 32bit integer to store two 3bit numbers
         * Example usage, 7 segment display
         */
        static public void UsageTwoAlternative()
        {
            int n = 0x00;

            for (int i = 0; i < 20; i++)
            {
                n = i & 0x7;
                System.Console.WriteLine(n);

                n = (i << 3) & 0x38;
                System.Console.WriteLine(n>>3);
            }
        }


    }
}
