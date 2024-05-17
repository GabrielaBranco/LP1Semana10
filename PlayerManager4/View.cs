using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class View : IView
    {
        private readonly Controller controller;
        private readonly List<Player> players;
        public View(Controller controller, List<Player> players)
        {
            this.controller = controller;
            this.players = players;
        }
        public int MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");
            return int.Parse(Console.ReadLine());
        }

        public void EndMessage()
        {
            Console.WriteLine("Bye!");
        }

        public void InvalidOption()
        {
            Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
        }

        public void AfterMenu()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }
        public Player InsertPlayer()
        {
            string name;
            int score;

            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            return new Player(name, score);
        }

        public void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

        public int AskForMinimumScore()
        {
            Console.Write("\nMinimum score player should have? ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public PlayerOrder AskForPlayerOrder()
        {
            Console.WriteLine("Player order");
            Console.WriteLine("------------");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByScore}. Order by score");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByName}. Order by name");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByNameReverse}. Order by name (reverse)");
            Console.WriteLine("");
            Console.Write("> ");

            return Enum.Parse<PlayerOrder>(Console.ReadLine());
        }
    }
}