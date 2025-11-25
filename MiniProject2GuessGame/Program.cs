using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Number Guessing Game ===");
            int secret = random.Next(1, 101); // 1 to 100
            int attempts = 0;

            while (true)
            {
                Console.Write("Guess a number between 1 and 100 (or 0 to quit): ");
                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                if (guess == 0)
                {
                    Console.WriteLine("You quit the round.");
                    break;
                }

                attempts++;

                if (guess < secret)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine($"Correct! You guessed it in {attempts} attempts.");
                    break;
                }
            }

            Console.Write("Play again? (Y/N): ");
            string answer = Console.ReadLine()?.Trim().ToUpper();
            if (answer != "Y")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}
