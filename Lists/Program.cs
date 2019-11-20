using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VideoGame> games = new List<VideoGame>(50);
            VideoGameStruct vgs = new VideoGameStruct();
            vgs.Title = "Title";
            //Console.WriteLine(games.Capacity);
            //VideoGame[] games = new VideoGame[0];

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

                Console.Write("Would you like to put this in the beginning of the list? (y/n): ");

                if(Console.ReadLine().ToUpper()[0] == 'Y')
                    games.Insert(0, game);
                else
                    games.Add(game);

                // Array.Resize(ref games, games.Length + 1);
                // games[games.Length - 1] = game;

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

            for(int i = 0; i < games.Count; i++)
            {
                Console.WriteLine($"{i +1}. {games[i].Title}");
            }
            Console.Write("Which game would you like to remove?: ");
            int positionToRemove = int.Parse(Console.ReadLine());

            games.RemoveAt(positionToRemove -1);
            
            Console.WriteLine($"There are {games.Count} in the list.");
            // for(int i = 0; i < games.Count; i++)
            // {
            //     Console.WriteLine($"{games[i].ToString()}");
            // }

            int index = 0;
            foreach(VideoGame currentGame in games)
            {
                Console.WriteLine($"Video Game #{index +1}\n{currentGame.ToString()}");
                index++;
            }

            games.Clear();
            Console.WriteLine($"There are {games.Count} in the list.");
        }
    }
}
