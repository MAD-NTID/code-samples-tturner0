using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            // const int MIN_DRIVING_AGE = 16;

            // Console.Write("Enter your age: ");
            
            // if(int.TryParse(Console.ReadLine(), out int age))
            // {
            //     if(age >= 0)
            //     {
            //         if(age >= MIN_DRIVING_AGE)
            //         {
            //             Console.WriteLine("You're allowed to drive");
            //         }
            //         else
            //         {
            //             Console.WriteLine("You're not allowed to drive");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("Sorry, can't go below 0!");
            //     }
            // }
            // else
            //     Console.WriteLine("Invalid Input");

            string dorm;
            double GPA = 4.0;
            string MadStudent = "true";
            dorm = ( GPA > 3.0 && MadStudent == "true") ? "MAD House" : "Slacker House" ;
            Console.WriteLine(dorm);

        }
    }
}
