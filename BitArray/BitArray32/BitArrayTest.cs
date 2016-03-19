using System;

namespace BitArray32
{
    public class BitArrayTest
    {
        public static void Main()
        {
            BitArray32 seven = new BitArray32(7);
            seven[7] = 1;           
            Console.WriteLine(seven);            
        }
    }
}