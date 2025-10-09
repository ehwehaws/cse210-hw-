using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness");
            Console.WriteLine("-----------------");
            Console.WriteLine("1) Breathing");
            Console.WriteLine("2) Reflecting");
            Console.WriteLine("3) Listing");
            Console.WriteLine("4) Exit");
            Console.WriteLine("pick: ");

            var c = Console.ReadLine();
            if (c == "1")
            {
                var b = new BreathingActivity();
                b.Run();
            }
            else if (c == "2")
            {
                var r = new ReflectingActivity();
                r.Run();
            }
            else if (c == "3")
            {
                var l = new ListingActivity();
                l.Run();
            }
            else if (c == "4")
            {
                Console.WriteLine("bye");
                break;
            }
            else
            {
                Console.WriteLine("Try again, press enter");
                Console.ReadLine();
            }
        }
    }
}