using System;

namespace MethodsTrialAndError
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 2;
            const int MAX_COLUMNS = 4;
            const int PRICE_OF_GAME = 60;
            bool loop = true;

            string[,] generalSystem = {{"Need For Speed: Most Wanted", "Borderlands 3", "Destiny 2", "Call of Duty: Modern Warfare"},
                                   {"BattleField 4", "GTA: San Andreas", "Forza Horizon 4", "Super Mario Sunshine"}};

            int[,] gamePrices = new int[MAX_ROWS,MAX_COLUMNS];

            for(int row = 0; row < MAX_ROWS; row ++)
            {
                for(int column = 0; column < MAX_COLUMNS; column ++)
                {
                    gamePrices[row, column] = PRICE_OF_GAME;
                }
            }

            while(loop)
            {
                DisplayText("Please enter the system you are purchasing for (PC or console)" +
                                    "\n1. PC" + 
                                    "\n2. Console" + 
                                    "\n3. Exit Program", true, ConsoleColor.Yellow);
                DisplayText(msg:"\nPlease enter your selection: ", color:ConsoleColor.Yellow);
                if(valueTrueFalse(Console.ReadLine(), out int userChoice))
                {
                    switch(userChoice)
                    {
                        case 1: 
                        case 2:
                            Loop(gamePrices, generalSystem, userChoice);
                        break;
                        case 3:
                            Environment.Exit(0);
                        break;
                        default: DisplayText("Error: Invalid input", true, ConsoleColor.Red);
                                continue;
                        
                    }
                }
                else
                {
                    DisplayText("Error: Invalid input", true, ConsoleColor.Red);
                    continue;
                }
            }  
        }


        private static void Loop(int[,] gamePrices, string[,] generalSystem, int userChoice)
        {
            for(int index3 = 0; index3 < generalSystem.GetLength(1); index3++)
            {
                DisplayText($"{generalSystem[userChoice - 1,index3]} + {gamePrices[userChoice - 1, index3]:C2}", true);
            }            
        }

        private static void DisplayText(string msg, bool newLine = false, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            if(newLine)
            {
                Console.WriteLine(msg);
            }
            else
            {
                Console.Write(msg);
            }
            Console.ResetColor();
        }

        private static bool ValidCheck(int userChoice)
        {
            if(userChoice > 0 && userChoice < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool valueTrueFalse(string message, out int userChoice)
        {
            
            if(int.TryParse(message, out int choice))
            {
                if(ValidCheck(choice))
                {
                    userChoice = choice;
                    return true;
                }
            }

            userChoice = choice;
            return false;
        }
    }
}
