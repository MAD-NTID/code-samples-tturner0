using System;

/*  Context:    Practice Practical Exam 1 - 2191
    Name:       Tiger Bucks
    Author:     Prof. R.
    Date:       22 September 2019
    Description: Begins with entering a starting balance then prompts the user for either
                a deposit, purchase, or balance display.  Deposits (other than the initial
                deposit) are limited to $500.
 */
namespace TigerBucks_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAXIUMUM_DEPOSIT = 500.00;

            double balance = 0.0;
            double transaction = 0.0;
            int choice;

            // Get the starting balance
            Console.Clear();
            Console.WriteLine("** Welcome to Tiger Bucks **\n");
            Console.Write("Enter the starting balance: ");
            if (! double.TryParse(Console.ReadLine(), out balance)) {
                Console.WriteLine("Invalid starting balance -- Program cancelled");
                Environment.Exit(1);
            } else {
                if ( balance < 0 ) {
                    Console.WriteLine("Starting Balance cannot be less than zero -- Program Cancelled");
                    Environment.Exit(2);
                }
            }
            // we have the starting balance
            // show the menu
            Console.WriteLine();
            Console.WriteLine("Make a selection from the list below:");
            Console.WriteLine("1 -- Add funds to the account");
            Console.WriteLine("2 -- Make a purchase");
            Console.WriteLine("3 -- Display current balance");
            Console.Write("Enter your selection (1-3): ");
            if (! int.TryParse(Console.ReadLine(), out choice)) {
                Console.WriteLine("Invalid data entered -- Program Cancelled");
                Environment.Exit(3);
            } else {
                if ( choice < 0 || choice > 3 ) {
                    Console.WriteLine("Invalid selection entered -- Program Cancelled");
                    Environment.Exit(4);
                }
            }
            switch (choice) {
                case 1:                 // deposit
                    Console.WriteLine();
                    Console.Write("Enter the amount to add to the account: ");
                    if (! double.TryParse(Console.ReadLine(), out transaction)){
                        Console.WriteLine("Invalid data entered -- Program Cancelled");
                        Environment.Exit(5);
                    } else {
                        if (transaction <= 0) {
                            Console.WriteLine("Amount must be greater than zero -- Program Cancelled");
                            Environment.Exit(6);
                        } else {
                            if ( transaction > MAXIUMUM_DEPOSIT ) {
                                Console.WriteLine("Amount Entered exceeds maximum allowed -- Program Cancelled");
                                Environment.Exit(7);
                            } else {
                                balance += transaction;
                                Console.WriteLine();
                                Console.WriteLine("** Receipt **");
                                Console.WriteLine(DateTime.Now.ToString());
                                Console.WriteLine("Amount Deposited:  {0,8:C}", transaction);
                                Console.WriteLine("New Balance:       {0,8:C}", balance);
                            }
                        }
                    }
                    break;
                case 2:                 // purchase
                    Console.WriteLine();
                    Console.Write("Enter the amount of the purchase: ");
                    if (! double.TryParse(Console.ReadLine(), out transaction)) {
                        Console.WriteLine("Invalid data entered -- Program Cancelled");
                        Environment.Exit(8);
                    } else {
                        if (transaction <= 0 ) {
                            Console.WriteLine("Purchase amount must be greater than zero -- Program Cancelled");
                            Environment.Exit(9);
                        } else {
                            if (transaction > balance) {
                                Console.WriteLine("Purchase Amount cannot be greater than account balance -- Program Cancelled");
                                Environment.Exit(10);
                            } else {
                                balance -= transaction; // balance = balance - transaction
                                Console.WriteLine();
                                Console.WriteLine("** Receipt **");
                                Console.WriteLine(DateTime.Now.ToString());
                                Console.WriteLine("Purchase Amount:   {0,8:C}", transaction);
                                Console.WriteLine("New Balance:       {0,8:C}", balance);
                            }
                        }
                    }
                    break;
                    case 3: //display balance
                        Console.WriteLine();
                        Console.WriteLine("** Receipt **");
                        Console.WriteLine(DateTime.Now.ToString());
                        Console.WriteLine("Balance:           {0,8:C}", balance);
                        break;
            
                default:
                    Console.WriteLine("This should not ever happen!");
                    break;
            }

        Console.WriteLine();
        Console.WriteLine();
        }
    }
}
