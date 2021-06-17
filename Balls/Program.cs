using System;
using System.Collections.Generic;

namespace Balls
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            Dictionary<string, int> coloursCount = new Dictionary<string, int>();
            coloursCount.Add("red", 0);
            coloursCount.Add("orange", 0);
            coloursCount.Add("yellow", 0);
            coloursCount.Add("white", 0);
            coloursCount.Add("black", 0);
            coloursCount.Add("other", 0);

            for (int i = 0; i < n; i++)
            {
                string colour = Console.ReadLine();
                switch (colour)
                {
                    case "red": totalPoints += 5; coloursCount["red"]++; break;
                    case "orange": totalPoints += 10; coloursCount["orange"]++; break;
                    case "yellow": totalPoints += 15; coloursCount["yellow"]++; break;
                    case "white": totalPoints += 20; coloursCount["white"]++; break;
                    case "black": totalPoints /= 2; coloursCount["black"]++; break;
                    default: coloursCount["other"]++; break;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {coloursCount["red"]}");
            Console.WriteLine($"Points from orange balls: {coloursCount["orange"]}");
            Console.WriteLine($"Points from yellow balls: {coloursCount["yellow"]}");
            Console.WriteLine($"Points from white balls: {coloursCount["white"]}");
            Console.WriteLine($"Other colors picked: {coloursCount["other"]}");
            Console.WriteLine($"Divides from black balls: {coloursCount["black"]}");
        }
    }
}
