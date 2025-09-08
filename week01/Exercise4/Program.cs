using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //main
        Console.WriteLine("Enter a list of numbers, type 0 when finsished.");
        int number = -1;
        List<int> numbers = new List<int>();
        //loop add nums
        while (number != 0)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        //calc sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");
        //average

        float average = 0f;
        average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");




        //largest number
        int x = 0;
        foreach (int n in numbers)
        {
            if (n > x)
            {
                x = n;
            }

        }
        Console.WriteLine($"The largest number is: {x}");





















    }
}