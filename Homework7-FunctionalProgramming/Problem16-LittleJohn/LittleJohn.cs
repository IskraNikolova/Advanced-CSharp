using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class LittleJohn
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.AppendFormat(" {0}", Console.ReadLine());
        }
        string pattern = @"(>>>----->>)|(>>----->)|(>----->)";
        Regex regex = new Regex(pattern);
        MatchCollection matchesArrow = regex.Matches(sb.ToString());

        int smallArrowCount = 0;
        int mediumArrowCount = 0;
        int largeArrowCount = 0;

        foreach (Match arrow in matchesArrow)
        {
            if (!string.IsNullOrEmpty(arrow.Groups[1].Value))
            {
                largeArrowCount++;
            }
            else if (!string.IsNullOrEmpty(arrow.Groups[2].Value))
            {
                mediumArrowCount++;
            }
            else
            {
                smallArrowCount++;
            }
        }
        string numAsString = String.Format("{0}{1}{2}", smallArrowCount, mediumArrowCount, largeArrowCount);
        int number = int.Parse(numAsString);
        string binaryNum = Convert.ToString(number, 2);
        string reverseBinaryNum = new string(binaryNum.Reverse().ToArray());
        string resultAsString = binaryNum + reverseBinaryNum;
        long result = Convert.ToInt64(resultAsString, 2);
        Console.WriteLine(result);
    }
}

