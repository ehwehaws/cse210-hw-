using System;
using System.Diagnostics;
using System.IO;

public abstract class Activity
{
    private string _activityName;
    private string description;
    private int _durationSeconds;

    protected string ActivityName => _activityName;
    protected string Description => description;
    protected int Duration => _durationSeconds;

    public Activity(string name, string dec)
    {
        _activityName = name;
        description = dec;
        _durationSeconds = 0;
    }

    public void Run()
    {
        StartMessage();
        AskDuration();
        Prepare();
        DoActivity();
        EndMessage();
        LogIt();
    }

    private void StartMessage()
    {
        Console.Clear();
        Console.WriteLine("--- " + _activityName + " ---");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
    }

    private void AskDuration()
    {
        Console.WriteLine("How many seconds? ");
        string s = Console.ReadLine();
        int val;
        if (int.TryParse(s, out val) && val > 0)
        {
            _durationSeconds = val;
        }
        else
        {
            Console.WriteLine("30s (you may have type the number wrong)");
            _durationSeconds = 30;
        }
    }

    private void Prepare()
    {
        Console.WriteLine();
        Console.Write("Prepare ");
        AnimationHelper.Spinner(3);
    }

    private void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Nice work!");
        Console.WriteLine("Completed " + _activityName + " for " + _durationSeconds + " seconds.");
        AnimationHelper.Spinner(2);
        Console.WriteLine();
        Console.WriteLine("press enter to go back");
        Console.ReadLine();
    }

    private void LogIt()
    {
        try
        {
            File.AppendAllLines("activity_log.txt", new[] { DateTime.Now + " | " + _activityName + " | " + _durationSeconds });
        }
        catch { }
    }

    protected abstract void DoActivity();
}