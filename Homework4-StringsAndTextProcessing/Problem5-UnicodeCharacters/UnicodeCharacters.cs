using System;
using System.Text;

public class UnicodeCharacters
{
    /// <summary>
    /// A program that converts a string to a sequence of C# Unicode character literals.
    /// </summary>
    public static void Main()
    {
        string input = Console.ReadLine();
        PrintCPBytes(input, 8);
        //foreach (char character in input)
        //{
        //    Console.Write("\\u00{0:X}", (ushort)character);
        //}
        //Console.WriteLine();


    }
    public static void PrintCPBytes(string str, int codePage)
    {
        Encoding targetEncoding;
        byte[] encodedChars;

        // Gets the encoding for the specified code page.
        targetEncoding = Encoding.GetEncoding(codePage);

        // Gets the byte representation of the specified string.
        encodedChars = targetEncoding.GetBytes(str);

        // Prints the bytes.
        Console.WriteLine
                 ("Byte representation of '{0}' in Code Page  '{1}':", str,
                    codePage);
        for (int i = 0; i < encodedChars.Length; i++)
            Console.WriteLine("Byte {0}: {1}", i, encodedChars[i]);
    }
}

