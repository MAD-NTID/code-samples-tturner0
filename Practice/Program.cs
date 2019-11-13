using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Pick a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine ("Hello,  " + name + "! and you picked " + number + ".");

            int result = (int)(7 + 3.0/4.0 * 2);
            Console.WriteLine(result);

        }
    }
}