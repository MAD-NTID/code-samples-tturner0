using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // VideoGame game = new VideoGame();
            // game.Title = "Need for Speed";
            // Console.WriteLine(game.ToString());

            VideoGame[] games = new VideoGame[0];

            VideoGame game;

            while(true)
            {
                game = new VideoGame();
                Console.Write("Please enter the title of the video game: ");
                string gameTitle = Console.ReadLine();
                Console.Write("Please enter the publisher of the title: ");
                string gamePublisher = Console.ReadLine();
                Console.Write("Please enter the price of the game: ");
                int gamePrice = int.Parse(Console.ReadLine());
                Console.Write("Please enter the year the game was released: ");
                int gameReleaseYear = int.Parse(Console.ReadLine());

                game = new VideoGame(gameTitle, gamePublisher, gamePrice, gameReleaseYear);

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
                    Console.WriteLine($"{games[i].ToString()}");
                }
        }
    }
}
