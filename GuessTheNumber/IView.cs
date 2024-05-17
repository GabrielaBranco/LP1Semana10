using System;

namespace GuessTheNumber
{
    public interface IView
    {
        void Welcome();
        void Congratulate(int attempts);
        void EndGame();
        int UserInput();
        void AskForInput();
        void InputTooHigh();
        void InputTooLow();
    }
}