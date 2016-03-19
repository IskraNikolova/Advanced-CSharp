using System;

namespace BitArray32
{
    public class BitArray32
    {
        private int value;

        public BitArray32(int value)
        {
            this.value = value;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 31)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(index), "Index must be in the range[0...31]");
                }

                int bit = (this.value >> index) & 1;

                return bit;
            }
            set
            {
                if (index < 0 || index > 31)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(index), "Index must be in the range[0...31]");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Argument must be either 1 or 0");
                }

                int mask = 1;
                this.value &= (mask << index);
                this.value |= value << index;
            }
        }

        public static BitArray32 operator +(BitArray32 bit1, BitArray32 bit2)
        {
            int sum = bit1.value + bit2.value;

            return new BitArray32(sum);
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}