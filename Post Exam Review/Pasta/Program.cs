using System;

namespace Pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ANGEL_HAIR = 3.95;
            const double LINGUINI = 4.25;
            const double FETTUNCINI = 4.50;
            const double FARFALLE = 4.25;
            const double PENNE = 4.00;
            const double TAX_RATE = .08;
            const double DOUBLE_ORDER = .60;

            const double BASIC_RED_SAUCE = 2.75;
            const double MARINARA= 2.90;
            const double MEAT_SAUCE= 4.50;
            const double ALFREDO_SAUCE= 4.75;

            const double GARLIC_BREAD = 2.50;
            const double MEATBALL_OR_SAUSAGE = 2.25;
            const double GARDEN_SALAD = 4.50;

            Console.Write("Would you like a single or double order? (1 = single, 2 = double)" +
            "\nPlease enter your selection: ");
            string orderChoice = Console.ReadLine();

            if(!(orderChoice == "1" || orderChoice == "2"))
            {
                Console.WriteLine("Exiting from the program..");
            }

            if(orderChoice == "1")
            {
                Console.Write("What kind of pasta would you like?" + 
                "\n1. Angel Hair" + 
                "\n2. Linguini" + 
                "\n3. Fettucini" + 
                "\n4. Farfalle" + 
                "\n5. Penne" +
                "\nPlease enter your selection: ");
                string pastaChoice = Console.ReadLine();
                switch(pastaChoice)
                {
                    case "1":  
                    Console.Write("What kind of sauce would you like?" +
                    "\n1. Basic Red Sauce"+
                    "\n2. Marinara"+
                    "\n3. Meat Sauce"+
                    "\n4. Alfredo Sauce"+
                    "\nPlease enter your selection:");
                    string sauceChoice = Console.ReadLine();
                    switch(sauceChoice)
                    {
                        case "1":
                        Console.Write("What side order would you like?"+
                        "\n1. Garlic Bread"+
                        "\n2. Meatball or Sausage"+
                        "\n3. Garden Salad");
                        string sideOrderChoice = Console.ReadLine();
                        switch(sideOrderChoice)
                        {
                            case "1":
                            break;
                        }
                            break;
                    }
                        break;
                }
            }
            else if(orderChoice == "2")
            {

            }
            else
            {
                Console.WriteLine("Error: Invalid input");
            }
        }
    }
}
