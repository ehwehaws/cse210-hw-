namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int _target;
        private int _current;
        private int _bonus;

        public ChecklistGoal(string t, string d, int p, int target, int bonus, int current = 0) : base(t, d, p)
        {
            _target = target;
            _bonus = bonus;
            _current = current;
        }

        public override bool IsComplete => _current >= _target;

        public override int RecordEvent()
        {
            if (IsComplete)
            {
                System.Console.WriteLine("Goal already completed.");
                return 0;
            }
            _current++;
            int total = Points;
            if (_current == _target) total += _bonus;
            return total;
        }

        public override string DisplayStatus()
        {
            string box = IsComplete ? "[X]" : "[ ]";
            return $"{box} {_current}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"Checklist|{_title}|{_description}|{_points}|{_target}|{_bonus}|{_current}";
        }
    }
}