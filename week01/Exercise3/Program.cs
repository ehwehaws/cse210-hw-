using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = 1295925;
        int attempts = 0;

        while (guess != number)
        {



            Console.WriteLine("What is your guess? :");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            attempts += 1;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Correct Guess!");
                Console.WriteLine($"It took you {attempts} attempts.");
            }

        }
    }
}