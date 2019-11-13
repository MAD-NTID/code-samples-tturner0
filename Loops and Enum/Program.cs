using System;

namespace Loops_and_Enum
{
    class Program
    {
         enum DaysOfWeek {Monday =1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
        static void Main(string[] args)
        {
            int number =0;
            
            int counter = 1;
            while(number != -99)
            {
                Console.Write($"Enter test #{counter} score (-99 to exit): ");
                if(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid Input. Not an integer");
                    continue;
                }
                counter++;
                
                
            }

            // Console.WriteLine($"Today is {(int)DaysOfWeek.Monday}");
        }
    }
}
