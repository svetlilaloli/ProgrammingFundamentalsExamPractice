using System;

namespace AgencyProfit
{
    public class Program
    {
        public static void Main()
        {
            string companyName = Console.ReadLine();
            int adultTicketsNumber = int.Parse(Console.ReadLine());
            int childTicketsNumber = int.Parse(Console.ReadLine());
            decimal adultNettPrice = decimal.Parse(Console.ReadLine());
            decimal serviceTax = decimal.Parse(Console.ReadLine());

            decimal childNettPrice = adultNettPrice - adultNettPrice * 70 / 100;

            decimal adultTicketCost = adultNettPrice + serviceTax;

            decimal childTicketCost = childNettPrice + serviceTax;

            decimal totalTicketsPrice = adultTicketsNumber * adultTicketCost + childTicketsNumber * childTicketCost;

            decimal myProfit = totalTicketsPrice * 20 / 100;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {myProfit:f2} lv.");
        }
    }
}
