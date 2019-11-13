using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_LENGTH = 20;
            string[] sports = new string[MAX_LENGTH];

            sports[0] = "volleyball";
            sports[1] = "basketball is awesome";
            sports[2] = "baseball";
            sports[3] = "field hockey";
            sports[4] = "rugby";
            sports[5] = "soccer";
            
            Console.Write("Pick a number (1 - " + sports.Length + ") and see what sport you have selected: ");
            int selection = int.Parse(Console.ReadLine());
            //int newSelection = selection - 1;

            if(selection >= 1 && selection <= sports.Length)
            {
                if(sports[selection] != null)
                    Console.WriteLine($"You selected {sports[--selection]}");
                else
                {
                    Console.WriteLine("There is nothing");
                }
            }
        }
    }
}
