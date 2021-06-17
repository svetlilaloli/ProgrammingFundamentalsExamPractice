using System;

namespace ChangeBureau
{
    public class Program
    {
        public static void Main()
        {
            int bitcoin = int.Parse(Console.ReadLine());
            decimal cny = decimal.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            
            decimal usd = cny * 0.15M;
            decimal eur = (bitcoin * 1168 + usd * 1.76M) / 1.95M;
            decimal result = eur - eur * (decimal)commission / 100;
            Console.WriteLine($"{result:f2}");
        }
    }
}
