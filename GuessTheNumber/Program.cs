using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            IView view = new View();
            Model model = new Model();
            Controller controller = new Controller(view, model);
            controller.GameLoop();
        }
    }
}