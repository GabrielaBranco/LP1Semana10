using System;

namespace GuessTheNumber
{
    public class Controller
    {   private View view;
        private Model model;
        public Controller(View view, Model model)
        {
            this.view = view;
            this.model = model;
        }

        public void GameLoop()
        {
            view.Welcome();
            while (!model.GuessedCorrectly)
            {
                view.AskForInput();
                model.Set_Guess(view.UserInput());
                model.Attempts_Set();

                if (model.Guess == model.targetNumber)
                {
                    view.Congratulate(model.Attempts);
                    model.GuessedCorrectly_Set(true);
                }
                else if (model.Guess < model.targetNumber)
                {
                    view.InputTooLow();
                }
                else
                {
                    view.InputTooHigh();
                }
            }
        }
    }
}