using System;
using System.Threading;

public static class AnimationHelper
{
    public static void Spinner(int seconds)
    {
        char[] spin = new[] { '/', '-', '\\', '|' };
        int idx = 0;
        int loops = Math.Max(1, seconds * 5);
        for (int i = 0; i < loops; i++)
        {
            Console.Write(spin[idx]);
            Thread.Sleep(200);
            Console.Write("\b");
            idx = (idx + 1) % spin.Length;
        }
    }

    public static void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(" " + i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
    }
}