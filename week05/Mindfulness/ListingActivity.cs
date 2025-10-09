using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people you appreciate?",
        "What are some personal strengths of yours?",
        "Who did you help this week?",
        "What are small wins you had recently?"
    };

    private Random r = new Random();

    public ListingActivity() : base("Listing Activity",
        "List items for the prompt. Try to get as many as you can before time runs out.")
    {
    }

    protected override void DoActivity()
    {
        string prompt = prompts[r.Next(prompts.Length)];
        Console.WriteLine();
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine();
        Console.WriteLine("Think for a bit, then press Enter to start listing.");
        Console.ReadLine();

        AnimationHelper.Countdown(4);

        Console.WriteLine("Start listing. Press Enter after each item.");

        List<string> items = new List<string>();
        var sw = Stopwatch.StartNew();
        int dur = Duration;

        while (sw.Elapsed.TotalSeconds < dur)
        {
            int remaining = Math.Max(0, dur - (int)sw.Elapsed.TotalSeconds);
            Console.Write($"\rTime left: {remaining,3}s > ");

            string line = ReadLineTimeout(remaining).GetAwaiter().GetResult();
            if (line == null)
            {
                break;
            }
            if (!string.IsNullOrWhiteSpace(line))
            {
                items.Add(line.Trim());
            }
        }

        sw.Stop();
        Console.WriteLine();
        Console.WriteLine("You entered " + items.Count + " items:");
        foreach (var i in items)
        {
            Console.WriteLine("- " + i);
        }
    }
    private async Task<string> ReadLineTimeout(int seconds)
    {
        if (seconds <= 0) return null;
        var t = Task.Run(() => Console.ReadLine());
        var delay = Task.Delay(seconds * 1000);
        var done = await Task.WhenAny(t, delay);
        if (done == t) return t.Result;
        return null;
    }
}