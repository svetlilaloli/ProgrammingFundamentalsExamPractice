using System;

namespace SuitcasesLoad
{
    public class Program
    {
        public static void Main()
        {
            double capacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int count = 0;
            double currentVolumeFilled = 0;

            while (command != "End")
            {
                double suitcaseVolume = double.Parse(command);
                
                if ((count + 1) % 3 == 0)
                {
                    suitcaseVolume += suitcaseVolume * 10 / 100;
                }

                if (currentVolumeFilled + suitcaseVolume > capacity)
                {
                    break;
                }
                currentVolumeFilled += suitcaseVolume;
                count++;

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine($"No more space!");
            }
            Console.WriteLine($"Statistic: {count} suitcases loaded.");
        }
    }
}
