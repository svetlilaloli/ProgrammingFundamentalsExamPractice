using System;

namespace CatWalking
{
    public class Program
    {
        public static void Main()
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int numberOfWalks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            int caloriesBurned = numberOfWalks * minutesWalk * 5;

            if (caloriesBurned >= calories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
