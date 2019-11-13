using System;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] videoGameTitles = new string[0];
            // string[] videoGamePublishers = new string[0];

            // int[] prices = new int[0];
            // int[] yearReleased = new int[0];
            VideoGame[] games = new VideoGame[0];

            VideoGame game;

            while(true)
            {
                // game = new VideoGame();
                Console.Write("Please enter the title of the video game: ");
                string gameTitle = Console.ReadLine();
                Console.Write("Please enter the publisher of the title: ");
                string gamePublisher = Console.ReadLine();
                Console.Write("Please enter the price of the game: ");
                int gamePrice = int.Parse(Console.ReadLine());
                Console.Write("Please enter the year the game was released: ");
                int gameReleaseYear = int.Parse(Console.ReadLine());

                game = new VideoGame(gameTitle, gamePublisher, gamePrice, gameReleaseYear);

                // game.SetTitle(gameTitle);
                // game.SetPublisher(gamePublisher);
                // game.SetPrice(gamePrice);
                // game.SetReleasedYear(gameReleaseYear);

                // Array.Resize(ref videoGameTitles, videoGameTitles.Length + 1);
                // Array.Resize(ref videoGamePublishers, videoGamePublishers.Length + 1);
                // Array.Resize(ref prices, prices.Length + 1);
                // Array.Resize(ref yearReleased, yearReleased.Length + 1);

                // videoGameTitles[videoGameTitles.Length - 1] = gameTitle;
                // videoGamePublishers[videoGamePublishers.Length - 1]  = gamePublisher;
                // prices[prices.Length - 1] = gamePrice;
                // yearReleased[yearReleased.Length - 1] = gameReleaseYear;

                Array.Resize(ref games, games.Length + 1);
                games[games.Length - 1] = game;

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
                    Console.WriteLine($"{games[i].GetTitle()} {games[i].GetPublisher()} {games[i].GetPrice()} {games[i].GetReleasedYear()}");
                }
        }
    }
}
