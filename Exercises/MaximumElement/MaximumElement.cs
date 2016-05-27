namespace MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumElement
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            
            Stack<int> stackCollection = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            int maxElement = int.MinValue;
            for (int i = 0; i < linesCount; i++)
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "2":
                        if (stackCollection.Peek() == maxStack.Peek() && maxStack.Count > 0)
                        {
                            maxStack.Pop();
                            if (maxStack.Count > 0)
                            {
                                maxElement = maxStack.Peek();
                            }
                            else
                            {
                                maxElement = int.MinValue;
                            }
                        }

                        stackCollection.Pop();                      
                        break;
                    case "3":
                        Console.WriteLine(maxStack.Peek());
                        break;
                    default:
 
                        int value = int.Parse(command.Split()[1]);
                        if (maxElement < value)
                        {
                            maxElement = value;
                            maxStack.Push(maxElement);
                        }
                        stackCollection.Push(value);
                        break;
                }           
            }
        }
    }
}
