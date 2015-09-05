using System;

public class ToTheStars
{
    public static void Main()
    {
        string[] starsInfo = new string[3];
        for (int i = 0; i < starsInfo.Length; i++)
        {
            starsInfo[i] = Console.ReadLine();
        }

        string normandyCoordinates = Console.ReadLine();
        double normandyX = double.Parse(normandyCoordinates.Split(' ')[0]);
        double normandyY = double.Parse(normandyCoordinates.Split(' ')[1]);

        int moveUp = int.Parse(Console.ReadLine());

        for (double step = normandyY; step <= normandyY + moveUp; step++)
        {
            bool isCoincidence = false;

            for (int i = 0; i < starsInfo.Length; i++)
            {
                string starName = starsInfo[i].Split(' ')[0];
                double starX = double.Parse(starsInfo[i].Split(' ')[1]);

                double starY = double.Parse(starsInfo[i].Split(' ')[2]);

                if ((normandyX >= starX - 1 && normandyX <= starX + 1) &&
                    step >= starY - 1 && step <= starY + 1)
                {
                    Console.WriteLine(starName.ToLower());
                    isCoincidence = true;
                }
            }

            if (isCoincidence == false)
            {
                Console.WriteLine("space");
            }
        }
    }
}

