using System;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE = 798.50;

            
            int amountOfComputers = 0;
            int addComputers = 0;
            int subtractComputers = 0;
            const int MENU_OPTION_ONE = 1;
            const int MENU_TWO = 2;
            const int MENU_THREE =3;
            
            
            Console.Write("Enter the amount of computers: ");

            if(int.TryParse(Console.ReadLine(), out amountOfComputers))
            {
                if(amountOfComputers > 1)
                {
                    double totalValue= (double)amountOfComputers*PRICE;
                    Console.Write("1. Display the amount of computers and the total value" + 
                    "\n2. Add computers and display total value" + 
                    "\n3. Subtract computers and display total value" +
                    "\nPlease enter your selection: ");
                    if(int.TryParse(Console.ReadLine(), out int menuchoice))
                    {
                        DateTime dNow = DateTime.Now;
                        switch(menuchoice)
                        {
                            case MENU_OPTION_ONE:
                            
                            Console.WriteLine($"Computer Inventory Valuation {dNow.ToString()}");
                            Console.WriteLine($"Current Amount of Computers: {amountOfComputers} Total: {totalValue:C}");
                                break;
                            case MENU_TWO:
                            Console.Write("How many want to add?");
                            if(int.TryParse(Console.ReadLine(),out int plusComputers))
                            {
                                if(plusComputers>0)
                                {
                                    double addingComputers=plusComputers+amountOfComputers;
                                    double totalAddingComputers= addingComputers * PRICE;
                                    Console.WriteLine($"Computer Inventory Valuation {dNow.ToString()}");
                                    Console.WriteLine($"Current Amount of Computers: {amountOfComputers} Total: {totalValue:C}");
                                    Console.WriteLine("Add computer(s): " + plusComputers +
                                    $"\n total: {totalAddingComputers:C}");
                                }
                                else
                                Console.WriteLine("invalid");
                            }
                                break;
                            case MENU_THREE:
                            Console.Write("How many want to subtract?");
                            if(int.TryParse(Console.ReadLine(),out int minusComputers))
                            {
                                if(minusComputers>0)
                                {
                                    double addingComputers=minusComputers+amountOfComputers;
                                    double totalMinusComputers= addingComputers * PRICE;
                                    Console.WriteLine($"Computer Inventory Valuation {dNow.ToString()}");
                                    Console.WriteLine($"Current Amount of Computers: {amountOfComputers} Total: {totalValue:C}");
                                    Console.WriteLine("Subtract computer(s): " + minusComputers +
                                    $"\n total: {totalMinusComputers:C}");
                                }
                                else
                                Console.WriteLine("invalid");
                            }
                                break;
                            default: Console.WriteLine("Sorry, not a option!");
                                break;
                        }
                    }
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }


        }
    }
}
