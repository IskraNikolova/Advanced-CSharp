using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class WordCount
{
    /// <summary>
    /// A program that reads a list of words from the file words.txt and finds how many times each of the words
    ///  is contained in another file text.txt. 
    ///Write the results in file results.txt.Sort the words by frequency in descending order. 
    /// Use StreamReader in combination with StreamWriter.
    /// </summary>
    public static void Main()
    {
        StreamReader readerWords = new StreamReader("Words.txt");
        StreamReader readerText = new StreamReader("Text.txt");
        StreamWriter writer = new StreamWriter("Result.txt");

        using (readerWords)
        {
            using (readerText)
            {
                using (writer)
                {
                    string text = readerText.ReadToEnd();
                    SortedDictionary<int, string> sortResult = new SortedDictionary<int, string>();
                    List<string> result = new List<string>();
                    while (true)
                    {
                        int count = 0;
                        string line = readerWords.ReadLine();
                        
                        if (line == null)
                        {
                            foreach (var pair in sortResult)
                            {
                               result.Add($"{pair.Value} - {pair.Key}");
                            }
                            for (int i = result.Count - 1; i >= 0; i--)
                            {
                                writer.WriteLine(result[i]);
                            }
                            break;
                        }
                        string[] textToArr = text.Split(new []{' ', '.', ',', '-', '\r', '?', '!'}).ToArray();
                       
                        for (int i = 0; i < textToArr.Length; i++)
                        {
                            if (line == textToArr[i].ToLower())
                            {
                                count++;
                            }
                        }
                        sortResult[count] = line;
                    }
                }
            }
        }
    }
}

