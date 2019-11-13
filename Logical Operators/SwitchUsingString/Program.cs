using System;

namespace SwitchUsingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Portillos! Here are the menu");
            Console.Write("1. Italian Beef\n2. Gyro\n3. Cheeseburger\n\nType in the name of the meal: ");
            string foodChoice = Console.ReadLine().ToLower();

            switch(foodChoice)
            {
                case "italian beef":
                    Console.WriteLine("You have selected an Italian Beef");
                    break;
                case "gyro":
                    Console.WriteLine("You selected a Gyro.");
                    break;
                case "cheeseburger":
                    Console.WriteLine("You selected a Cheeseburger");
                    break;
                default:
                    Console.WriteLine("The option that you selected does not exist.");
                    break;
            }
        }
    }
}
