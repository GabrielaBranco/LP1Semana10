using System;

namespace GuessTheNumber
{
    public class View
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void Congratulate(int attempts)
        {
            Console.WriteLine("Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void EndGame()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }

        public int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }

        public void AskForInput()
        {
            Console.Write("Take a guess: ");
        }

        public void InputTooHigh()
        {
            Console.WriteLine("Too high! Try again.");
        }
        public void InputTooLow()
        {
            Console.WriteLine("Too low! Try again.");
        }
    }
}