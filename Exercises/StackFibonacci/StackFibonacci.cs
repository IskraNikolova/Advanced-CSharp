using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            Stack<long> fibonacciNumber = new Stack<long>();

            fibonacciNumber.Push(1);
            fibonacciNumber.Push(1);

            long num = long.Parse(Console.ReadLine().Trim());
            for (int i = 1; i < num; i++)
            {
                long lastIn = fibonacciNumber.Pop();
                long firstIn = fibonacciNumber.Pop();

                fibonacciNumber.Push(lastIn + firstIn);
                fibonacciNumber.Push(firstIn);
            }

            Console.WriteLine(fibonacciNumber.Peek());
        }
    }
}
