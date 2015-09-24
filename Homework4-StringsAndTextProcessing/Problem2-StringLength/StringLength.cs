using System;
using System.Text;

public class StringLength
{
    /// <summary>
    /// A program that reads from the console a string of maximum 20 characters. 
    /// If the length of the string is less than 20, the rest of the characters should be filled with *. 
    /// Print the resulting string on the console.
    /// </summary>
    public static void Main()
    {
        const int maxLength = 20;

        //string input = Console.ReadLine();
        //StringBuilder result = new StringBuilder();
        //for (int i = 0; i < maxLength; i++)
        //{
        //    if (input.Length > i)
        //    {
        //        result.Append(input[i]);
        //    }
        //    else
        //    {
        //        result.Append('*');
        //    }
        //}

        //Console.WriteLine(result.ToString());

        string input = Console.ReadLine();
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(i < input.Length ? input[i] : '*');
        }
    }
}

