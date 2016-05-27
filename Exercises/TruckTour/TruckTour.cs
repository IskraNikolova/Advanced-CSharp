namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TruckTour
    {
        public static void Main(string[] args)
        {

            int entries = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int entry = 0; entry < entries; entry++)
            {
                pumps.Enqueue(Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray());
            }
  
            for (int entry = 0; entry < entries; entry++)
            {
                if (IsSolution(entries, pumps))
                {
                    Console.WriteLine(entry);
                    break;
                }

                int[] startingPump = pumps.Dequeue();
                pumps.Enqueue(startingPump);
            }

        }

        public static bool IsSolution(int entries, Queue<int[]> pumps)
        {
            int tankFuel = 0;
            bool isEnav = true;

            for (int entry = 0; entry < entries; entry++)
            {
                int[] currPump = pumps.Dequeue();
                tankFuel += currPump[0] - currPump[1];
                if (tankFuel < 0)
                {
                    isEnav = false;
                }

                pumps.Enqueue(currPump);
            }

            return isEnav;
        }
    }
}