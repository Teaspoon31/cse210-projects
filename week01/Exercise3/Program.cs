using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Create random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // 1 to 100

        int guess = -1; // initialize with a value not equal to magicNumber

        Console.WriteLine("Welcome to Guess My Number!");

        // Loop until the guess matches the magic number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
