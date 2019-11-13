using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {      
            const double MAX_COMMISSION = .09;
            const double MIN_COMMISSION = .06;
            const string MAKE = "Nissan";
            const double BONUS = 750.0;     
            Console.Write("Enter sales: ");
            int salesAmount = int.Parse(Console.ReadLine());
            Console.Write("What is the make of the car: ");
            string make = Console.ReadLine();
            


            int minSalesAmount = 10000;
            double commissionRate = 0;

            if(salesAmount >= minSalesAmount)
            {
                commissionRate = salesAmount * MAX_COMMISSION;

                if(make == MAKE)
                {
                    commissionRate += BONUS; // commissionRate = commissionRate + BONUS;
                }
            }
            else
            {
                commissionRate = salesAmount * MIN_COMMISSION;
            }

            Console.WriteLine("Commission: $" + commissionRate);
        }
    }
}
