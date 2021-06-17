using System;

namespace CareOfPuppy
{
    public class Program
    {
        public static void Main()
        {
            int totalGramsFood = int.Parse(Console.ReadLine()) * 1000;
            string command = Console.ReadLine();
            int leftover = 0;
            int foodEaten = 0;

            while (command != "Adopted")
            {
                foodEaten += int.Parse(command);
                command = Console.ReadLine();
            }

            leftover = totalGramsFood - foodEaten;

            if (leftover >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {leftover} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(leftover)} grams more.");
            }
        }
    }
}
