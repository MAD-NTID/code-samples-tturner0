using System;

/*
    Context:    PFI Exam I, 2191
    Title:      Bonus
    Date:       22 September 2019
    Description: Program to determine amount of change from a sale and how
                to return that change to the customer
 */
namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            const double HUNDRED_BILL = 100.00;
            const double FIFTY_BILL = 50.00;
            const double TWENTY_BILL = 20.00;
            const double TEN_BILL = 10.00;
            const double FIVE_BILL = 5.00;
            const double ONE_BILL = 1.00;
            const double QUARTER = .25;
            const double DIME = .10;
            const double NICKLE = .05;
            const double PENNY = .01;

            double saleAmount;
            double amountTendered;
            double change;
            int count;

            Console.Clear();
            Console.WriteLine("** Change Maker **\n");
            Console.Write("Enter the amount of the sale: ");
            if (! double.TryParse(Console.ReadLine(), out saleAmount)) {
                Console.WriteLine("You must enter a valid number -- Program Cancelled");
                Environment.Exit(1);
            } else {
                if (saleAmount <= 0) {
                    Console.WriteLine("Sale Amount must be greater than zero -- Program Cancelled");
                    Environment.Exit(2);
                }
            }
            Console.Write("Enter the amount tendered: ");
            if (! double.TryParse(Console.ReadLine(), out amountTendered)) {
                Console.WriteLine("You must enter a valid number -- Program Cancelled");
                Environment.Exit(3);
            } else {
                if (amountTendered < saleAmount) {
                    Console.WriteLine("Amount tendered must be greater than or equal to sale amount -- Program Cancelled");
                    Environment.Exit(4);
                }
            }

            change = amountTendered - saleAmount;

            Console.WriteLine();
            Console.WriteLine("Sale Amount:        {0,9:c}", saleAmount);
            Console.WriteLine("Amount Tendered:    {0,9:c}", amountTendered);
            Console.WriteLine("Change:             {0,9:c}", change);
            Console.WriteLine();

            Console.WriteLine("Return the following:");
            count = (int) (change / HUNDRED_BILL);
            if (count > 0) Console.WriteLine("Hundred Dollar Bill(s):   {0,2}", count);
            change = change % HUNDRED_BILL;
            count = (int) (change / FIFTY_BILL);
            if (count > 0) Console.WriteLine("Fifty Dollar Bill(s):     {0,2}", count);
            change = change % FIFTY_BILL;
            count = (int) (change / TWENTY_BILL);
            if (count > 0) Console.WriteLine("Twenty Dollar Bill(s):    {0,2}", count);
            change = change % TWENTY_BILL;
            count = (int) (change / TEN_BILL);
            if (count > 0) Console.WriteLine("Ten Dollar Bill(s):       {0,2}", count);
            change = change % TEN_BILL;
            count = (int) (change / FIVE_BILL);
            if (count > 0) Console.WriteLine("Five Dollar Bill(s):      {0,2}", count);
            change = change % FIVE_BILL;
            count = (int) (change / ONE_BILL);
            if (count > 0) Console.WriteLine("One Dollar Bill(s):       {0,2}", count);
            change = change % ONE_BILL;
            count = (int) (change / QUARTER);
            if (count > 0) Console.WriteLine("Quarters:                 {0,2}", count);
            change = change % QUARTER;
            count = (int) (change / DIME);
            if (count > 0) Console.WriteLine("Dimes:                    {0,2}", count);
            change = change % DIME;
            count = (int) (change / NICKLE);
            if (count > 0) Console.WriteLine("Nickles:                  {0,2}", count);
            change = change % NICKLE;
            count = (int) (change / PENNY);
            if (count > 0) Console.WriteLine("Pennies:                  {0,2}", count);
            change = change % PENNY;


            

        }
    }
}
