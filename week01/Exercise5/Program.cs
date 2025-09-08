using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResult(name, squared);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? :");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? :");
        int number = int.Parse(Console.ReadLine());
        return number;

    }   
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int sqaure)
    {
        Console.WriteLine($"{name} the sqaure of your number is {sqaure}");
    }
}