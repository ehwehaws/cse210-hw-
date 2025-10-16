using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;
        public int Score => _score;

        public void CreateGoal()
        {
            Console.WriteLine("Type: 1-Simple  2-Eternal  3-Checklist");
            string type = Console.ReadLine();
            Console.Write("Title: ");
            string t = Console.ReadLine();
            Console.Write("Desc: ");
            string d = Console.ReadLine();
            Console.Write("Points: ");
            int p = int.Parse(Console.ReadLine());

            if (type == "1")
                _goals.Add(new SimpleGoal(t, d, p));
            else if (type == "2")
                _goals.Add(new EternalGoal(t, d, p));
            else if (type == "3")
            {
                Console.Write("Target count: ");
                int tar = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int b = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(t, d, p, tar, b));
            }
        }

        public void ListGoals()
        {
            Console.WriteLine();
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i].DisplayStatus()} {_goals[i].Title}");
            }
        }

        public void RecordGoalEvent()
        {
            ListGoals();
            Console.Write("Which one? ");
            int idx;
            if (int.TryParse(Console.ReadLine(), out idx))
            {
                idx--;
                if (idx >= 0 && idx < _goals.Count)
                {
                    int points = _goals[idx].RecordEvent();
                    _score += points;
                    Console.WriteLine($"+{points} points");
                }
            }
        }

        public void SaveGoals()
        {
            using (StreamWriter sw = new StreamWriter("goals.txt"))
            {
                sw.WriteLine(_score);
                foreach (var g in _goals)
                {
                    sw.WriteLine(g.GetStringRepresentation());
                }
            }
        }

        public void LoadGoals()
        {
            if (!File.Exists("goals.txt"))
            {
                Console.WriteLine("No save found");
                return;
            }

            _goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split('|');
                string type = parts[0];
                if (type == "Simple")
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                else if (type == "Eternal")
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                else if (type == "Checklist")
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                        int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
    }
}