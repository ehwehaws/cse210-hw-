using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine($"Points: {manager.Score}");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Load");
                Console.WriteLine("6. Quit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.CreateGoal();
                        break;
                    case "2":
                        manager.ListGoals();
                        break;
                    case "3":
                        manager.RecordGoalEvent();
                        break;
                    case "4":
                        manager.SaveGoals();
                        break;
                    case "5":
                        manager.LoadGoals();
                        break;
                    case "6":
                        running = false;
                        break;
                }
            }
        }
    }
}