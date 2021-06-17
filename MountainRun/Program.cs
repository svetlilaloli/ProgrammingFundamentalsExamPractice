using System;

namespace MountainRun
{
    public class Program
    {
        public static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            double time = secondsPerMeter * distance;

            int slowingDown = (int)(distance / 50) * 30;

            time += slowingDown;

            if (time < record)
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(time - record):f2} seconds slower.");
            }
        }
    }
}
