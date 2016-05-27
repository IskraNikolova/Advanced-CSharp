namespace PoisonousPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PoisonousPlants
    {
        public static void Main()
        {
            Queue<int> plants = new Queue<int>();
            int countOfPlants = int.Parse(Console.ReadLine().Trim());

            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int fEl = input[0];
            for (int i = countOfPlants - 1; i >= 0; i--)
            {
                plants.Enqueue(input[i]);
            }

            bool isPlantDie = true;
            int count = -1;
            while (isPlantDie)
            {
                count++;
                isPlantDie = false;
                while (true)
                {
                    var rightPlant = plants.Dequeue();
                    var leftPlant = plants.Peek();
                    if (rightPlant <= leftPlant)
                    {
                        plants.Enqueue(rightPlant);
                    }
                    else
                    {
                        isPlantDie = true;
                    }

                    if (leftPlant == fEl)
                    {
                        var last = plants.Dequeue();
                        plants.Enqueue(last);
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
