using System;

namespace GuessTheNumber
{
    public class Model
    {
        Random random = new Random();
        public readonly int targetNumber;
        public int Guess { get; private set; }
        public int Attempts { get; private set; }
        public bool GuessedCorrectly { get; private set; }

        public Model()
        {
            targetNumber = random.Next(1, 101);
            Attempts = 0;
            GuessedCorrectly = false;
        }

        public void GuessedCorrectly_Set(bool value)
        {
            GuessedCorrectly = value;
        }

        public void Attempts_Set()
        {
            Attempts++;
        }

        public void Set_Guess(int value)
        {
            Guess = value;
        }
    }
}