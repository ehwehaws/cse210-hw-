using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {



        Journal journal = new Journal();
        Random rnd = new Random();

        List<string> prompts = new List<string>()
        {
            "What was your favorite activity today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the most interesting part of your day?",
            "What was the first thing you did today?",
            "Who was the first person you talked to today?"
        };

        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Write choice here: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts[rnd.Next(prompts.Count)];
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? :");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
            }

        }
    }
}