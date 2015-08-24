using System;
using System.Collections.Generic;

//Write a method which takes an array of any type and sorts it. Use bubble sort or selection sort 
//(your own implementation). You may re-use your code from a previous homework and modify it. 
//Use a generic method(read in Internet about generic methods in C#). 
//Make sure that what you're trying to sort can be sorted – your method should work with numbers, 
//strings, dates, etc., but not necessarily with custom classes like Student.


public class GenericArraySort
{
    public static void Main()
    {
        int[] numbers = {2, 4, 6, 1, -8};
        string[] text = {"zaz", "cba", "baa", "azis"};
        DateTime[] dates = {new DateTime(2014, 3, 9), new DateTime(2011, 11, 5), new DateTime(2005, 8, 7)};

        Console.WriteLine(String.Join( ",", SortArray(numbers)));
        Console.WriteLine(String.Join(",", SortArray(text)));
        Console.WriteLine(String.Join(",", SortArray(dates)));
    }

    //Selection Sort

    public static List<int> SortArray(int[] numbers)
    {
        List<int> sortedNumbers = new List<int>();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[smallest] > numbers[j])
                {
                    smallest = j;
                }
            }
         
            int swap = numbers[smallest];
            numbers[smallest] = numbers[i];
            numbers[i] = swap;
            sortedNumbers.Add(numbers[i]);
        }
        sortedNumbers.Add(numbers[numbers.Length - 1]);
        return sortedNumbers;
    }

    public static List<string> SortArray(string[] text)
    {
        List<string> sortedString = new List<string>();
        for (int i = 0; i < text.Length - 1; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < text.Length; j++)
            {
                if (text[smallest][0] > text[j][0])
                {
                    smallest = j;
                }
            }

            string swap = text[smallest];
            text[smallest] = text[i];
            text[i] = swap;
            sortedString.Add(text[i]);
        }
        sortedString.Add(text[text.Length-1]);
        return sortedString;
    }

    public static List<DateTime> SortArray(DateTime[] dates)
    {
        List<DateTime> sortedDates = new List<DateTime>();
        for (int i = 0; i < dates.Length - 1; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < dates.Length; j++)
            {
                if (dates[smallest] > dates[j])
                {
                    smallest = j;
                }
            }

            DateTime swap = dates[smallest];
            dates[smallest] = dates[i];
            dates[i] = swap;
            sortedDates.Add(dates[i]);
        }
        sortedDates.Add(dates[dates.Length - 1]);
        return sortedDates;
    }
}

