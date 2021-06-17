using System;

namespace EnergyBooster
{
    public class Program
    {
        const double watermelonSmallSet = 56 * 2;
        const double watermelonBigSet = 28.7 * 5;
        const double mangoSmallSet = 36.66 * 2;
        const double mangoBigSet = 19.6 * 5;
        const double pineappleSmallSet = 42.1 * 2;
        const double pineappleBigSet = 24.8 * 5;
        const double raspberrySmallSet = 20 * 2;
        const double raspberryBigSet = 15.2 * 5;
        public static void Main()
        {
            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setCount = int.Parse(Console.ReadLine());
            decimal result = 0;

            switch (fruit)
            {
                case "Watermelon":
                    {
                        if (setSize == "small")
                        {
                            result = CalculatePrice(setCount, watermelonSmallSet);
                        }
                        else
                        {
                            result = CalculatePrice(setCount, watermelonBigSet);
                        }
                    }
                    break;
                case "Mango":
                    {
                        if (setSize == "small")
                        {
                            result = CalculatePrice(setCount, mangoSmallSet);
                        }
                        else
                        {
                            result = CalculatePrice(setCount, mangoBigSet);
                        }
                    }
                    break;
                case "Pineapple":
                    {
                        if (setSize == "small")
                        {
                            result = CalculatePrice(setCount, pineappleSmallSet);
                        }
                        else
                        {
                            result = CalculatePrice(setCount, pineappleBigSet);
                        }
                    }
                    break;
                case "Raspberry":
                    {
                        if (setSize == "small")
                        {
                            result = CalculatePrice(setCount, raspberrySmallSet);
                        }
                        else
                        {
                            result = CalculatePrice(setCount, raspberryBigSet);
                        }
                    }
                    break;
                default:
                    break;
            }
            if (400 <= result && result <= 1000)
            {
                result -= result * 15 / 100;
            }
            else if (result > 1000)
            {
                result /= 2;
            }
            Console.WriteLine($"{result:f2} lv.");
        }
        private static decimal CalculatePrice(int setCount, double pricePerUnit)
        {
            return setCount * (decimal)pricePerUnit;
        }
    }
}
