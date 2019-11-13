using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Console.Write("What is your first name?: ");
        //     string firstName = Console.ReadLine();

        //     Console.Write("What is your favorite number?: ");
        //     int favNum = int.Parse(Console.ReadLine());

        //     PrintHello(firstName, favNum);

        //     Console.Write("First number: ");
        //    int firstNum = int.Parse(Console.ReadLine());

        //     Console.Write("Second number: ");
        //     int secondNum = int.Parse(Console.ReadLine());

        //     Console.Write("What operator do you want to perform?: ");
        //     string op = Console.ReadLine();

        //     PerformCalculation(firstNum, secondNum, op);

            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("Enter integers only!");
            // Console.ResetColor();
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.Write("Enter your age: ");
            // Console.ResetColor();

            DisplayText("Enter integers only!", true, ConsoleColor.Red);
            DisplayText("Enter your age: ", false, ConsoleColor.Yellow);
        }

        private static void DisplayText(string message, bool newLine, ConsoleColor color)
        {
            Console.ForegroundColor = color;	// Set the foreground color to the passed value
            if ( newLine ) {			// Should we start a new line after
                Console.WriteLine(message);		// Write the message then start a new line
            }
            else
            {
            Console.Write(message);			// Write the message but DON’T start a new line
            } 
            Console.ResetColor();	
        }

        ///<summary>
        /// This performs a calculation based on the operator.
        /// Parameters: 
        ///</summary>
        private static void PerformCalculation(int firstNum, int secondNum, string op)
        {
            switch(op)
            {
                case "+":
                    Addition(firstNum, secondNum);
                    break;
                case "-":
                    Subtraction(firstNum, secondNum);
                    break;
                case "*":
                    Multiply(firstNum, secondNum);
                    break;
                case "/":
                    Divide(firstNum, secondNum);
                    break;
            }
        }

         private static void Addition(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
        }

        private static void Subtraction(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
        }

        private static void Multiply(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
        }

        private static void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / (double)secondNum}");
        }

        private static void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        private static void PrintHello(string message)
        {
            Console.WriteLine($"Hello {message}!");
        }

        private static void PrintHello(string message, int number)
        {
            Console.WriteLine($"Hello {message} and your favorite number is {number}!");
        }

       
    }
}
