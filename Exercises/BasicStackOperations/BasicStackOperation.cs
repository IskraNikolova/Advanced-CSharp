namespace BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperation
    {
        public static void Main(string[] args)
        {
            var commands =
                Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            var numbers =
                Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            Stack<int> stackNumber = new Stack<int>();
            FillTheStack(numbers, stackNumber);
            PopTheStack(commands, stackNumber);
            PrintResult(stackNumber, commands);
        }

        private static void FillTheStack(List<int> numbers, Stack<int> stackNumber)
        {
            foreach (var number in numbers)
            {
                stackNumber.Push(number);
            }
        }

        private static void PopTheStack(List<int> commands, Stack<int> stackNumber)
        {
            for (int i = 0; i < commands[1]; i++)
            {
                stackNumber.Pop();
            }
        }

        private static void PrintResult(Stack<int> stackNumber, List<int> commands)
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
