using System;

namespace AluminumJoinery
{
    public class Program
    {
        public static void Main()
        {
            int joineryCount = int.Parse(Console.ReadLine());
            string joineryType = Console.ReadLine();
            string delivery = Console.ReadLine();
            decimal pricePerUnit = 0;
            int discount = 0;
            decimal totalPrice;

            if (joineryCount < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (joineryType)
            {
                case "90X130":
                    {
                        pricePerUnit = 110;
                        if (joineryCount >= 60)
                        {
                            discount = 8;
                        }
                        else if (joineryCount >= 30)
                        {
                            discount = 5;
                        }
                    }
                    break;
                case "100X150":
                    {
                        pricePerUnit = 140;
                        if (joineryCount >= 80)
                        {
                            discount = 10;
                        }
                        else if (joineryCount >= 40)
                        {
                            discount = 6;
                        }
                    }
                    break;
                case "130X180":
                    {
                        pricePerUnit = 190;
                        if (joineryCount >= 50)
                        {
                            discount = 12;
                        }
                        else if (joineryCount >= 20)
                        {
                            discount = 7;
                        }
                    }
                    break;
                case "200X300":
                    {
                        pricePerUnit = 250;
                        if (joineryCount >= 50)
                        {
                            discount = 14;
                        }
                        else if (joineryCount >= 25)
                        {
                            discount = 9;
                        }
                    }
                    break;
            }

            totalPrice = joineryCount * pricePerUnit;
            totalPrice -= totalPrice * discount / 100;

            if (delivery == "With delivery")
            {
                totalPrice += 60;
            }
            if (joineryCount > 99)
            {
                totalPrice -= totalPrice * 4 / 100;
            }
            Console.WriteLine($"{totalPrice:f2} BGN");
        }
    }
}
