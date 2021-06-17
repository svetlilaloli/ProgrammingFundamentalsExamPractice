using System;

namespace TrekkingMania
{
    public class Program
    {
        public static void Main()
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            int musalaPeople = 0;
            int monblanPeople = 0;
            int kilimanjaroPeople = 0;
            int k2People = 0;
            int everestPeople = 0;

            for (int i = 0; i < groupsCount; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                totalPeople += numberOfPeople;
                if (numberOfPeople >= 41 )
                {
                    everestPeople += numberOfPeople;
                }
                else if (26 <= numberOfPeople && numberOfPeople <= 40 )
                {
                    k2People += numberOfPeople;
                }
                else if (13 <= numberOfPeople && numberOfPeople <= 25)
                {
                    kilimanjaroPeople += numberOfPeople;
                }
                else if (6 <= numberOfPeople && numberOfPeople <= 12)
                {
                    monblanPeople += numberOfPeople;
                }
                else
                {
                    musalaPeople += numberOfPeople;
                }
            }

            Console.WriteLine($"{GetPercentage(musalaPeople, totalPeople):f2}%");
            Console.WriteLine($"{GetPercentage(monblanPeople, totalPeople):f2}%");
            Console.WriteLine($"{GetPercentage(kilimanjaroPeople, totalPeople):f2}%");
            Console.WriteLine($"{GetPercentage(k2People, totalPeople):f2}%");
            Console.WriteLine($"{GetPercentage(everestPeople, totalPeople):f2}%");
        }
        private static double GetPercentage(int peopleGroup, int totalPeople)
        {
            return peopleGroup / (double)totalPeople * 100;
        }
    }
}
