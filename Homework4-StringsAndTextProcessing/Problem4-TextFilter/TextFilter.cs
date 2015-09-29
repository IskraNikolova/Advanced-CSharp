using System;

public class TextFilter
{
    /// <summary>
    /// A program that takes a text and a string of banned words. All words included in the ban list should be replaced with 
    /// asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
    /// </summary>
    public static void Main()
    {
        string[] banWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        foreach (var word in banWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(text);
    }
}


