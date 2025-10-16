namespace EternalQuest
{
    abstract class Goal
    {
        protected string _title;
        protected string _description;
        protected int _points;

        public Goal(string title, string desc, int points)
        {
            _title = title;
            _description = desc;
            _points = points;
        }

        public string Title { get { return _title; } }
        public string Description { get { return _description; } }
        public int Points { get { return _points; } }

        public abstract bool IsComplete { get; }
        public abstract int RecordEvent();
        public abstract string DisplayStatus();
        public abstract string GetStringRepresentation();
    }
}