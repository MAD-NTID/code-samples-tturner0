using System;

namespace TryParseWithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // string foodChoice;
            //int foodOption;
            Console.WriteLine("Welcome to Portillos! Here are the menu");
            Console.Write("1. Italian Beef\n2. Gyro\n3. Cheeseburger\n\nSelect a meal: ");
            //string foodChoice = Console.ReadLine();

            //bool isOptionValid = int.TryParse(foodChoice, out int foodOption);
            bool isOptionValid = int.TryParse(Console.ReadLine(), out int foodOption);

            if(isOptionValid)
            {
                switch(foodOption)
                {
                    case 1:
                        Console.WriteLine("You have selected an Italian Beef");
                        break;
                    case 2:
                        Console.WriteLine("You selected a Gyro.");
                        break;
                    case 3:
                        Console.WriteLine("You selected a Cheeseburger");
                        break;
                    default:
                        Console.WriteLine("The option that you selected does not exist.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
