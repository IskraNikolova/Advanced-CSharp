namespace SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleTextEditor
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());
            Stack<string> undoCollection = new Stack<string>();
            string textEditor = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string[] commands =
                    Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (commands[0])
                {
                    case "1":
                        undoCollection.Push(textEditor);
                        textEditor += commands[1];
                        break;
                    case "2":
                        undoCollection.Push(textEditor);
                        int index = textEditor.Length - int.Parse(commands[1]);
                        textEditor = textEditor.Remove(index, int.Parse(commands[1]));
                        break;
                    case "3":
                        Console.WriteLine(textEditor[int.Parse(commands[1]) - 1]);
                        break;
                    case "4":
                        textEditor = undoCollection.Peek();
                        undoCollection.Pop();
                        break;
                }
            }
        }
    }
}
