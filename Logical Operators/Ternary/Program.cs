using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 3;

switch(myVar)
{
    case 1:
        Console.WriteLine("Welcome");
        break;
    case 2:
        Console.WriteLine(" to ");
        break;
    case 3:
        Console.WriteLine(" the fourth quiz!");
        break;
    case 4:
        Console.WriteLine("Welcome to the fourth quiz!");
        break;
    default:
        Console.WriteLine("Nothing happened");
        break;

} 
            // const int MIN_DRIVING_AGE = 16;

            // Console.Write("Enter your age: ");
            // string ageString = Console.ReadLine();

            // if(int.TryParse(ageString, out int age))
            // {
            //     // CHALLENGE STUDENTS
            //     if(age >= 0)
            //     {
            //         // if(age >= MIN_DRIVING_AGE)
            //         // {
            //         //     Console.WriteLine("You're allowed to drive");
            //         // }
            //         // else
            //         // {
            //         //     Console.WriteLine("You're not allowed to drive");
            //         // }

            //         //string result = age >= MIN_DRIVING_AGE ? "allowed" : "not allowed";
            //         //Console.WriteLine($"You're {(age >= MIN_DRIVING_AGE) ? "allowed" : "not allowed"} to drive");
            //         //Console.WriteLine($"You're {0} to drive", (age >= MIN_DRIVING_AGE ? "allowed" : "not allowed"));

                    
            //     }
            //     else
            //     {
            //         Console.WriteLine("Age cannot be negative");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Invalid Input");
            // }


            // if(age >= MIN_DRIVING_AGE)
            // {

            // }

        }
    }
}
