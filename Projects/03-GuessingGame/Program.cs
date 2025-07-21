// Random number guessing game
using System;

class Program
{
    static void Main()
    {
        /*
        Generate random number
        User inputs guess
        Tell if lower or higher, then take a new guess
        Continue until user has correct guess 
        */

        Console.WriteLine("== Guessing Game ==");
        Console.WriteLine("== Guess the secret number between 0 and 50 ==");

        // 1. Generate random number
        Random secretNumberGenerator = new Random();
        int secretNumber = secretNumberGenerator.Next(0, 51);

        // Declasre guess as a Double
        double guess;

        // Take the initial guess
        while (!double.TryParse(Console.ReadLine(), out guess))
        {
            Console.WriteLine("Guess must be a number.");
        }

        // While guess isn't correct, continue to give hints and take new guesses
        while (guess != secretNumber)
        {
            if (guess > secretNumber)
            {
                Console.WriteLine($"{guess} is too high! Guess again.");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine($"{guess} is too low! Guess again.");
            }
            while (!double.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Guess must be a number.");
            }
        }
        // Once guess is same as secretNumber, let user know they won
        Console.WriteLine($"{guess} is the secret number! You win.");
        return;
    }
}