using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
            {
                new Player("Ana", 100),
                new Player("Bruno", 500)
            };

            Controller controller = new Controller(players);

            IView view = new View(controller, players);

            controller.Start(view);
        }
    }
}
