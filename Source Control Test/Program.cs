using System;

class Program
{
    static void Main()
    {
        HelloName();
        NumberGuesser();
    }

    static void HelloName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! How are you doing today?");
    }

    static void NumberGuesser()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;
        Console.WriteLine("Guess a number between 1 and 100:");

        while (userGuess != numberToGuess)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out userGuess))
            {
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the number!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine("Why Hello World! How are you today?");
    }
}
