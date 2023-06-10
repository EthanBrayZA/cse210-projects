using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);

        int new_guess = -1;

        while (new_guess != MagicNumber)
        {
            Console.WriteLine("What is your guess? ");
            new_guess = int.Parse(Console.ReadLine());

            if (new_guess > MagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (new_guess < MagicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        } 
        
    }
}