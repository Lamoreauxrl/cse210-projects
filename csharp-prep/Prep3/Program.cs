using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        Random randomInt = new Random();

        int magicNumber = randomInt.Next(1, 100);
        int guess = 0;

        do
        {
            Console.Write("Try guessing the magic number: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > magicNumber)
            {
                Console.WriteLine("Need to guess lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Need to guess higher.");
            }
        } while (guess != magicNumber);
        
        Console.WriteLine("Good Job! You got it!");
    }
}