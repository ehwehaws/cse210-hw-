using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What's your first name? :");
        string first = Console.ReadLine();

        Console.Write("What's your last name? :");
        string second = Console.ReadLine();

        Console.WriteLine($"Your name is {second}, {first} {second}");
    }
}