using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_LENGTH = 3;
            string[] sports = new string[MAX_LENGTH];
            
            // sports[0] = "volleyball";
            // sports[1] = "basketball";
            // sports[2] = "baseball";
            // sports[3] = "field hockey";
            // sports[4] = "rugby";
            // sports[5] = "soccer";
            Console.WriteLine($"You have {sports.Length} sports that need to be listed");
            for(int i = 0; i < sports.Length; i++)
            {
                Console.Write($"Enter sport #{i}: ");
                sports[i] = Console.ReadLine();
            }

            for(int index =0; index < sports.Length; index++)
            {
                Console.WriteLine($"{index}. {sports[index]}");
            }
            
            Console.Write("Select a sport: ");
            string option = Console.ReadLine();
            for(int index = 0; index < sports.Length; index++)
            {
                if(index.ToString() == option)
                {
                    Console.WriteLine(sports[index]);
                }
            }

            
            for(int diffentIndex =5; diffentIndex <= 15; diffentIndex++)
            {
                Console.WriteLine(diffentIndex);
            }// AFTER this

            
        }
    }
}
