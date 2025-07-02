class Program
{
    static void Main()
    {
        while (true)
        {
            int magicNumber = new Random().Next(1, 101);
            Console.WriteLine(magicNumber);
            Console.Write("Guess my number from 1 to 100: ");
            int guesses = 0;
            while (true)
            {
                int guess;
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 100)
                {
                    Console.Write("Invalid input, enter a number between 1 and 100: ");
                }
                guesses++;
                if (guess < magicNumber)
                {
                    Console.Write("Too low! Guess again: ");
                }
                else if (guess > magicNumber)
                {
                    Console.Write("Too high! Guess again: ");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Congratulations! You guessed the number! It took you {guesses} tries.");
            if (!PromptYesNo("Do you want to play again? (y/n): "))
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }

    static bool PromptYesNo(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            string response = Console.ReadLine().Trim().ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                return false;
            }
            else
            {
                Console.Write($"Invalid input. {prompt}");
            }
        }
    }
}
