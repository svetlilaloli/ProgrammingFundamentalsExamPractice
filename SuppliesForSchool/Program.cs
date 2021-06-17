using System;

namespace SuppliesForSchool
{
    public class Program
    {
        public static void Main()
        {
            int penPacks = int.Parse(Console.ReadLine());
            int markerPacks = int.Parse(Console.ReadLine());
            double detergent = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            decimal result = (decimal)(penPacks * 5.8 + markerPacks * 7.2 + detergent * 1.2);
            result -= result * discount / 100;
            Console.WriteLine($"{result:f3}");
        }
    }
}
