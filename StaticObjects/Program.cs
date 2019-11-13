using System;
using System.Text;

namespace StaticObjects
{
    class Program
    {
        static VideoGame[] games = new VideoGame[0];
        static void Main(string[] args)
        {                                    
            Console.WriteLine("Welcome to the Video Game library!");
            while(true)
            {
                Console.Write(GetMenu());
                string menuResponse = Console.ReadLine();

                switch(menuResponse)
                {
                    case "1":
                        VideoGame game = EnterGameInfo();
                        
                        Array.Resize(ref games, games.Length + 1);
                        games[games.Length - 1] = EnterGameInfo();

                    break;
                    case "2":
                        Console.Write("Enter the title that you are searching for: ");
                        string titleSearch = Console.ReadLine();

                        DisplayByTitle(titleSearch);
                    break;
                    case "3":
                        Console.Write("Enter the publisher that you want to filter by: ");
                        string publisherFilter = Console.ReadLine();
                        VideoGame game1 = DisplayPublisher(publisherFilter);
                        if(game1 == null)
                        {
                            Console.WriteLine($"No results for {publisherFilter}");
                        }
                        else
                        {
                            
                        }
                    break;
                    case "4":
                        Console.WriteLine("Thank you for using this program!");
                        System.Threading.Thread.Sleep(1000);
                        Environment.Exit(0);
                    break;                                        
                    default:
                        Console.WriteLine("Error: Invalid input");
                    continue;                    
                }                                             

                Array.Resize(ref games, games.Length + 1);
                games[games.Length - 1] = EnterGameInfo();

                Console.Write("Would like to enter another? (y/n): ");
                string response = Console.ReadLine().ToUpper();
                if(response == "Y")
                {
                    continue;
                }
                else if(response == "N")
                {
                    break;
                }
            }

            
                for(int i = 0; i < games.Length; i++)
                {
                    Console.WriteLine($"{games[i].ToString()}");
                }       
        }

        public static VideoGame DisplayPublisher(string publisherResponse)
        {
            for(int i = 0; i < games.Length; i ++)
            {
                if(games[i].Publisher == publisherResponse)
                {
                    return games[i];
                }                                
            }
            return null;
        }

        public static VideoGame DisplayByTitle(string menuResponse)
        {           
            for(int i = 0; i < games.Length; i ++)
            {
                if(games[i].Title == menuResponse)
                {
                    //Console.WriteLine($"{games[i].ToString()}");
                    return games[i];
                }                
            }
            return null;
        }

        public static VideoGame EnterGameInfo()
        {
            VideoGame game = new VideoGame();

            Console.Write("Please enter the title of the video game: ");
            string gameTitle = Console.ReadLine();
            Console.Write("Please enter the publisher of the title: ");
            string gamePublisher = Console.ReadLine();
            Console.Write("Please enter the price of the game: ");
            int gamePrice = int.Parse(Console.ReadLine());
            Console.Write("Please enter the year the game was released: ");
            int gameReleaseYear = int.Parse(Console.ReadLine());

            game = new VideoGame(gameTitle, gamePublisher, gamePrice, gameReleaseYear);
            return game;
        }
        public static string GetMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1. Create A Video Game");
            sb.Append("2. Display Video Game by Title");
            sb.Append("3. Display Video Game by Publisher");
            sb.Append("4. Exit");
            sb.Append("Enter your choice: ");
            return sb.ToString();
        }

        
    }// end class Program
}
