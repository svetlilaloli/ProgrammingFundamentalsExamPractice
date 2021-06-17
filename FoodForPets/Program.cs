using System;

namespace FoodForPets
{
    public class Program
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double biscuits = 0;
            double dogAteTotal = 0;
            double catAteTotal = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogEaten = double.Parse(Console.ReadLine());
                double catEaten = double.Parse(Console.ReadLine());
                dogAteTotal += dogEaten;
                catAteTotal += catEaten;

                if (i % 3 == 0)
                {
                    biscuits += (dogEaten + catEaten) * 10 / 100;
                }
            }

            double totalFoodEaten = dogAteTotal + catAteTotal;
            double percentFoodEaten = totalFoodEaten * 100 / totalFood;
            double percentDogAte = dogAteTotal * 100 / totalFoodEaten;
            double percentCatAte = catAteTotal * 100 / totalFoodEaten;

            PrintData(Math.Round(biscuits), percentFoodEaten, percentDogAte, percentCatAte);
        }
        private static void PrintData(double biscuits, double percentFoodEaten, double percentDogAte, double percentCatAte)
        {
            Console.WriteLine($"Total eaten biscuits: {biscuits}gr.");
            Console.WriteLine($"{percentFoodEaten:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDogAte:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCatAte:f2}% eaten from the cat.");
        }
    }
}
