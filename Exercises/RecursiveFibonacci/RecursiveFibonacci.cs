using System;
using System.Collections.Generic;

namespace RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        private static long[] memo;
        private static long counter;
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            memo = new long[number + 1];
            counter = 0;
            Console.WriteLine(FibWithMemo(number));
        }

        static long FibWithMemo(long number)
        {
            if (memo[number] != 0)
            {
                return memo[number];
            }

            counter++;
            if (number == 0)
            {
                return 0;
            }

            if (number == 1)
            {
                return 1;
            }

            memo[number] = FibWithMemo(number - 1) + FibWithMemo(number - 2);
            return memo[number];
        }
    }
}