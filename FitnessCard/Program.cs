using System;

namespace FitnessCard
{
    public class Program
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            
            decimal result = 0;

            switch (sport)
            {
                case "Gym":
                    {
                        if (gender == 'm')
                        {
                            result = 42;
                        }
                        else
                        {
                            result = 35;
                        }
                    }
                    break;
                case "Boxing":
                    {
                        if (gender == 'm')
                        {
                            result = 41;
                        }
                        else
                        {
                            result = 37;
                        }
                    }
                    break;
                case "Yoga":
                    {
                        if (gender == 'm')
                        {
                            result = 45;
                        }
                        else
                        {
                            result = 42;
                        }
                    }
                    break;
                case "Zumba":
                    {
                        if (gender == 'm')
                        {
                            result = 34;
                        }
                        else
                        {
                            result = 31;
                        }
                    }
                    break;
                case "Dances":
                    {
                        if (gender == 'm')
                        {
                            result = 51;
                        }
                        else
                        {
                            result = 53;
                        }
                    }
                    break;
                case "Pilates":
                    {
                        if (gender == 'm')
                        {
                            result = 39;
                        }
                        else
                        {
                            result = 37;
                        }
                    }
                    break;
                default:
                    break;
            }
            if (age <= 19)
            {
                result -= result * 20 / 100;
            }
            if (money >= result)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${result - money:f2} more.");
            }
        }
    }
}
