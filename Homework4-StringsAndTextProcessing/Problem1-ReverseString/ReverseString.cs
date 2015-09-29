﻿using System;
using System.Linq;
using System.Text;

public class ReverseString
{
    /// <summary>
    /// A program that reads a string from the console, reverses it and prints the result back at the console.
    /// </summary>
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder reverse = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse.Append(input[i]);
        }

        Console.WriteLine(string.Join("", reverse));

        //string input = Console.ReadLine();
        //string output = new string(input.Reverse().ToArray());
        //Console.WriteLine(output);
    }
}

