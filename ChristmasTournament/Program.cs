using System;

namespace ChristmasTournament
{
    public class Program
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            
            decimal totalMoney = 0;
            int daysWon = 0;
            int totalWins = 0;
            int totalLoses = 0;

            for (int i = 0; i < days; i++)
            {
                int wins = 0;
                int loses = 0;
                decimal money = 0;
                string command = Console.ReadLine();

                while (command != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        money += 20;
                        wins++;
                    }
                    else
                    {
                        loses++;
                    }
                    command = Console.ReadLine();
                }
                
                if (wins > loses)
                {
                    money += money * 10 / 100;
                    daysWon++;
                }
                totalWins += wins;
                totalLoses += loses;
                totalMoney += money;
            }

            if (days - daysWon < (double)days / 2)
            {
                totalMoney += totalMoney * 20 / 100;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
