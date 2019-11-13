using System;
using System.Threading;

/*  Context:    Practice Practical Exam 1 - 2191
    Name:       Burger Joint
    Author:     Prof. Turner
    Date:       22 September 2019
    Description: Begins with items on a menu. Allows users to select their preferences.
                 Once they complete with their choices, the receipt will be displayed.
*/
namespace BurgerJoint
{
    class Program
    {
        static void Main(string[] args)
         {
            // the prices of the menu that includes sales tax and the title of receipt
            const double SALES_TAX = .08;
            const double BASIC_PRICE_OF_BURGER = 4.95;
            const double PRICE_OF_EXTRA_BURGER_PATTY = 1.50;
            const double PRICE_OF_CHEESE = .75;
            const double PRICE_OF_BACON = 1.25;
            const double PRICE_OF_FRIES = 2.25;
            const double PRICE_OF_ONION_RINGS = 3.15;
            const double PRICE_OF_SMALL_SODA = 1;
            const double PRICE_OF_LARGE_SODA = 2;
            const double PRICE_OF_JUICE = 2.25;
            const double PRICE_OF_MILK_SHAKE = 4;
            const string TITLE_OF_RECEIPT = "Recepit Order"; // usually does not change unless you include the number 
                                                                 // which will increment by 1

            // reuse variables
            int selection;
            double subtotal = BASIC_PRICE_OF_BURGER; // initalizing the subtotal with the basic price of a burger
            double tax;
            double finalTotal;
            string receiptContents = $"Burger {BASIC_PRICE_OF_BURGER,15:C}"; // initalizing with the information of a basic burger

            // Display the burger section
            Console.Write("Hello, Welcome to the Burger Joint! How may I take your order?\n\n" +
                          "\t1. Extra Patty\n\t2. Cheese\n\t3. Bacon\n\t4. None\nChoose one of the items that you want to go on the burger: ");
            
            // Prevent program from crash
            if(int.TryParse(Console.ReadLine(), out selection))
            {
                switch(selection)
                {
                    case 1: 
                        subtotal += PRICE_OF_EXTRA_BURGER_PATTY;
                        receiptContents += $"\n  Extra Patty {PRICE_OF_EXTRA_BURGER_PATTY,8:C}";
                        break;
                    case 2: 
                        subtotal += PRICE_OF_CHEESE;
                        receiptContents += $"\n  Cheese      {PRICE_OF_EXTRA_BURGER_PATTY,8:C}";
                        break;
                    case 3: 
                        subtotal += PRICE_OF_BACON;
                        receiptContents += $"\n  Bacon       {PRICE_OF_BACON,8:C}";
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("The option you selected doesn't exist. Exiting from the program...");
                        Thread.Sleep(3000);
                        Environment.Exit(1);
                        break;
                }

                // Display the sides section
                Console.Write("\n\t1. French Fries\n\t2. Onion Rings\n\t3. Both\n\t4. None\nChoose the preference of sides: ");
            
                if(int.TryParse(Console.ReadLine(), out selection))
                {
                    switch(selection)
                    {
                        case 1: 
                            subtotal += PRICE_OF_FRIES;
                            receiptContents += $"\n\nFrench Fries {PRICE_OF_FRIES,9:C}";
                            break;
                        case 2: subtotal += PRICE_OF_ONION_RINGS;
                            receiptContents += $"\n\nOnion Rings {PRICE_OF_ONION_RINGS,10:C}";
                            break;
                        case 3: subtotal += PRICE_OF_FRIES + PRICE_OF_ONION_RINGS;
                            receiptContents += $"\n\nFrench Fries {PRICE_OF_FRIES,8:C}" +
                                               $"\nOnion Rings {PRICE_OF_ONION_RINGS,10:C}";
                            break;
                        case 4: break; //do nothing
                        default:
                            Console.WriteLine("The option you selected doesn't exist. Exiting from the program...");
                            Thread.Sleep(3000);
                            Environment.Exit(1);
                            break;
                    }

                    // Display the Drinks section
                    Console.Write("\n\t1. Small Soda\n\t2. Large Soda\n\t3. Juice\n\t4. Milk Shake\n\t5. Water\nChoose the preference of drinks: ");

                    if(int.TryParse(Console.ReadLine(), out selection))
                    {
                        switch(selection)
                        {
                            case 1: 
                                subtotal += PRICE_OF_SMALL_SODA;
                                receiptContents += $"\n\nSmall Soda {PRICE_OF_SMALL_SODA,11:C}";
                                break;
                            case 2:
                                subtotal += PRICE_OF_LARGE_SODA;
                                receiptContents += $"\n\nLarge Soda {PRICE_OF_LARGE_SODA,11:C}";
                                break;
                            case 3: 
                                subtotal += PRICE_OF_JUICE;
                                receiptContents += $"\n\nJuice {PRICE_OF_JUICE,16:C}";
                                break;
                            case 4:
                                subtotal += PRICE_OF_MILK_SHAKE;
                                receiptContents += $"\n\nMilk Shake {PRICE_OF_MILK_SHAKE,11:C}";
                                break;
                            case 5:
                                receiptContents += $"\n\nWater {0,16:C}"; // Free Water
                                break;
                            default:
                                Console.WriteLine("The option you selected doesn't exist. Exiting from the program...");
                                Thread.Sleep(3000);
                                Environment.Exit(1);
                                break;
                        }

                        tax = subtotal * SALES_TAX;
                        finalTotal = subtotal + tax;
                        receiptContents += $"\n\nSubtotal: {subtotal,12:C}" +
                                           $"\nTax:        {tax,10:C}" +
                                           $"\nTotal:      {finalTotal,10:C}";

                        
                        // need to add the datetime before printing out the order                     
                        Console.WriteLine($"\n\n\t\t{TITLE_OF_RECEIPT}\n\t     {DateTime.Now}\n\n{receiptContents}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Exiting from the program...");
                        Thread.Sleep(3000);
                        Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Exiting from the program...");
                    Thread.Sleep(3000);
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Exiting from the program...");
                Thread.Sleep(3000);
                Environment.Exit(1);
            }
        }
    }
}
