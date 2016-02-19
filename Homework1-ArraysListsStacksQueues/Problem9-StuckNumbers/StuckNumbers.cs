namespace Problem9_StuckNumbers
{
    using System;

    public class StuckNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string[] inputNumbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            bool check = false;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                for (int j = 0; j < inputNumbers.Length; j++)
                {
                    for (int k = 0; k < inputNumbers.Length; k++)
                    {
                        for (int l = 0; l < inputNumbers.Length; l++)
                        {
                            if (inputNumbers[i] != inputNumbers[j] && inputNumbers[i] != inputNumbers[k] &&
                                inputNumbers[i] != inputNumbers[l] && inputNumbers[j] != inputNumbers[k] &&
                                inputNumbers[j] != inputNumbers[l] && inputNumbers[k] != inputNumbers[l])
                            {
                                if (inputNumbers[i] + inputNumbers[j] == inputNumbers[k] + inputNumbers[l])
                                {
                                    Console.WriteLine("{0}|{1}=={2}|{3}", inputNumbers[i], inputNumbers[j],
                                        inputNumbers[k], inputNumbers[l]);

                                    check = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!check)
            {
                Console.WriteLine("No");
            }
        }
    }
}