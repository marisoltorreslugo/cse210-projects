using System;

class Program
{
    static void Main(string[] args)
    {
        string start_game = "yes";
        while (start_game.ToLower() == "yes")
        {
            int guess = 0;
            int attempts = 0;
            int secret_number = Random.Shared.Next(1, 101);

            Console.WriteLine($"\nSecret number= {secret_number}");
            while (guess != secret_number)
            {
                Console.Write("\nWhat is your guess? ");
                string guessUser = Console.ReadLine();
                guess = int.Parse(guessUser);
                attempts = ++attempts;

                if (guess < secret_number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > secret_number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("\nYou guessed it!!");
                }
            }
            Console.WriteLine($"It took you {attempts} guesses.\n");
            Console.Write("Would you like to play again (yes/no)? ");
            start_game = Console.ReadLine();

        }
        Console.WriteLine("\nThank you for playing. Goodbye!\n");
    }
}