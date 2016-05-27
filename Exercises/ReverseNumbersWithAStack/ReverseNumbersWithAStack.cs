namespace ReverseNumbersWithAStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            var inputNumber = Console.ReadLine()
                .Trim()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            Stack<int> reversedNumber = new Stack<int>();
            foreach (var number in inputNumber)
            {
                reversedNumber.Push(number);
            }

            Console.WriteLine(string.Join(" ", reversedNumber));
        }
    }
}
