namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string t, string d, int p) : base(t, d, p)
        {
        }

        public override bool IsComplete
        {
            get { return false; }
        }

        public override int RecordEvent()
        {
           
            return Points;
        }

        public override string DisplayStatus()
        {
            return "[infinity]";
        }

        public override string GetStringRepresentation()
        {
            return $"Eternal|{_title}|{_description}|{_points}";
        }
    }
}