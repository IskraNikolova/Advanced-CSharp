using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {
            var commands =
                Console.ReadLine()
                    .Trim()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            var numbers =
                Console.ReadLine()
                    .Trim()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            Queue<int> stackNumber = new Queue<int>();
            FillTheStack(numbers, stackNumber);
            PopTheStack(commands, stackNumber);
            PrintResult(stackNumber, commands);
        }

        private static void FillTheStack(List<int> numbers, Queue<int> stackNumber)
        {
            foreach (var number in numbers)
            {
                stackNumber.Enqueue(number);
            }
        }

        private static void PopTheStack(List<int> commands, Queue<int> stackNumber)
        {
            for (int i = 0; i < commands[1]; i++)
            {
                stackNumber.Dequeue();
            }
        }

        private static void PrintResult(Queue<int> stackNumber, List<int> commands)
        {
            if (stackNumber.Count <= 0)
            {
                Console.WriteLine(0);
                return;
            }

            bool isContains = stackNumber.Contains(commands[2]);
            if (isContains)
            {
                Console.WriteLine("true");
            }
            else
            {
                int minValue = stackNumber.Min();
                Console.WriteLine(minValue);
            }
        }
    }
}
