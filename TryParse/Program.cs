using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CURRENT_YEAR = 2019;
            Console.Write("Enter your birth year: ");
            string birthYearString = Console.ReadLine();
            bool yearOfBirth = int.TryParse(birthYearString, out int birthYear);
            int numAccount = 2300150;
            double accountBalance = 200.50;

            // if the input is valid and proceed to calculate the year and show the account number and balance
            if(yearOfBirth)
            {
                int age = CURRENT_YEAR - birthYear;
                Console.WriteLine($"You're born in {birthYear} and you're {age:N3} years old!");
                Console.WriteLine("{0,-15:D} {1,15:C}", numAccount, accountBalance);
                Console.WriteLine($"{numAccount,-15:D} {accountBalance,15:C}");
            }
            else
            {
                Console.WriteLine("Nice try!");
            }
        }
    }
}
