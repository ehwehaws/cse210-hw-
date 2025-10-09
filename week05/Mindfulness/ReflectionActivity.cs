using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a challenge you recently overcame.",
        "Think of something new you have learned recently.",
        "Think of a way you have helped someone recently",
        "think of a time you were proud of yourself."
    };

    private string[] qs = new string[]
    {
        "How did you feel after?",
        "How did you feel after learning something new?",
        "How did helping someone make you feel?",
        "What did you learn about yourself?"
    };

    private Random rnd = new Random();

    public ReflectingActivity() : base("Reflecting Activity", "Reflect on times you were strong."){}

    protected override void DoActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine(prompts[rnd.Next(prompts.Length)]);
        Console.WriteLine();
        Console.WriteLine("press enter to start reflecting");
        Console.ReadLine();

        var sw = Stopwatch.StartNew();

        while (sw.Elapsed.TotalSeconds < Duration)
        {
            Console.WriteLine();
            Console.WriteLine("->" + qs[rnd.Next(qs.Length)]);
            AnimationHelper.Spinner(5);

            if (rnd.Next(0, 3) == 0)
            {
                AnimationHelper.Spinner(1);
            }
        }

        sw.Stop();
    }


}