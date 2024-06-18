using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 10);

        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
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