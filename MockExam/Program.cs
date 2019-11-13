using System;

namespace MockExam
{
    class Program
    {
    static string[] siteNames = new string[0];
    static DateTime[] dateVisited = new DateTime[0];
    static string[] states = new string[0];
    static bool loopWorks =true;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine($"MAD4CAMPING Data Collection\n{DateTime.Now}\n\n");

            DisplayMenu(new string[]
                {
                    "Enter a campsite",
                    "Display all campsites",
                    "Display all campsites for a specific state",
                    "Display record count",
                    "Exit"
                });

            while(loopWorks)
            {
                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch(choice)
                    {
                        case 1:
                            Console.Write("Please enter the name of the campsite");
                            CampsiteInfo(Console.ReadLine());
                            break;
                        case 2:
                            ReportAllCamp();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Console.Write("Do you want to exit this program? (Y/N): ");
                            if(Console.ReadLine().ToUpper() == "Y")
                            {
                                Environment.Exit(0);
                            }
                            else if(Console.ReadLine().ToUpper() == "N")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                                continue;
                            }
                            break;
                        default: Console.WriteLine("Sorry");
                            break;
                    }
                }
            }
        }

        private static void DisplayMenu(string[] menu)
        {   
            Console.WriteLine("Options:\n");        
            for(int index = 0; index < menu.Length; index++)
            {
                Console.WriteLine($"\t{index + 1}. {menu[index]}\n");
            }

            Console.Write("\n\tEnter your selection: ");            
        }

        private static void CampsiteInfo(string campName)
        {   
            if(campName == " ")
            {
                Console.WriteLine("Error: There must be an input");
                return;
            }
            else
            {                    
                Array.Resize(ref siteNames, siteNames.Length + 1);
                siteNames[siteNames.Length-1] = campName;

                Console.Write("Enter the date: ");
                string date = Console.ReadLine();
                if(date == " ")
                {
                    Console.WriteLine("Error: Must not be blank");
                    return;
                }
                else
                {
                    if(DateTime.TryParse(date, out DateTime storeDate))
                    {
                        Array.Resize(ref dateVisited, dateVisited.Length + 1);
                        dateVisited[dateVisited.Length] = storeDate;

                        Console.Write("Enter the state (New York, Texas, Washington): ");
                        string stateName = Console.ReadLine();
                        if(stateName == " ")
                        {
                            if(!int.TryParse(stateName, out int result))
                            {
                                Console.WriteLine("Error: Must not be blank");
                                return;
                            }
                            else
                            {

                            }
                            
                        }
                        else
                        {
                            Array.Resize(ref states, states.Length + 1);
                            states[states.Length] = stateName;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erorr: Invalid input");
                        return;
                    }
                }
            }
        }

        private static void ReportAllCamp()
        {
            Console.WriteLine("*** R E P O R T ***");
            for(int index = 0; index < siteNames.Length; index++)
            {
                Console.WriteLine($"{index+1}. {siteNames[index]} {dateVisited[index]}  {states[index]}");
            }
        }
    }
}
