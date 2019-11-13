using System;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = new DateTime(2019, 9, 23);
            // DateTime startOfFallSemester = new DateTime(2019, 8, 26, 2, 0, 0);
            // TimeSpan ts = current - startOfFallSemester;
            // //int intTS = Convert.ToInt32(ts.TotalDays);
            // int intTS = (int)ts.TotalDays;
            
            // Console.WriteLine($"{intTS}");
            Console.WriteLine(current.ToString());
            // Console.WriteLine(current.ToShortDateString());
            // Console.WriteLine(intTS.ToString());

            DateTime dt = new DateTime(2003, 5, 1);
            Console.WriteLine("Is Thursday the day of the week for {0:d}?: {1}", 
                            dt, dt.DayOfWeek == DayOfWeek.Thursday);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);

           
            
     
            
        }
    }
}
