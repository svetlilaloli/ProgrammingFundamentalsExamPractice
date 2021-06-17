using System;

namespace BestPlayer
{
    public class Program
    {
        public static void Main()
        {                        
            string player = Console.ReadLine();
            string bestPlayerName = "";
            int bestPlayerGoals = 0;

            while (player != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > bestPlayerGoals)
                {
                    bestPlayerName = player;
                    bestPlayerGoals = goals;
                    if (goals >= 10)
                    {
                        break;
                    }
                }
                
                player = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayerName} is the best player!");
            if (bestPlayerGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
        }
    }
}
