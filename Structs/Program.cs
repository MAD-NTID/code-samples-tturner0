using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // using class
            // TimeClass tc = new TimeClass();
            // Console.WriteLine(tc.CalculateMinutes());

            // using struct
            // TimeStruct ts = new TimeStruct();
            // Console.WriteLine(ts.CalculateMinutes());

            int favoriteValue = 22;
            Console.WriteLine($"The value before calling the methods is: {favoriteValue}");
            AddFive(favoriteValue);
            Console.WriteLine($"The value after calling the AddFive method is: {favoriteValue}");
            AddThree(ref favoriteValue);
            Console.WriteLine($"The value after calling the AddThree method is: {favoriteValue}");
        }

        public static void AddFive(int value)
        {
            Console.WriteLine($"The value in the method is: {value}");
            value += 5;
            Console.WriteLine($"The value in the method after adding 5 is: {value}");
        }

        public static void AddThree(ref int value)
        {
            Console.WriteLine($"The value in the method is: {value}");
            value += 3;
            Console.WriteLine($"The value in the method after adding 3 is: {value}");
        }
    }
}
