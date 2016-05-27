using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    public class BalancedParentheses
    {
        public static void Main()
        {
            const char openFirstBracket ='(';
            const char closeFirstBracket =')';
            const char openSecondBracket ='{';
            const char closeSecondBracket ='}';
            const char openThirdBracket ='[';
            const char closeThirdBracket =']';
            string inputLine = Console.ReadLine();

            Stack<int> openingBracketsIndices = new Stack<int>(); 
            CheckForBalanced(inputLine, openingBracketsIndices, openFirstBracket, closeFirstBracket);
            Stack<int> openingBracketsIndices2 = new Stack<int>();
            CheckForBalanced(inputLine, openingBracketsIndices2, openSecondBracket, closeSecondBracket);
            Stack<int> openingBracketsIndices3 = new Stack<int>();
            CheckForBalanced(inputLine, openingBracketsIndices3, openThirdBracket, closeThirdBracket);
        }

        private static void CheckForBalanced(string inputLine, Stack<int> openingBracketsIndices, char openBracket, char closeBracket)
        {
            for (int i = 0; i < inputLine.Length; i++)
            {
                var currentSymbol = inputLine[i];
                if (currentSymbol == openBracket)
                {
                    openingBracketsIndices.Push(i);
                }
                else if (currentSymbol == closeBracket)
                {
                    if (openingBracketsIndices.Count == 0)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }

                    openingBracketsIndices.Pop();
                }
            }

            if (openingBracketsIndices.Count > 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
            Console.WriteLine("YES");
        }
    }
}
