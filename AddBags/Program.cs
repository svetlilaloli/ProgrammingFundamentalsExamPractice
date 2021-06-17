using System;

namespace AddBags
{
    public class Program
    {
        public static void Main()
        {
            decimal above20LuggagePrice = decimal.Parse(Console.ReadLine());
            double kgLuggage = double.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());
            int numberOfLuggage = int.Parse(Console.ReadLine());
            decimal totalPrice;

            if (kgLuggage < 10)
            {
                totalPrice = above20LuggagePrice * 20 / 100;
            }
            else if (10 <= kgLuggage && kgLuggage <= 20) 
            {
                totalPrice = above20LuggagePrice * 50 / 100;
            }
            else
            {
                totalPrice = above20LuggagePrice;
            }

            if (daysLeft > 30)
            {
                totalPrice += totalPrice * 10 / 100;
            }
            else if (7 <= daysLeft && daysLeft <= 30)
            {
                totalPrice += totalPrice * 15 / 100;
            }
            else if (daysLeft < 7)
            {
                totalPrice += totalPrice * 40 / 100;
            }
            totalPrice *= numberOfLuggage;

            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
