using System;

namespace Arrays_III
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_LENGTH = 6;
            string[] sports = new string[MAX_LENGTH];

            sports[0] = "volleyball";
            sports[1] = "basketball";
            sports[2] = "baseball";
            sports[3] = "field hockey";
            sports[4] = "rugby";
            sports[5] = "soccer";

            string[] moreSports = new string[sports.Length + 2];
            moreSports[0] = "volleyball";
            moreSports[1] = "basketball";
            moreSports[2] = "baseball";
            moreSports[3] = "field hockey";
            moreSports[4] = "rugby";
            moreSports[5] = "soccer";
            moreSports[6] = "badmination";
            moreSports[7] = "swimming";

            Array.Resize(ref sports, sports.Length + 1);
            sports[sports.Length - 1] = "American football";

                      for(int i = 0; i < 15; i--)
            {
                Console.WriteLine(i);
            }
         }
    }
}
