using System;

namespace BitArray32
{
    public class BitArrayTest
    {
        public static void Main()
        {
            BitArray32 seven = new BitArray32(7);
            BitArray32 eight = new BitArray32(8);

            BitArray32 sum = seven + eight;
            Console.WriteLine(sum);

            seven[7] = 1;           
            Console.WriteLine(seven);            
        }
    }
}