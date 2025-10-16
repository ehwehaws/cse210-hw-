namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        private bool _done;

        public SimpleGoal(string t, string d, int p, bool done = false) : base(t, d, p)
        {
            _done = done;
        }

        public override bool IsComplete => _done;

        public override int RecordEvent()
        {
            if (_done) {
                System.Console.WriteLine("Already done.");
                return 0;
            }
            _done = true;
            return Points;
        }

        public override string DisplayStatus()
        {
            return _done ? "[X]" : "[ ]";
        }

        public override string GetStringRepresentation()
        {
            return $"Simple|{_title}|{_description}|{_points}|{_done}";
        }
    }
}