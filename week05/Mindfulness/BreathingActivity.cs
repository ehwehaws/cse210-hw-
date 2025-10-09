using System;
using System.Diagnostics;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind.")
    {
    }

    protected override void DoActivity()
    {
        var sw = Stopwatch.StartNew();
        bool inb = true;
        int inhale = 4;
        int exhale = 6;

        while (sw.Elapsed.TotalSeconds < Duration)
        {
            if (inb)
            {
                Console.WriteLine();
                Console.Write("Breathe in...");
                AnimationHelper.Countdown(inhale);
            }
            else
            {
                Console.WriteLine();
                Console.Write("Breathe out...");
                AnimationHelper.Countdown(exhale);
            }

            inb = !inb;

            if (sw.Elapsed.TotalSeconds < Duration)
            {
                AnimationHelper.Spinner(1);
            }
        }

        sw.Stop();
    }



}